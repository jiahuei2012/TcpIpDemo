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
        private CommunicationBase _cb = new CommunicationBase();
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

        private void btn1_Click(object sender, EventArgs e)
        {
            if (_tcpClient.Connected)
            {
                Random random = new Random();
                int attHp = random.Next(100);
                if (attHp > 0)
                {
                    _cb.SendData("1" + attHp, _tcpClient);
                    tbContent.Text += "使用「普通攻擊」傷害了 " + attHp + "Hp \r\n";
                    string[] datas = _cb.ReceiveData(_tcpClient).Split(',');
                    int loseHp = int.Parse(datas[1]);
                    tbContent.Text += "遭受「反擊」受到傷害 " + loseHp + "Hp \r\n";
                    UserHp -= loseHp;
                    labHP.Text = UserHp.ToString();
                    labMHP.Text = datas[0].ToString();
                }
                else
                {
                    MessageBox.Show("無效攻擊!!");
                }

            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            IPAddress ip = IPAddress.Parse("192.168.0.24");
            IPEndPoint ipe = new IPEndPoint(ip, 1111);
            UserHp = 500;
            UserMp = 200;
            labHP.Text = UserHp.ToString();
            labMP.Text = UserMp.ToString();
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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _cb.SendData("9", _tcpClient);
            _tcpClient.Close();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (_tcpClient.Connected)
            {
                Random random = new Random();
                int attHp = random.Next(100,300);

                _cb.SendData("1" + attHp, _tcpClient);
                tbContent.Text += "使用「強力攻擊」傷害了 " + attHp + "Hp \r\n"　+
                                  "但是自我損傷 20 HP";
                UserHp -= 20;
                int loseHp = int.Parse(_cb.ReceiveData(_tcpClient));
                tbContent.Text += "遭受「反擊」受到傷害 " + loseHp + "Hp \r\n";
                UserHp -= loseHp;
                labHP.Text = UserHp.ToString();
            }
        }
    }
}
