using System;
using System.Collections;
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
        private TcpListener listener;
        private TcpClient tcpClient;
        private Thread ClThread;
        private Hashtable HT = new Hashtable();
        private List<Monster> monsters = new List<Monster>();
        public Form1()
        {
            InitializeComponent();
        }

        public void ConnectionListener()
        {
            try
            {
                IPEndPoint ipe = new IPEndPoint(IPAddress.Parse("192.168.0.24"), 1111);
                listener = new TcpListener(ipe);
                listener.Start();
                while (true)
                {
                    if (listener.Pending())
                    {
                        tcpClient = listener.AcceptTcpClient();
                        if (!HT.Contains(tcpClient))
                        {
                            HT.Add(tcpClient, monsters[new Random().Next(4)]);
                        }
                        ClThread = new Thread(ListenClient);
                        ClThread.IsBackground = true;
                        ClThread.Start();
                    }
                    
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
        }

        private void ListenClient()
        {
            TcpClient client = tcpClient;
            Thread thread = ClThread;
            while (true)
            {
                try
                {
                    CommunicationBase cb = new CommunicationBase();
                    string data = cb.ReceiveData(client);
                    string cmd = data.Substring(0, 1);
                    int attHp = 0;
                    Monster monster = (Monster)HT[client];
                    switch (cmd)
                    {
                        case "1":
                            attHp = int.Parse(data.Substring(1));
                            monster.BeAttacked(attHp);
                            break;
                        case "9":
                            HT.Remove(client);
                            thread.Abort();
                            break;
                    }
                    //MessageBox.Show(monster.HP.ToString());
                    string msg = monster.HP.ToString() + "," + new Random().Next(50).ToString();
                    cb.SendData(msg, client);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    throw;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread mainThread = new Thread(ConnectionListener);
            mainThread.IsBackground = true;
            mainThread.Start();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            monsters.Add(new Monster("怪物1", 1000, 200));
            monsters.Add(new Monster("怪物2", 1500, 200));
            monsters.Add(new Monster("怪物3", 2500, 200));
            monsters.Add(new Monster("怪物4", 3500, 200));
        }
    }
}
