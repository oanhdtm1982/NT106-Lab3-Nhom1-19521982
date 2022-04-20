using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Lab3_Nhom1_19521982
{
    public partial class Bai2_Lab3_Server : Form
    {
        public Bai2_Lab3_Server()
        {
            InitializeComponent();
        }

        private void btListen_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread server = new Thread(new ThreadStart(ListenThread));
            server.Start();
        }
        void ListenThread()
        {
            int bytesRcv = 0;
            byte[] rcv = new byte[1];
            Socket client;
            Socket ListenSK = new Socket(
                AddressFamily.InterNetwork,
                SocketType.Stream,
                ProtocolType.Tcp);
            IPEndPoint ipepServer = new IPEndPoint(Dns.GetHostByName(Dns.GetHostName()).AddressList[0], 8080);
            ListenSK.Bind(ipepServer);
            ListenSK.Listen(-1);
            client = ListenSK.Accept();

            listViewCommand.Items.Add(new ListViewItem("New client connected"));
            while (client.Connected)
            {
                string text = "";

                do
                {
                    bytesRcv = client.Receive(rcv);
                    text += Encoding.ASCII.GetString(rcv);

                }
                while (text[text.Length - 1] != '\n');
                listViewCommand.Items.Add(new ListViewItem(text));
            }
            ListenSK.Close();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có chắc muốn thoát1", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (MessageBox.Show("Bạn có chắc muốn thoát1", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
