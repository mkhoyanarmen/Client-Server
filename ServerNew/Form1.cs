using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerNew
{
    public partial class frmServer : Form
    {
        public frmServer()
        {
            InitializeComponent();
        }
        IPEndPoint iPEnd;
        Socket socket;
        string messageFromServer;
        Socket tcpClient;
        private void btnRunServer_Click(object sender, EventArgs e)
        {
            iPEnd = new IPEndPoint(Dns.GetHostByName(Dns.GetHostName()).AddressList[0], 8888);
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            if (btnRunServer.Text == "Միացնել Սերվերը")
            {
                btnRunServer.Text = "Անջատել Սերվերը";
                gbMessage.Enabled = true;
                socket.Bind(iPEnd);
                socket.Listen(1000);
                tcpClient = socket.Accept();
            }
            else
            {
                socket.Close();
                btnRunServer.Text = "Միացնել Սերվերը";
                gbMessage.Enabled = false;
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            
            txtMessageFromClient.Text = tcpClient.RemoteEndPoint.ToString();
        }
    }
}
