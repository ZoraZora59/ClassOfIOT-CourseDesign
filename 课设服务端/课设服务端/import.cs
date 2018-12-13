using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;


namespace 课设服务端
{
    class transducerServer
    {
        public static int light;
        public static int lightCheck;
        public static int freq;
        public static string curtainIp;
        public static int curtainPort;
        public static string transIp;
        public static int transPort;

        private static byte[] comCurtainOn1 ={0x18,0x00,0xf1,0x80,0x11,0x53,0xa5,0x06,0xFE,0x82,0x0D,0x02,0xb4,0xa1,0x00,0x00,0x00,0x00,0x00,0x00,0x08,0x00,0x00,0x00};
        private static byte[] comCurtainOn2 = {0x18,0x00,0xf1,0x80,0x11,0x53,0xa5,0x06,0xFE,0x82,0x0D,0x02,0x05,0x3c,0x00,0x00,0x00,0x00,0x00,0x00,0x08,0x00,0x00,0x00};
        private static byte[] comCurtainOff1 = {0x18,0x00,0xf1,0x80,0x11,0x53,0xa5,0x06,0xFE,0x82,0x0D,0x02,0xb4,0xa1,0x00,0x00,0x00,0x00,0x00,0x00,0x08,0x00,0x00,0x01};
        private static byte[] comCurtainOff2 = {0x18,0x00,0xf1,0x80,0x11,0x53,0xa5,0x06,0xFE,0x82,0x0D,0x02,0x05,0x3c,0x00,0x00,0x00,0x00,0x00,0x00,0x08,0x00,0x00,0x01};
        private static byte[] comLightOn = {0x18,0x00,0xf1,0x80,0x11,0x53,0xa5,0x06,0xFE,0x82,0x0D,0x02,0xc6,0x89,0x00,0x00,0x00,0x00,0x00,0x00,0x08,0x00,0x00,0x01};
        private static byte[] comLightOff = {0x18,0x00,0xf1,0x80,0x11,0x53,0xa5,0x06,0xFE,0x82,0x0D,0x02,0xc6,0x89,0x00,0x00,0x00,0x00,0x00,0x00,0x08,0x00,0x00,0x00};

        private byte[] command_query = { 0x08, 0x03, 0x00, 0x2a, 0x00, 0x01, 0xa5, 0x5b };

        public static Socket socketCur;

        public static Socket socketTra;

        public bool socketCurtainCreate()
        {
            socketCur = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint point = new IPEndPoint(IPAddress.Parse(curtainIp), curtainPort);
            socketCur.Connect(point);
            return true;
        }
        public bool socketTransCreate()
        {
            socketTra  = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint point = new IPEndPoint(IPAddress.Parse(transIp), transPort);
            socketTra.Connect(point);
            return true;
        }
        private void ctr(byte[] command,Socket sk)
        {

            byte[] sendBytes = command;
            try
            {
                sk.Send(sendBytes);
            }
            catch(ObjectDisposedException)
            {
                MessageBox.Show("连接断开");
                
            }
                

        }

        public void ctrl(string check)
        {
            switch (check)
            {
                /*case "LightOn":
                    ctr(comLightOn,);
                    break;
                case "LightOff":
                    ctr(comLightOff);
                    break;*/
                case "CurtainOn":
                    ctr(comCurtainOn1,socketCur);
                    ctr(comCurtainOn2,socketCur);
                    break;
                case "CurtainOff":
                    ctr(comCurtainOff1,socketCur);
                    ctr(comCurtainOff2,socketCur);
                    break;
                default:
                    break;
            }
        }
 
        public String msgReceive(Socket sk)
        {
            string recStr = "";
            byte[] recBytes = new byte[24];
            //foreach recBytes[] = 0;
            int bytes = sk.Receive(recBytes, recBytes.Length, 0);
            recStr += Encoding.ASCII.GetString(recBytes, 0, bytes);
            Console.WriteLine(recStr);
            return recStr;
        }

        public void socketServerClose()
        {
            socketTra.Close();
            socketCur.Close();
            System.Console.WriteLine("socket已全部关闭");
        }
        //System.Convert.ToInt32(十六进制,十进制);十六进制转十进制

        public void thStart()
        {
            Thread backrun = new Thread(new ThreadStart(getLight));
            backrun.Start();
            backrun.IsBackground=true;
            System.Console.WriteLine("后台光纤传感器线程已创建");
        }
        public void getLight()
        {
            String result = "";

            while (true)
            {
                ctr(command_query,socketTra);
                System.Console.WriteLine("Message Send");
                result = msgReceive(socketTra);
                light = (result[3] << 8) | (result[4] & 0x00ff);
                System.Console.WriteLine("getLight=" + light);
                Thread.Sleep(freq);
            }
        }

    }
}