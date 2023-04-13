using SuperSimpleTcp;
using System.Text;
using System.Windows.Forms;

namespace TcpServerB
{
    public partial class frmServer : Form
    {
        SimpleTcpServer tcpServer;
        public frmServer()
        {
            InitializeComponent();
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            tcpServer.Start();
            tbInfo.Text += $"Listening...{Environment.NewLine}";
            btnStart.Enabled = false;
            btnSend.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnSend.Enabled = false;
            tcpServer = new SimpleTcpServer(tbIP.Text);
            tcpServer.Events.ClientConnected += Events_ClientConnected;
            tcpServer.Events.DataReceived += Events_DataReceived;
            tcpServer.Events.ClientDisconnected += Events_ClientDisconnected;
        }

        private void Events_ClientConnected(object? sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                tbInfo.Text += $"[{e.IpPort}] client connected.{Environment.NewLine}";
                lstClientIp.Items.Add(e.IpPort);
            });

        }

        private void Events_DataReceived(object? sender, DataReceivedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                tbInfo.Text += $"[{e.IpPort}]: {Encoding.UTF8.GetString(e.Data.Array, 0, e.Data.Count)}{Environment.NewLine}";
            });
        }

        private void Events_ClientDisconnected(object? sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                tbInfo.Text += $"[{e.IpPort}] client disconnected: {e.Reason}{Environment.NewLine}";
                lstClientIp.Items.Remove(e.IpPort);
            });
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (tcpServer.IsListening)
            {
                if (!string.IsNullOrEmpty(tbMessage.Text) && lstClientIp.SelectedItem != null)
                {
                    tcpServer.Send(lstClientIp.SelectedItem.ToString(), tbMessage.Text);
                    tbInfo.Text += $"Server: {tbMessage.Text}{Environment.NewLine}";
                    tbMessage.Text = string.Empty;
                }

                if (lstClientIp.SelectedItem == null)
                    MessageBox.Show("Please choose a client to send message!");
            }

        }
    }
}