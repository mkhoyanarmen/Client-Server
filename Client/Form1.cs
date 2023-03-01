using System;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace Client
{
    public partial class frmClient : Form
    {
        public frmClient()
        {
            InitializeComponent();
        }

        Socket tcpClient;
        IPEndPoint ipServer;
        private void frmClient_Load(object sender, EventArgs e)
        {
            this.Text = Dns.GetHostName();
        }
        private void btnRunChat_Click(object sender, EventArgs e)
        {
            if (btnRunChat.Text == "Connect to the Server")
            {
                ipServer = new IPEndPoint(IPAddress.Parse("192.168.1.5"), 8000);
                tcpClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                tcpClient.Connect(ipServer);
                btnRunChat.Text = "Disconnect from the Server";
                txtMessageToServer.Enabled = btnSend.Enabled = true;
                this.AcceptButton = btnSend;
                backgroundWorkerClient.RunWorkerAsync();
            }
            else
            {
                btnRunChat.Text = "Connect to the Server";
                txtMessageToServer.Enabled = btnSend.Enabled = false;
                backgroundWorkerClient.CancelAsync();
                tcpClient.Dispose();
                tcpClient.Close();
            }
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                tcpClient.Send(Encoding.UTF8.GetBytes(txtMessageToServer.Text));
                lstSendedMessages.Items.Add("Me: " + txtMessageToServer.Text);
                lstTime.Items.Add(DateTime.Now.Hour + ":" + DateTime.Now.Minute + "." + DateTime.Now.Second);
                lstSendedMessages.SelectedIndex = lstSendedMessages.Items.Count - 1;
                lstTime.SelectedIndex = lstTime.Items.Count - 1;
                txtMessageToServer.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Server not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            try
            {
                while (tcpClient.Connected)
                {
                    byte[] data1 = new byte[1024];
                    int bytes = tcpClient.Receive(data1);
                    string message = Encoding.UTF8.GetString(data1, 0, bytes);
                    this.lstSendedMessages.Invoke(new MethodInvoker(delegate ()
                    {
                        lstTime.Items.Add(DateTime.Now.Hour + ":" + DateTime.Now.Minute + "." + DateTime.Now.Second);
                        lstSendedMessages.Items.Add("Server: " + message);
                        lstSendedMessages.SelectedIndex = lstSendedMessages.Items.Count - 1;
                        lstTime.SelectedIndex = lstTime.Items.Count - 1;
                    }));
                }
                backgroundWorkerClient.CancelAsync();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}