using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TcpIpDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void ConnectionListener()
        {
            TcpListener listener = null;
            try
            {
                IPEndPoint ipe = new IPEndPoint(IPAddress.Parse("192.168.0.143"), 1111);
                listener = new TcpListener(ipe);
                listener.Start();
                Monster monster = new Monster("怪物1", 1000, 200);
                
                while (true)
                {
                    TcpClient tcpClient = listener.AcceptTcpClient();

                    HandlerClient handler = new HandlerClient(tcpClient);
                    handler.Communicate(monster);
                    MessageBox.Show(monster.HP.ToString());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                listener.Stop();
            }

            /*

            //IPAddress[] ipa = Dns.GetHostAddresses(Dns.GetHostName());
            IPEndPoint ipe = new IPEndPoint(IPAddress.Parse("192.168.0.143"), 1111);
            TcpListener listener = new TcpListener(ipe);

            listener.Start();
            //MessageBox.Show("等待連線...");

            TcpClient tcpClient;
            int clients = 0;
            bool Isgameover = false;
            tcpClient = listener.AcceptTcpClient();
            while (true)
            {
                try
                {
  
                    if (tcpClient.Connected)
                    {
                        MessageBox.Show("連線成功");
                        Monster monster = new Monster("怪物1", 1000, 200);
                        HandlerClient handler = new HandlerClient(tcpClient);

                        handler.Communicate(monster);
                        
                        Thread thread = new Thread(() => handler.Communicate(monster));
                        clients++;
                        thread.IsBackground = true;
                        thread.Start();
                        thread.Join();
                        
                        MessageBox.Show(monster.HP.ToString());
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Thread thread = new Thread(ConnectionListener);
            //thread.Start();
            ConnectionListener();
        }
    }
}
