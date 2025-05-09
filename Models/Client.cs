using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using BatailleChimiqueWinform.Controller;
using BatailleChimiqueWinform.Models;

namespace Socket_client
{
    class Client
    {
        private Socket _ClientSocket;
        private IPEndPoint _IpEndPoint;
        private bool _WriteMode = false;
        private MainController _Controller;

        public Client(MainController controller)
        {
            IPHostEntry ipEntry = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress ip = ipEntry.AddressList[0];
            _Controller = controller;
        }
        private void InitializeConnection(Byte[] ipServeur)
        {
            IPAddress ip2 = new IPAddress(ipServeur);
            _IpEndPoint = new(ip2, 1234);

            this._ClientSocket = new(
                _IpEndPoint.AddressFamily,
                SocketType.Stream,
                ProtocolType.Tcp
                );
        }
        private async Task Connect(Byte[] ip)
        {
            InitializeConnection(ip);
            await this._ClientSocket.ConnectAsync(_IpEndPoint);


            string message = ListenAndReceiveMessage();
            if (message == "0")
            {
                _WriteMode = true;
            }
            else
            {
                _WriteMode = false;
            }
            MessageBox.Show("Connected to server");
        }


        public void Disconnect()
        {
            _ClientSocket.Shutdown(SocketShutdown.Both);
            _ClientSocket.Close();
        }

        private async Task SendMessage(string message)
        {
            var MessageByte = Encoding.UTF8.GetBytes(message);
            await _ClientSocket.SendAsync(MessageByte, SocketFlags.None);
        }

        private string ListenAndReceiveMessage()
        {
            byte[] buffer = new byte[1_024];
            var Received = _ClientSocket.Receive(buffer);
            var message = Encoding.UTF8.GetString(buffer, 0, Received);
            _WriteMode = true;
            return message;
        }

        public async Task Start(Byte[] ip)
        {
            await Connect(ip);
        }

        public bool GetWriteMode()
        {
            return _WriteMode;
        }

        public async Task<string> sendAttack(Coordinate coord)
        {
            string message = "A" + coord.X.ToString() + coord.Y.ToString();
            await SendMessage(message);
            string response = ListenAndReceiveMessage();
            return response;
        }

        public async Task EndTurn()
        {
            string message = "E";
            await SendMessage(message);
            _WriteMode = false;
        }

        public async Task listen()
        {
            while (true)
            {
                string message = ListenAndReceiveMessage();
                if (message[0] == 'A')
                {
                    int x = Convert.ToInt32(message[1].ToString());
                    int y = Convert.ToInt32(message[2].ToString());
                    Coordinate coord = new(x, y);
                    // Handle attack
                    bool isTouch = _Controller.IsBoatAt(coord);
                    string response = isTouch.ToString();
                    _Controller.TakeDamage(coord);
                    await SendMessage(response);
                }
                else if (message[0] == 'E')
                {
                    _WriteMode = true;
                    _Controller.SwapTurn();
                    _Controller.SetPlayerTurnMessage();
                    return;
                }
            }
        }
    }
}
