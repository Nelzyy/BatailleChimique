using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BatailleChimiqueWinform.Controller;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BatailleChimiqueWinform.Views
{
    public partial class IpAsk : Form
    {
        private MainController _Controller;
        public IpAsk(MainController controller)
        {
            _Controller = controller;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Please enter an IP address.");
                return;
            }
            string[] strings = new string[4];
            strings[0] = textBox1.Text;
            strings[1] = textBox2.Text;
            strings[2] = textBox3.Text;
            strings[3] = textBox4.Text;
            foreach (string number in strings)
            {
                int n = Convert.ToInt32(number);
                if (n <= 0 && n >= 255)
                {
                    MessageBox.Show("Mauvaise IP rentré");
                    return;
                }
            }
            Byte[] ipAddressByte = new Byte[4];
            for (int i = 0; i < strings.Length; i++)
            {
                ipAddressByte[i] = Convert.ToByte(strings[i]);
            }
            _Controller.SetIp(ipAddressByte);
            this.Hide();
        }
    }
}

