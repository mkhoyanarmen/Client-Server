using System;
using System.ComponentModel;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace ServerForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Socket server;
        IPEndPoint iPEnd;
        Socket tcpClient;
        private void btnRunChat_Click(object sender, EventArgs e)
        {
            if (btnRunServer.Text == "Run Server")
            {
                server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                iPEnd = new IPEndPoint(IPAddress.Any, 8000);
                server.Bind(iPEnd);
                server.Listen(1000);

                tcpClient = server.Accept();
                lstClients.Items.Add(tcpClient.LocalEndPoint + "   " + Dns.GetHostName());

                btnRunServer.Text = "Turn off Server";
                btnSend.Enabled = txtMessageToClient.Enabled = true;
                backgroundWorkerServer.RunWorkerAsync();
                this.AcceptButton = btnSend;
            }
            else
            {
                btnRunServer.Text = "Run Server";
                btnSend.Enabled = txtMessageToClient.Enabled = false;
                backgroundWorkerServer.CancelAsync();
                tcpClient.Dispose();
                server.Dispose();
                server.Close();
                lstClients.Items.Clear();
            }
        }

        private void backgroundWorkerServer_DoWork(object sender, DoWorkEventArgs e)
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
                        lstSendedMessages.Items.Add("Client: " + message);
                        lstSendedMessages.SelectedIndex = lstSendedMessages.Items.Count - 1;
                        lstTime.SelectedIndex = lstTime.Items.Count - 1;
                    }));
                }
                backgroundWorkerServer.CancelAsync();
            }
            catch (Exception)
            {
                backgroundWorker.RunWorkerAsync();
                lstClients.Items.Clear();
                txtMessageToClient.Enabled = btnSend.Enabled = false;
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            tcpClient.Send(Encoding.UTF8.GetBytes(txtMessageToClient.Text));
            lstSendedMessages.Items.Add("Me: " + txtMessageToClient.Text);
            lstTime.Items.Add(DateTime.Now.Hour + ":" + DateTime.Now.Minute + "." + DateTime.Now.Second);
            lstSendedMessages.SelectedIndex = lstSendedMessages.Items.Count - 1;
            lstTime.SelectedIndex = lstTime.Items.Count - 1;
            txtMessageToClient.Text = "";
        }
        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            if (!tcpClient.Connected)
            {
                tcpClient = server.Accept();
                lstClients.Items.Add(tcpClient.LocalEndPoint + "   " + Dns.GetHostName());
                txtMessageToClient.Enabled = btnSend.Enabled = true;
                backgroundWorkerServer.RunWorkerAsync();
            }
        }
    }
}