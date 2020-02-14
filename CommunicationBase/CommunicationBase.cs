using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;


namespace TcpIpDemo
{
    public class CommunicationBase
    {
        //傳送資料
        public void SendData(string data,TcpClient tcpClient)
        {
            NetworkStream stream = tcpClient.GetStream();
            if (stream.CanWrite)
            {
                byte[] byteData = Encoding.Default.GetBytes(data);
                stream.Write(byteData, 0, byteData.Length);
            }
        }

        //接收資料
        public string ReceiveData(TcpClient tcpClient)
        {
            string rtnString = "";
            byte[] receiveBytes = new byte[tcpClient.ReceiveBufferSize];
            int bRead = 0;
            NetworkStream stream = tcpClient.GetStream();

            if (stream.CanRead)
            {
                do
                {
                    bRead = stream.Read(receiveBytes, 0, tcpClient.ReceiveBufferSize);
                    rtnString = Encoding.Default.GetString(receiveBytes, 0, bRead);
                } while (stream.DataAvailable);
            }
            return rtnString;
        }



        public void Attack(int attackHp,TcpClient tcpClient)
        {
            NetworkStream stream = tcpClient.GetStream();
            if (stream.CanWrite)
            {
                byte[] byteData = BitConverter.GetBytes(attackHp);
                stream.Write(byteData, 0, byteData.Length);
            }
        }

        public int Receive(TcpClient tcpClient)
        {
            int attHp = 0;
            byte[] receiveBytes = new byte[tcpClient.ReceiveBufferSize];
            int bRead = 0;
            NetworkStream stream = tcpClient.GetStream();

            if (stream.CanRead)
            {
                do
                {
                    bRead = stream.Read(receiveBytes, 0, tcpClient.ReceiveBufferSize);
                    attHp = BitConverter.ToInt32(receiveBytes, 0);
                } while (stream.DataAvailable);
            }
            return attHp;
        }
    }
}
