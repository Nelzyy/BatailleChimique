using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Socket_client
{
    class Client
    {
        private Socket _ClientSocket;
        private IPEndPoint _IpEndPoint;
        private bool _WriteMode = false;

        public Client()
        {
            IPHostEntry ipEntry = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress ip = ipEntry.AddressList[0];
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

        private async Task GetAndSendMessage()
        {
            while (_WriteMode)
            {
                var message = Console.ReadLine();
                if (message != null)
                {
                    await SendMessage(message);
                }
                else
                {
                    Disconnect();
                }
                _WriteMode = false;
            }
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

        public async Task attend()
        {
            while (true)
            {

            }
        }

        public async Task Start(Byte[] ip)
        {
            await Connect(ip);

            //while (true)
            //{
            //    if (_WriteMode)
            //    {
            //        await GetAndSendMessage();
            //    }
            //    else
            //    {
            //        string message = ListenAndReceiveMessage();
            //        Console.WriteLine(message);
            //    }
            //}
        }
    }
}
