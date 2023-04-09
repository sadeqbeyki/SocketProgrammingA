using System.Net;
using System.Net.Sockets;
using System.Text;

namespace TcpClientA
{
    public partial class Form1 : Form
    {
        TcpClient mTcpClient;
        byte[] mRx;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            IPAddress iPAddress;
            int nPort;
            try
            {
                if (string.IsNullOrEmpty(tbServerIp.Text) || string.IsNullOrEmpty(tbServerPort.Text))
                    return;

                if (!IPAddress.TryParse(tbServerIp.Text, out iPAddress))
                {
                    MessageBox.Show("Please Supply an IP Address.");
                    return;
                }
                if (!int.TryParse(tbServerPort.Text, out nPort))
                {
                    nPort = 23000;
                }

                mTcpClient = new TcpClient();
                mTcpClient.BeginConnect(iPAddress, nPort, onCompleteConnect, mTcpClient);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void onCompleteConnect(IAsyncResult ar)
        {
            TcpClient udpc;
            try
            {
                udpc = (TcpClient)ar.AsyncState;
                udpc.EndConnect(ar);

                mRx = new byte[512];
                udpc.GetStream().BeginRead(mRx, 0, mRx.Length, onCompleteReadFromServerStream, udpc);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void onCompleteReadFromServerStream(IAsyncResult ar)
        {
            TcpClient udpc;
            int nCountByteRecivedFromServer;
            string strRecived;
            try
            {
                udpc = (TcpClient)ar.AsyncState;
                nCountByteRecivedFromServer = udpc.GetStream().EndRead(ar);
                if (nCountByteRecivedFromServer == 0)
                {
                    MessageBox.Show("Connection broken!");
                    return;
                }
                strRecived = Encoding.ASCII.GetString(mRx, 0, nCountByteRecivedFromServer);
                PrintLine(strRecived);
                mRx = new byte[512];
                udpc.GetStream().BeginRead(mRx, 0, mRx.Length, onCompleteReadFromServerStream, udpc);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            byte[] tx;
            if (string.IsNullOrEmpty(tbServerIp.Text))
                return;

            try
            {
                tx = Encoding.ASCII.GetBytes(tbPayload.Text);
                if (mTcpClient != null)
                {
                    if (mTcpClient.Client.Connected)
                    {
                        mTcpClient.GetStream().BeginWrite(tx, 0, tx.Length, onCompleteWriteToServer, mTcpClient);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void onCompleteWriteToServer(IAsyncResult ar)
        {
            TcpClient udpc;
            try
            {
                udpc = (TcpClient)ar.AsyncState;
                udpc.GetStream().EndWrite(ar);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void PrintLine(string _strPrint)
        {
            tbConsole.Invoke(new Action<string>(DoInvoke), _strPrint);
        }

        public void DoInvoke(string _strPrint)
        {
            tbConsole.Text = _strPrint + Environment.NewLine + tbConsole.Text;
        }
    }
}