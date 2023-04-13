using SuperSimpleTcp;
using System.Text;

namespace TcpClientB
{
    public partial class frmClient : Form
    {
        SimpleTcpClient tcpClient;
        public frmClient()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tcpClient = new(tbIP.Text);
            tcpClient.Events.Connected += Events_Connected;
            tcpClient.Events.DataReceived += Events_DataReceived;
            tcpClient.Events.Disconnected += Events_Disconnected;
            btnSend.Enabled = false;
        }

        private void Events_Connected(object? sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                tbInfo.Text += $"*** Server [{e.IpPort}] Connected.{Environment.NewLine}";
            });
        }

        private void Events_DataReceived(object? sender, DataReceivedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                tbInfo.Text += $"*** Server: [{e.IpPort}] {Encoding.UTF8.GetString(e.Data.Array, 0, e.Data.Count)}{Environment.NewLine}";
            });
        }

        private void Events_Disconnected(object? sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                tbInfo.Text += $"*** Server [{e.IpPort}] Disconnected.{Environment.NewLine}";
            });
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                tcpClient.Connect();
                btnSend.Enabled = true;
                btnConnect.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (tcpClient.IsConnected)
            {
                if (!string.IsNullOrEmpty(tbMessage.Text))
                {
                    tcpClient.Send(tbMessage.Text);
                    tbInfo.Text += $"Me: {tbMessage.Text}{Environment.NewLine}";
                    tbMessage.Text = string.Empty;
                    //tbMessage.Text = 
                }
            }
        }
    }
}