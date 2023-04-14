using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using TcpClientC.Net.IO;

namespace TcpClientC.Net
{
    internal class Server
    {
        TcpClient _tcpClient;
        public PacketReader PacketReader;

        public event Action connectedEvent;
        public event Action messageRecivedEvent;
        public event Action userDisconnectEvent;
        public Server()
        {
            _tcpClient = new TcpClient();
        }
        public void ConnectToServer(string username)
        {
            if (!_tcpClient.Connected)
            {
                _tcpClient.Connect("127.0.0.1", 7891);
                PacketReader = new PacketReader(_tcpClient.GetStream());

                if (!string.IsNullOrEmpty(username))
                {
                    var connectPacket = new PacketBuilder();
                    connectPacket.WriteOpCode(0);
                    connectPacket.WriteMessage(username);
                    _tcpClient.Client.Send(connectPacket.GetPacketBytes());
                }
                ReadPacket();
            }
        }

        private void ReadPacket()
        {
            Task.Run(() =>
            {
                while (true)
                {
                    var opcode = PacketReader.ReadByte();
                    switch (opcode)
                    {
                        case 1:
                            connectedEvent?.Invoke();
                            break;
                        case 5:
                            messageRecivedEvent?.Invoke();
                            break;
                        case 10:
                            userDisconnectEvent?.Invoke();
                            break;

                        default:
                            Console.WriteLine("Ooook...");
                            break;
                    }
                }
            });
        }

        public void SendMessageToServer(string  message)
        {
            var messagePacket = new PacketBuilder();
            messagePacket.WriteOpCode(5);
            messagePacket.WriteMessage(message);
            _tcpClient.Client.Send(messagePacket.GetPacketBytes());
        }
    }
}
