using System;
using System.Threading;
using System.Windows.Forms;

namespace DemonstrasiSocket
{
    public partial class FrmDemoSocketClientServer : Form
    {
        public FrmDemoSocketClientServer()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            Thread thr = new Thread(listenSocket);
            if (txtPortServer.Text != "" && txtIPServer.Text != "")
            {
                thr.Start();
                btnListen.Enabled = false;
            }
            else
            {
                MessageBox.Show("Lengkapi port dan alamat IP terlebih dahulu ! ! !");
            }
        }

        private void listenSocket()
        {
            varGlobal.port = Int16.Parse(txtPortServer.Text); // konversi dari string ke integer
            varGlobal.alamatIPServer = txtIPServer.Text;
            SocketTCP.StartListening();
        }

        private void btnKirimDataKeServer_Click(object sender, EventArgs e)
        {
            varGlobal.alamatIPServer = txtIPTujuan.Text;
            varGlobal.port = Int16.Parse(txtPortClient.Text);
            SocketTCP.StartClient(txtKirimData.Text);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtTerimaData.Clear();
            txtTerimaData.Text = varGlobal.terimapesandiserver;
        }
    }
}
