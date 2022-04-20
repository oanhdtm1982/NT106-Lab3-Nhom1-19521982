namespace Lab3_Nhom1_19521982
{
    partial class Bai3_Lab3_Server
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btClose = new System.Windows.Forms.Button();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btListen = new System.Windows.Forms.Button();
            this.listViewServer = new System.Windows.Forms.ListView();
            this.lbTB = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btClose
            // 
            this.btClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.Location = new System.Drawing.Point(637, 23);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(144, 39);
            this.btClose.TabIndex = 11;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // txtPort
            // 
            this.txtPort.Enabled = false;
            this.txtPort.Location = new System.Drawing.Point(329, 31);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(134, 22);
            this.txtPort.TabIndex = 9;
            this.txtPort.Text = "8080";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(274, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "IP Address";
            // 
            // btListen
            // 
            this.btListen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btListen.Location = new System.Drawing.Point(487, 23);
            this.btListen.Name = "btListen";
            this.btListen.Size = new System.Drawing.Size(144, 39);
            this.btListen.TabIndex = 12;
            this.btListen.Text = "Listen";
            this.btListen.UseVisualStyleBackColor = true;
            this.btListen.Click += new System.EventHandler(this.btListen_Click);
            // 
            // listViewServer
            // 
            this.listViewServer.HideSelection = false;
            this.listViewServer.Location = new System.Drawing.Point(24, 64);
            this.listViewServer.Name = "listViewServer";
            this.listViewServer.Size = new System.Drawing.Size(756, 326);
            this.listViewServer.TabIndex = 13;
            this.listViewServer.UseCompatibleStateImageBehavior = false;
            this.listViewServer.View = System.Windows.Forms.View.List;
            // 
            // lbTB
            // 
            this.lbTB.AutoSize = true;
            this.lbTB.ForeColor = System.Drawing.Color.DarkRed;
            this.lbTB.Location = new System.Drawing.Point(23, 404);
            this.lbTB.Name = "lbTB";
            this.lbTB.Size = new System.Drawing.Size(83, 16);
            this.lbTB.TabIndex = 14;
            this.lbTB.Text = "Noticification";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(105, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(134, 22);
            this.textBox1.TabIndex = 15;
            this.textBox1.Text = "127.0.0.1";
            // 
            // Bai3_Lab3_Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbTB);
            this.Controls.Add(this.listViewServer);
            this.Controls.Add(this.btListen);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Bai3_Lab3_Server";
            this.Text = "Bai3_Lab3_Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btListen;
        private System.Windows.Forms.ListView listViewServer;
        private System.Windows.Forms.Label lbTB;
        private System.Windows.Forms.TextBox textBox1;
    }
}