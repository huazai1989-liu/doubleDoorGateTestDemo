using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using nsGateXml;

namespace gateExeDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox_port.Text = "6000";
            comboBox_first.Items.Add("0:正常");
            comboBox_first.Items.Add("1:常开");
            comboBox_first.Items.Add("2:常闭");
            comboBox_first.SelectedIndex = 0;
            comboBox_second.Items.Add("0:正常");
            comboBox_second.Items.Add("1:常开");
            comboBox_second.Items.Add("2:常闭");
            comboBox_second.SelectedIndex = 0;
            comboBox_openDoor.Items.Add("第一道门正向开门");
            comboBox_openDoor.Items.Add("第一道门反向开门");
            comboBox_openDoor.Items.Add("第二道门正向开门");
            comboBox_openDoor.Items.Add("第二道门反向开门");
            comboBox_openDoor.SelectedIndex = 0;
            button1.Enabled = true;
            button2.Enabled = true;
        }
        private Socket clientSocket = null;
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;


            try
            {
                int port = int.Parse(textBox_port.Text);
                string host = "127.0.0.1";//服务器端ip地址
                IPAddress ip = IPAddress.Parse(host);
                IPEndPoint ipe = new IPEndPoint(ip, port);
                clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                clientSocket.Connect(ipe);

                if(bgWorker!=null)
                {
                    bgWorker.CancelAsync();
                    bgWorker.Dispose();
                }
                bgWorker = new BackgroundWorker();
                bgWorker.WorkerReportsProgress = true;
                bgWorker.WorkerSupportsCancellation = true;
                bgWorker.DoWork += BgWorker_DoWork;
                bgWorker.ProgressChanged += BgWorker_ProgressChanged;

                bgWorker.RunWorkerAsync();
            }
            catch(Exception)
            {

            }

        }



        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            try
            {
                clientSocket.Close();
            }
            catch (Exception) { }
            
        }

       
        private void button3_Click(object sender, EventArgs e)
        {
            string sendStr = gateXml.gateCmdInit();

            if (sendStr != null)
            {
                textBox_ret.Text += sendStr;
                textBox_ret.Text += "\r\n";
                byte[] sendBytes = Encoding.ASCII.GetBytes(sendStr);
                clientSocket.Send(sendBytes);
            }
        }

        private BackgroundWorker bgWorker = null;
        private void BgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            //throw new NotImplementedException();
            BackgroundWorker bw = (BackgroundWorker)sender;
            string recStr = "";
            byte[] recByte = new byte[1024*1024];
            int bytes = 0;

            while (true)
            {
                if (bw.CancellationPending) {
                    break;
                }
                try
                {
                    bytes = clientSocket.Receive(recByte, recByte.Length, 0);
                    recStr = Encoding.ASCII.GetString(recByte, 0, bytes);
                    if (recStr.Length > 0)
                    {
                        bw.ReportProgress(0, recStr);
                    }
                    else
                    {
                        clientSocket.Close();
                    }
                }
                catch (Exception)
                {
                    break;
                }

            }
        }

        private void BgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //throw new NotImplementedException();
            string buf = (string)e.UserState;

            textBox_ret.Text += buf;
            textBox_ret.Text += "\r\n";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string first = textBox_first.Text;
            string second = textBox_second.Text;
            string timeout = textBox_timeout.Text;

            int f = -1;
            int s = -1;
            int t = -1;
            if (first.Length>0)
            {
                f = int.Parse(first);
            }
            if (second.Length > 0)
            {
                s = int.Parse(second);
            }
            if (timeout.Length > 0)
            {
                t = int.Parse(timeout);
            }

            string sendStr = gateXml.gateCmdSetEp(f,s,t);
            if (sendStr != null)
            {
                textBox_ret.Text += sendStr;
                textBox_ret.Text += "\r\n";
                byte[] sendBytes = Encoding.ASCII.GetBytes(sendStr);
                clientSocket.Send(sendBytes);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int f = 0;
            int s = 0;

            switch(comboBox_first.SelectedItem.ToString())
            {
                case "0:正常":
                    f = 0;
                    break;
                case "1:常开":
                    f = 1;
                    break;
                case "2:常闭":
                    f = 2;
                    break;
                default:
                    break;
            }
            switch (comboBox_second.SelectedItem.ToString())
            {
                case "0:正常":
                    s = 0;
                    break;
                case "1:常开":
                    s = 1;
                    break;
                case "2:常闭":
                    s = 2;
                    break;
                default:
                    break;
            }

            string sendStr = gateXml.gateCmdSetDoorTyep(f,s);
            if (sendStr != null)
            {
                textBox_ret.Text += sendStr;
                textBox_ret.Text += "\r\n";
                byte[] sendBytes = Encoding.ASCII.GetBytes(sendStr);
                clientSocket.Send(sendBytes);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int handle = 0;
            int direction = 0;
            switch (comboBox_openDoor.SelectedItem.ToString())
            {
                case "第一道门正向开门":
                    handle = 1;
                    direction = 1;
                    break;
                case "第一道门反向开门":
                    handle = 1;
                    direction = 0;
                    break;
                case "第二道门正向开门":
                    handle = 2;
                    direction = 1;
                    break;
                case "第二道门反向开门":
                    handle = 2;
                    direction = 0;
                    break;
                default:
                    break;
            }

            string sendStr = gateXml.gateCmdOpenDoor(handle, direction);
            if (sendStr != null)
            {
                textBox_ret.Text += sendStr;
                textBox_ret.Text += "\r\n";
                byte[] sendBytes = Encoding.ASCII.GetBytes(sendStr);
                clientSocket.Send(sendBytes);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string sendStr = gateXml.gateCmdStatus();

            if (sendStr != null)
            {
                textBox_ret.Text += sendStr;
                textBox_ret.Text += "\r\n";
                byte[] sendBytes = Encoding.ASCII.GetBytes(sendStr);
                clientSocket.Send(sendBytes);
            }
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox_ret.Text = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string sendStr = gateXml.gateCmdAlarm();

            if (sendStr != null)
            {
                textBox_ret.Text += sendStr;
                textBox_ret.Text += "\r\n";
                byte[] sendBytes = Encoding.ASCII.GetBytes(sendStr);
                clientSocket.Send(sendBytes);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string sendStr = gateXml.gateCmdDiscon();

            if (sendStr != null)
            {
                textBox_ret.Text += sendStr;
                textBox_ret.Text += "\r\n";
                byte[] sendBytes = Encoding.ASCII.GetBytes(sendStr);
                clientSocket.Send(sendBytes);
            }
        }
    }
}
