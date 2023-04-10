using SuperSimpleTcp;
using System.Text;

namespace TcpServerB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SimpleTcpServer tcpServer;
        private void btnStart_Click(object sender, EventArgs e)
        {
            tcpServer.Start();
            tbInfo.Text += $"Starting...{Environment.NewLine}";
            btnStart.Enabled = false;
            btnSend.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnSend.Enabled = false;
            tcpServer = new SimpleTcpServer(tbIP.Text);
            tcpServer.Events.ClientConnected += Events_ClientConnected;
            tcpServer.Events.ClientDisconnected += Events_ClientDisconnected;
            tcpServer.Events.DataReceived += Events_DataReceived;
        }

        private void Events_DataReceived(object? sender, DataReceivedEventArgs e)
        {
            tbInfo.Text += $"{e.IpPort}:{Encoding.UTF8.GetString(e.Data)}{Environment.NewLine}";
        }

        private void Events_ClientDisconnected(object? sender, ConnectionEventArgs e)
        {
            tbInfo.Text += $"{e.IpPort} disconnected.{Environment.NewLine}";
            lstClientIp.Items.Remove(e.IpPort);
        }

        private void Events_ClientConnected(object? sender, ConnectionEventArgs e)
        {
            tbInfo.Text += $"{e.IpPort} connected.{Environment.NewLine}";
            lstClientIp.Items.Add(e.IpPort);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            //chk message and select client ip from listbox
            if(!string.IsNullOrEmpty(tbInfo.Text)&&lstClientIp.SelectedItems!=null) 
            {
tcpServer.Send(lstClientIp.SelectedItems.ToString(),tbMessage.Text);
                tbInfo.Text +=$"server : {tbMessage.Text}{Environment.NewLine}";
                tbMessage.Text=string.Empty;
            }
        }
    }
}