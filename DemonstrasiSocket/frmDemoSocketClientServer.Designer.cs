namespace DemonstrasiSocket
{
    partial class FrmDemoSocketClientServer
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpServer = new System.Windows.Forms.TabPage();
            this.txtIPServer = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTerimaData = new System.Windows.Forms.TextBox();
            this.btnListen = new System.Windows.Forms.Button();
            this.txtPortServer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tpClient = new System.Windows.Forms.TabPage();
            this.btnKirimDataKeServer = new System.Windows.Forms.Button();
            this.txtKirimData = new System.Windows.Forms.TextBox();
            this.txtIPTujuan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPortClient = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tpServer.SuspendLayout();
            this.tpClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpServer);
            this.tabControl1.Controls.Add(this.tpClient);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(518, 331);
            this.tabControl1.TabIndex = 0;
            // 
            // tpServer
            // 
            this.tpServer.Controls.Add(this.txtIPServer);
            this.tpServer.Controls.Add(this.label7);
            this.tpServer.Controls.Add(this.txtTerimaData);
            this.tpServer.Controls.Add(this.btnListen);
            this.tpServer.Controls.Add(this.txtPortServer);
            this.tpServer.Controls.Add(this.label1);
            this.tpServer.Location = new System.Drawing.Point(4, 22);
            this.tpServer.Name = "tpServer";
            this.tpServer.Padding = new System.Windows.Forms.Padding(3);
            this.tpServer.Size = new System.Drawing.Size(510, 305);
            this.tpServer.TabIndex = 0;
            this.tpServer.Text = "Server";
            this.tpServer.UseVisualStyleBackColor = true;
            // 
            // txtIPServer
            // 
            this.txtIPServer.Location = new System.Drawing.Point(204, 11);
            this.txtIPServer.Name = "txtIPServer";
            this.txtIPServer.Size = new System.Drawing.Size(152, 20);
            this.txtIPServer.TabIndex = 8;
            this.txtIPServer.Text = "192.168.1.6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(147, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "IP Server";
            // 
            // txtTerimaData
            // 
            this.txtTerimaData.Location = new System.Drawing.Point(11, 37);
            this.txtTerimaData.Multiline = true;
            this.txtTerimaData.Name = "txtTerimaData";
            this.txtTerimaData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTerimaData.Size = new System.Drawing.Size(482, 170);
            this.txtTerimaData.TabIndex = 3;
            // 
            // btnListen
            // 
            this.btnListen.Location = new System.Drawing.Point(362, 8);
            this.btnListen.Name = "btnListen";
            this.btnListen.Size = new System.Drawing.Size(75, 23);
            this.btnListen.TabIndex = 2;
            this.btnListen.Text = "Listen";
            this.btnListen.UseVisualStyleBackColor = true;
            this.btnListen.Click += new System.EventHandler(this.btnListen_Click);
            // 
            // txtPortServer
            // 
            this.txtPortServer.Location = new System.Drawing.Point(40, 11);
            this.txtPortServer.Name = "txtPortServer";
            this.txtPortServer.Size = new System.Drawing.Size(100, 20);
            this.txtPortServer.TabIndex = 1;
            this.txtPortServer.Text = "16375";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port";
            // 
            // tpClient
            // 
            this.tpClient.Controls.Add(this.btnKirimDataKeServer);
            this.tpClient.Controls.Add(this.txtKirimData);
            this.tpClient.Controls.Add(this.txtIPTujuan);
            this.tpClient.Controls.Add(this.label4);
            this.tpClient.Controls.Add(this.txtPortClient);
            this.tpClient.Controls.Add(this.label3);
            this.tpClient.Location = new System.Drawing.Point(4, 22);
            this.tpClient.Name = "tpClient";
            this.tpClient.Padding = new System.Windows.Forms.Padding(3);
            this.tpClient.Size = new System.Drawing.Size(510, 305);
            this.tpClient.TabIndex = 1;
            this.tpClient.Text = "Client";
            this.tpClient.UseVisualStyleBackColor = true;
            // 
            // btnKirimDataKeServer
            // 
            this.btnKirimDataKeServer.Location = new System.Drawing.Point(408, 255);
            this.btnKirimDataKeServer.Name = "btnKirimDataKeServer";
            this.btnKirimDataKeServer.Size = new System.Drawing.Size(75, 23);
            this.btnKirimDataKeServer.TabIndex = 7;
            this.btnKirimDataKeServer.Text = "Kirim";
            this.btnKirimDataKeServer.UseVisualStyleBackColor = true;
            this.btnKirimDataKeServer.Click += new System.EventHandler(this.btnKirimDataKeServer_Click);
            // 
            // txtKirimData
            // 
            this.txtKirimData.Location = new System.Drawing.Point(13, 33);
            this.txtKirimData.Multiline = true;
            this.txtKirimData.Name = "txtKirimData";
            this.txtKirimData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtKirimData.Size = new System.Drawing.Size(470, 216);
            this.txtKirimData.TabIndex = 6;
            // 
            // txtIPTujuan
            // 
            this.txtIPTujuan.Location = new System.Drawing.Point(187, 7);
            this.txtIPTujuan.Name = "txtIPTujuan";
            this.txtIPTujuan.Size = new System.Drawing.Size(153, 20);
            this.txtIPTujuan.TabIndex = 3;
            this.txtIPTujuan.Text = "192.168.1.6";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "IP Tujuan";
            // 
            // txtPortClient
            // 
            this.txtPortClient.Location = new System.Drawing.Point(42, 6);
            this.txtPortClient.Name = "txtPortClient";
            this.txtPortClient.Size = new System.Drawing.Size(70, 20);
            this.txtPortClient.TabIndex = 1;
            this.txtPortClient.Text = "16375";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Port";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmDemoSocketClientServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 331);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmDemoSocketClientServer";
            this.Text = "Demo Socket TCP";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpServer.ResumeLayout(false);
            this.tpServer.PerformLayout();
            this.tpClient.ResumeLayout(false);
            this.tpClient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpServer;
        private System.Windows.Forms.TabPage tpClient;
        private System.Windows.Forms.TextBox txtTerimaData;
        private System.Windows.Forms.Button btnListen;
        private System.Windows.Forms.TextBox txtPortServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIPTujuan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPortClient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnKirimDataKeServer;
        private System.Windows.Forms.TextBox txtKirimData;
        private System.Windows.Forms.TextBox txtIPServer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timer1;
    }
}

