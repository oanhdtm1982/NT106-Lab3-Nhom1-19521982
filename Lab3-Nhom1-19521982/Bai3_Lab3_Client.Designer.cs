namespace Lab3_Nhom1_19521982
{
    partial class Bai3_Lab3_Client
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.btConnect = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.listViewClient = new System.Windows.Forms.ListView();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btSend = new System.Windows.Forms.Button();
            this.lbTB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(279, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(126, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(134, 22);
            this.textBox1.TabIndex = 2;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(334, 41);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(134, 22);
            this.txtPort.TabIndex = 3;
            // 
            // btConnect
            // 
            this.btConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConnect.Location = new System.Drawing.Point(492, 33);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(144, 39);
            this.btConnect.TabIndex = 4;
            this.btConnect.Text = "Connect";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // btClose
            // 
            this.btClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.Location = new System.Drawing.Point(642, 33);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(144, 39);
            this.btClose.TabIndex = 5;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            // 
            // listViewClient
            // 
            this.listViewClient.HideSelection = false;
            this.listViewClient.Location = new System.Drawing.Point(27, 90);
            this.listViewClient.Name = "listViewClient";
            this.listViewClient.Size = new System.Drawing.Size(758, 257);
            this.listViewClient.TabIndex = 6;
            this.listViewClient.UseCompatibleStateImageBehavior = false;
            this.listViewClient.View = System.Windows.Forms.View.List;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(29, 370);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(606, 45);
            this.txtMessage.TabIndex = 7;
            // 
            // btSend
            // 
            this.btSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSend.Location = new System.Drawing.Point(641, 370);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(144, 39);
            this.btSend.TabIndex = 8;
            this.btSend.Text = "Send";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // lbTB
            // 
            this.lbTB.AutoSize = true;
            this.lbTB.ForeColor = System.Drawing.Color.DarkRed;
            this.lbTB.Location = new System.Drawing.Point(33, 426);
            this.lbTB.Name = "lbTB";
            this.lbTB.Size = new System.Drawing.Size(83, 16);
            this.lbTB.TabIndex = 9;
            this.lbTB.Text = "Noticification";
            // 
            // Bai3_Lab3_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbTB);
            this.Controls.Add(this.btSend);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.listViewClient);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btConnect);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Bai3_Lab3_Client";
            this.Text = "Bai3_Lab3_Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.ListView listViewClient;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.Label lbTB;
    }
}