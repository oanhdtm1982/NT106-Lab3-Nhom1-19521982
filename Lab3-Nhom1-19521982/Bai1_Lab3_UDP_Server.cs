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
using System.Threading;

namespace Lab3_Nhom1_19521982
{
    public partial class Bai1_Lab3_UDP_Server : Form
    {
        delegate void UpdateMessageDel(string message);
        public Bai1_Lab3_UDP_Server()
        {
            InitializeComponent();
        }
        public void UpdateMessage(string message)
        {
            if (listViewData.InvokeRequired)
            {
                var index = new UpdateMessageDel(UpdateMessage);
                listViewData.Invoke(index, new object[] { message });
                return;
            }
            listViewData.Items.Add(message);
        }

        public void serverThread()
        {
            UdpClient udpClient = new UdpClient(Int32.Parse(tbPort.Text));
            while (true)
            {
                IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Any, 0);
                byte[] receiveBytes = udpClient.Receive(ref iPEndPoint);
                string returnData = Encoding.UTF8.GetString(receiveBytes);
                string message = iPEndPoint.Address.ToString() + ": " + returnData.ToString();
                UpdateMessage(message);
            }
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            Thread threadUDPServer = new Thread(new ThreadStart(serverThread));
            threadUDPServer.Start();
            MessageBox.Show("Listening on port: " + tbPort.Text.ToString());
        }
    }
}
