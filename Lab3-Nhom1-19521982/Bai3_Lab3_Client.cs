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
    public partial class Bai3_Lab3_Client : Form
    {
        public Bai3_Lab3_Client()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        IPEndPoint IPEP;
        TcpClient Client;
        Stream stream;


        private void btConnect_Click(object sender, EventArgs e)
        {
            IPEP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            Client = new TcpClient();
            Client.Connect(IPEP);
            stream = Client.GetStream();
            Thread Recv = new Thread(Receive);
            Recv.IsBackground = true;
            Recv.Start();
            lbTB.Text = "Connecting....";
            byte[] data = Encoding.UTF8.GetBytes("You: Hello Server" +
                " ");
            stream.Write(data, 0, data.Length);
            int Portnumber;
            if (Int32.TryParse(txtPort.Text, out Portnumber))
            {
                Portnumber = Int32.Parse(txtPort.Text.Trim());


            }
            else
            {
                MessageBox.Show("Nhập port sai! Vui lòng nhập lại", "Notification", MessageBoxButtons.OK);
            }


        }

        private void btSend_Click(object sender, EventArgs e)
        {
            byte[] data = Encoding.UTF8.GetBytes("127.0.0.1:" + txtMessage.Text);
            stream.Write(data, 0, data.Length);
            listViewClient.Items.Add("Me: " + txtMessage.Text);
            txtMessage.Text = "";
        }
        void Receive(Object obj)
        {
            while (true)
            {
                byte[] recv = new byte[1000];
                stream.Read(recv, 0, recv.Length);
                string str = Encoding.UTF8.GetString(recv);
                Addmessage(str);

            }
        }
        void Addmessage(string message)
        {
            listViewClient.Items.Add(message);

        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

