using System.Net;
using System.Net.Sockets;
using System.Text;

namespace TcpServerA
{
    public partial class Form1 : Form
    {
        TcpListener mTcpListener;
        TcpClient mTcpClient;
        byte[] mRx;
        public Form1()
        {
            InitializeComponent();
        }

        IPAddress FindMyIpV4Address()
        {
            string strThisHostName = string.Empty;
            IPHostEntry thisHostDNSEntry = null;
            IPAddress[] AllIPsOfThisHost = null;
            IPAddress ipV4Ret = null;
            try
            {
                strThisHostName = Dns.GetHostName();
                PrintLine(strThisHostName);
                thisHostDNSEntry = Dns.GetHostEntry(strThisHostName);
                AllIPsOfThisHost = thisHostDNSEntry.AddressList;
                for (int idx = AllIPsOfThisHost.Length - 1; idx > 0; idx--)
                {
                    if (AllIPsOfThisHost[idx].AddressFamily == AddressFamily.InterNetwork)
                    {
                        if (AllIPsOfThisHost[idx].AddressFamily == AddressFamily.InterNetwork)
                        {
                            ipV4Ret = AllIPsOfThisHost[idx];
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ipV4Ret;
        }
        private void btnStartListening_Click(object sender, EventArgs e)
        {
            IPAddress iPAddress;
            int nPort;

            if (!int.TryParse(tbPort.Text, out nPort))
            {
                nPort = 23000;
            }

            if (!IPAddress.TryParse(tbIPAddress.Text, out iPAddress))
            {
                MessageBox.Show("Invalid IP address supplied.");
                return;
            }
            mTcpListener = new TcpListener(iPAddress, nPort);
            mTcpListener.Start();
            mTcpListener.BeginAcceptTcpClient(OnCompleteAcceptTcpClient, mTcpListener);
        }
        void OnCompleteAcceptTcpClient(IAsyncResult ar)
        {
            TcpListener tcpListener = (TcpListener)ar.AsyncState;
            try
            {
                mTcpClient = tcpListener.EndAcceptTcpClient(ar);

                PrintLine("Client Connected.");

                //accept multiple client in server
                tcpListener.BeginAcceptTcpClient(OnCompleteAcceptTcpClient, tcpListener);

                mRx = new byte[512];
                mTcpClient.GetStream().BeginRead(mRx, 0, mRx.Length, OnCompleteReadFromTcpClientStream, mTcpClient);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            void OnCompleteReadFromTcpClientStream(IAsyncResult ar)
            {
                TcpClient tcpClient;
                int nCountReadBytes = 0;
                string strRecv;
                try
                {
                    tcpClient = (TcpClient)ar.AsyncState;
                    nCountReadBytes = tcpClient.GetStream().EndRead(ar);
                    if (nCountReadBytes == 0)
                    {
                        MessageBox.Show("Client disconnected.");
                        return;
                    }
                    strRecv = Encoding.ASCII.GetString(mRx, 0, nCountReadBytes);
                    PrintLine(strRecv);
                    mRx = new byte[512];
                    tcpClient.GetStream().BeginRead(mRx, 0, mRx.Length, OnCompleteReadFromTcpClientStream, tcpClient);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void PrintLine(string _strPrint)
        {
            tbConsoleOutput.Invoke(new Action<string>(DoInvoke), _strPrint);
        }

        public void DoInvoke(string _strPrint)
        {
            tbConsoleOutput.Text = _strPrint + Environment.NewLine + tbConsoleOutput.Text;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            byte[] tx = new byte[512];
            if (string.IsNullOrEmpty(tbPayload.Text))
            {
                return;
            }
            try
            {
                if (mTcpClient != null)
                {
                    if (mTcpClient.Client.Connected)
                    {
                        tx = Encoding.ASCII.GetBytes(tbPayload.Text);
                        mTcpClient.GetStream().BeginWrite(tx, 0, tx.Length, OnCompleteWriteToClientStream, mTcpClient);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OnCompleteWriteToClientStream(IAsyncResult ar)
        {
            try
            {
                TcpClient tcpClient = (TcpClient)ar.AsyncState;
                tcpClient.GetStream().EndWrite(ar);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bntFindIpV4_Click(object sender, EventArgs e)
        {
            IPAddress iPAddress = null;
            iPAddress = FindMyIpV4Address();
            if (iPAddress != null)
            {
                tbIPAddress.Text = iPAddress.ToString();
            }
        }
    }
}