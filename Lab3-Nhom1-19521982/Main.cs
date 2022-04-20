using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_Nhom1_19521982
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnServerB1_Click(object sender, EventArgs e)
        {
            Bai1_Lab3_UDP_Server bai1Server = new Bai1_Lab3_UDP_Server();
            bai1Server.Show();
        }

        private void btnClientB1_Click(object sender, EventArgs e)
        {
            Bai1_Lab3_UDP_Client baiClient = new Bai1_Lab3_UDP_Client();
            baiClient.Show();
        }

        private void btnServerB4_Click(object sender, EventArgs e)
        {
            Bai4_Lab3_Server bai4Server = new Bai4_Lab3_Server();
            bai4Server.Show();
        }

        private void btnClientB4_Click(object sender, EventArgs e)
        {
            Bai4_Lab3_Client bai4Client = new Bai4_Lab3_Client();
            bai4Client.Show();
        }

        private void btnServerB2_Click(object sender, EventArgs e)
        {
            Bai2_Lab3_Server bai2Server = new Bai2_Lab3_Server();
            bai2Server.Show();
        }

        private void btnClientB3_Click(object sender, EventArgs e)
        {
            Bai3_Lab3_Client bai3Client = new Bai3_Lab3_Client();
            bai3Client.Show();
        }

        private void btnServerB3_Click(object sender, EventArgs e)
        {
            Bai3_Lab3_Server bai3Server = new Bai3_Lab3_Server();
            bai3Server.Show();
        }
    }
}
