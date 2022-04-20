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
using System.IO;


namespace Lab3_Nhom1_19521982
{
    public partial class Bai3_Lab3_Server : Form
    {
        public Bai3_Lab3_Server()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            Connect();

        }
        Socket Client;
        IPEndPoint IPEP;
        TcpListener Listener;
        private void btListen_Click(object sender, EventArgs e)
        {
            lbTB.Text = "Listening!";
        }
        void Connect()
        {
            IPEP = new IPEndPoint(IPAddress.Any, 8080);
            Listener = new TcpListener(IPEP);
            Thread thread = new Thread(() =>
            {
                while (true)
                {
                    Listener.Start();
                    Client = Listener.AcceptSocket();
                    Thread receive = new Thread(Receive);
                    receive.IsBackground = true;
                    receive.Start(Client);
                }
            });
            thread.IsBackground = true;
            thread.Start();
            void Receive(Object obj)
            {
                while (true)
                {
                    Socket client = obj as Socket;
                    byte[] recv = new byte[1000];
                    Client.Receive(recv);
                    string str = Encoding.UTF8.GetString(recv);
                    Addmessage(str);

                }
            }
            void Addmessage(string message)
            {
                listViewServer.Items.Add(message);
            }

        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
