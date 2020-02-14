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
        private TcpClient _tcpClient;
        private int UserHp;
        private int UserMp;
        public Form1()
        {
            InitializeComponent();
        }

        public void ConnectToServer()
        {
            IPAddress ip = IPAddress.Parse("172.20.10.4");
            IPEndPoint ipe = new IPEndPoint(ip, 1111);
            TcpClient tcpClient = new TcpClient();

            try
            {
                tcpClient.Connect(ipe);
                if (tcpClient.Connected)
                {
                    MessageBox.Show("連線成功");
                    CommunicationBase cb = new CommunicationBase();
                    cb.SendData("測試訊息", tcpClient);
                    MessageBox.Show(cb.ReceiveData(tcpClient));
                }
                else
                {
                    Console.WriteLine("連線失敗");
                }
            }
            catch (Exception e)
            {
                tcpClient.Close();
                Console.WriteLine(e.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            attack1();
        }

        private void attack1()
        {
            if (_tcpClient.Connected)
            {
                CommunicationBase cb = new CommunicationBase();
                Random random = new Random();
                int attHp = random.Next(100);
                if (attHp > 0)
                {
                    cb.Attack(attHp, _tcpClient);
                }
                else
                {
                    MessageBox.Show("無效攻擊!!");
                }

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IPAddress ip = IPAddress.Parse("192.168.0.143");
            IPEndPoint ipe = new IPEndPoint(ip, 1111);
            UserHp = 500;
            UserMp = 200;
            _tcpClient = new TcpClient();
            try
            {
                _tcpClient.Connect(ipe);
                if (!_tcpClient.Connected)
                {
                    MessageBox.Show("連接失敗");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
