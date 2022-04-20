namespace Lab3_Nhom1_19521982
{
    partial class Bai2_Lab3_Server
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
            this.listViewCommand = new System.Windows.Forms.ListView();
            this.btListen = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewCommand
            // 
            this.listViewCommand.HideSelection = false;
            this.listViewCommand.Location = new System.Drawing.Point(19, 83);
            this.listViewCommand.Name = "listViewCommand";
            this.listViewCommand.Size = new System.Drawing.Size(757, 332);
            this.listViewCommand.TabIndex = 0;
            this.listViewCommand.UseCompatibleStateImageBehavior = false;
            this.listViewCommand.View = System.Windows.Forms.View.List;
            // 
            // btListen
            // 
            this.btListen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btListen.Location = new System.Drawing.Point(17, 29);
            this.btListen.Name = "btListen";
            this.btListen.Size = new System.Drawing.Size(143, 43);
            this.btListen.TabIndex = 1;
            this.btListen.Text = "Listen";
            this.btListen.UseVisualStyleBackColor = true;
            this.btListen.Click += new System.EventHandler(this.btListen_Click);
            // 
            // btThoat
            // 
            this.btThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.Location = new System.Drawing.Point(166, 29);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(143, 43);
            this.btThoat.TabIndex = 2;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // Bai2_Lab3_Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btListen);
            this.Controls.Add(this.listViewCommand);
            this.Name = "Bai2_Lab3_Server";
            this.Text = "Bai2_Lab3_Server";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewCommand;
        private System.Windows.Forms.Button btListen;
        private System.Windows.Forms.Button btThoat;
    }
}