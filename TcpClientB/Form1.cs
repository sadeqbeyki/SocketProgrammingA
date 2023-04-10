using SuperSimpleTcp;
using System.Text;

namespace TcpClientB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SimpleTcpClient tcpClient;

        private void Form1_Load(object sender, EventArgs e)
        {
            tcpClient = new(tbIP.Text);
            tcpClient.Events.Connected += Events_Connected;
            tcpClient.Events.DataReceived += Events_DataReceived;
            tcpClient.Events.Disconnected += Events_Disconnected;
            btnSend.Enabled = false;
        }

        private void Events_DataReceived(object? sender, DataReceivedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                tbInfo.Text += $"Server: {Encoding.UTF8.GetString(e.Data)}{Environment.NewLine}";
            });
        }

        private void Events_Disconnected(object? sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                tbInfo.Text += $"Server Disconnected.{Environment.NewLine}";
            });
        }

        private void Events_Connected(object? sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                tbInfo.Text += $"Server Connected.{Environment.NewLine}";
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
                    tbMessage.Text += $"Me:{tbMessage.Text}{Environment.NewLine}";
                    tbMessage.Text = string.Empty;
                }
            }
        }
    }
}