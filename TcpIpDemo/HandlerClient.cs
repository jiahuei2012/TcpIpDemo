using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TcpIpDemo
{
    class HandlerClient
    {
        private TcpClient _Client;

        public HandlerClient(TcpClient tcpClient)
        {
            _Client = tcpClient;
        }

        public void Communicate()
        {
            try
            {
                CommunicationBase CBase = new CommunicationBase();
                string msg = CBase.ReceiveData(_Client);
                Console.WriteLine("接收資料:" + msg);
                CBase.SendData("回送資料測試", _Client);
            }
            catch
            {
                Console.WriteLine("客戶關閉連線");
                _Client.Close();
            }

        }

        public void Communicate(Monster monster)
        {
            Thread thread = new Thread(() => doThing(monster));
            thread.Start();            
        }

        private void doThing(Monster monster)
        {
            while (true)
            {
                try
                {
                    CommunicationBase cb = new CommunicationBase();
                    int attHp = cb.Receive(_Client);
                    monster.BeAttacked(attHp);
                }
                catch
                {
                    _Client.Close();
                    Console.WriteLine("error");
                }
            }            
        }
    }
}
