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
        public static int freq;

        private static string comCurtainOn1 = "18 00 f1 80 11 53 a5 06 FE 82 0D 02 b4 a1 00 00 00 00 00 00 08 00 00 00";
        private static string comCurtainOn2 = "18 00 f1 80 11 53 a5 06 FE 82 0D 02 05 3c 00 00 00 00 00 00 08 00 00 00";
        private static string comCurtainOff1 = "18 00 f1 80 11 53 a5 06 FE 82 0D 02 b4 a1 00 00 00 00 00 00 08 00 00 01";
        private static string comCurtainOff2 = "18 00 f1 80 11 53 a5 06 FE 82 0D 02 05 3c 00 00 00 00 00 00 08 00 00 01";
        private static string comLightOn = "18 00 f1 80 11 53 a5 06 FE 82 0D 02 c6 89 00 00 00 00 00 00 08 00 00 01";
        private static string comLightOff = "18 00 f1 80 11 53 a5 06 FE 82 0D 02 c6 89 00 00 00 00 00 00 08 00 00 00";

        public string ip;
        public int port;

        private String command_query = "08 03 00 2a 00 01 a5 5b";

        public Socket socketServer;

        public bool socketServerCreate()
        {
            try
            {
                socketServer = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPEndPoint point = new IPEndPoint(IPAddress.Parse(ip), port);
                socketServer.Connect(point);
                comCurtainOn1.Replace(" ", "");
                comCurtainOn2.Replace(" ", "");
                comCurtainOff1.Replace(" ", "");
                comCurtainOff2.Replace(" ", "");
                comLightOn.Replace(" ", "");
                comLightOff.Replace(" ", "");
                command_query.Replace(" ", "");
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void ctr(string command)
        {
            byte[] sendBytes = Encoding.ASCII.GetBytes(command);
            socketServer.Send(sendBytes);
        }

        public void ctrl(string check)
        {
            switch (check)
            {
                case "LightOn":
                    ctr(comLightOn);
                    break;
                case "LightOff":
                    ctr(comLightOff);
                    break;
                case "CurtainOn":
                    ctr(comCurtainOn1);
                    ctr(comCurtainOn2);
                    break;
                case "CurtainOff":
                    ctr(comCurtainOff1);
                    ctr(comCurtainOff2);
                    break;
                default:
                    break;
            }
        }
 
        public String msgReceive()
        {
            string recStr = "";
            byte[] recBytes = new byte[24];
            //To do 数组清零
            int bytes = socketServer.Receive(recBytes, recBytes.Length, 0);
            recStr += Encoding.ASCII.GetString(recBytes, 0, bytes);
            Console.WriteLine(recStr);
            return recStr;
        }

        public void socketServerClose()
        {
            socketServer.Close();
        }
        //System.Convert.ToInt32(十六进制,十进制);十六进制转十进制

        public void thStart()
        {
            Thread backrun = new Thread(new ThreadStart(getLight));
            backrun.Start();
        }
        public void getLight()
        {
            String result = "";

            while (true)
            {
                ctr(command_query);
                result = msgReceive();
                light = (result[3] << 8) | (result[4] & 0x00ff);
                Thread.Sleep(freq);
            }
        }

    }
}