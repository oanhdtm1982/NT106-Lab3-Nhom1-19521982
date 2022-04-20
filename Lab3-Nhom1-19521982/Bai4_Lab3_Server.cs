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
using System.Runtime.Serialization.Formatters.Binary;

namespace Lab3_Nhom1_19521982
{
    public partial class Bai4_Lab3_Server : Form
    {
        public Bai4_Lab3_Server()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Connect();
        }

        byte[] Serialize(object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, obj);
            return stream.ToArray();
        }
        object Deserialize(byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter formatter = new BinaryFormatter();
            return formatter.Deserialize(stream);
        }
        
        // Đóng kết nối
        private void CloseFormServer(object sender, FormClosedEventArgs e)
        {
            Close();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            foreach (Socket item in clientList)
            {
                Send(item);
            }
            AddMessage(tbMessage.Text);
            tbMessage.Clear();
        }

        IPEndPoint IP;
        Socket server;
        List<Socket> clientList;
        void Connect()
        {
            clientList = new List<Socket>();
            IP = new IPEndPoint(IPAddress.Any, 8080);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            server.Bind(IP);

            Thread Listen = new Thread(() =>
            {
                try
                {
                    while (true)
                    {
                        server.Listen(100);
                        Socket client = server.Accept();
                        clientList.Add(client);
                        Thread receive = new Thread(Receive);
                        receive.IsBackground = true;
                        receive.Start(client);
                    }
                }
                catch
                {
                    IP = new IPEndPoint(IPAddress.Any, 8080);
                    server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

                }
            });

            Listen.IsBackground = true;
            Listen.Start();
        }

        void Close()
        {
            server.Close();
        }

        void Send(Socket client)
        {
            if (client != null && tbMessage.Text != string.Empty)
                client.Send(Serialize(tbMessage.Text));
        }

        void Receive(Object obj)
        {
            Socket client = obj as Socket;
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);

                    string message = (string)Deserialize(data);

                    foreach (var item in clientList)
                    {
                        if (item != null && item != client)
                            item.Send(Serialize(message));
                    }

                    AddMessage(message);
                }
            }
            catch
            {
                clientList.Remove(client);
                client.Close();
            }

        }

        void AddMessage(string s)
        {
            lvMessage.Items.Add(new ListViewItem() { Text = s });
        }
    }
}
