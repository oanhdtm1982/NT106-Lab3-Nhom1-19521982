using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace Lab3_Nhom1_19521982
{
    public partial class Bai1_Lab3_UDP_Client : Form
    {
        public Bai1_Lab3_UDP_Client()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (tbIP.Text != null && tbPort.Text != null)
            {
                UdpClient udpClient = new UdpClient();
                udpClient.Connect(tbIP.Text, int.Parse(tbPort.Text));
                Byte[] message = Encoding.UTF8.GetBytes(rtbMessage.Text);
                udpClient.Send(message, message.Length);
                rtbMessage.Clear();
                udpClient.Close();
               
            }
            else {
                MessageBox.Show("Nhập chính xác thông tin IP và port", "Thông báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
