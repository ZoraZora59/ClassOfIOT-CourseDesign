using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 课设服务端
{

    public partial class main : Form
    {
        transducerServer trans;
        transducerServer curtain;
        public main()
        {
            InitializeComponent();
        }

        private void buttonSet_Click(object sender, EventArgs e)
        {
            trans = new transducerServer();
            curtain = new transducerServer();
            curtain.ip = this.textCurtainIP.Text;//IP
            trans.ip = this.textTranLightIP.Text;
            var temp = this.textFreq.Text;
            int numTemp;
            int.TryParse(temp, out numTemp);
            transducerServer.freq = numTemp;//频率
            temp = this.textCurtainPort.Text;
            int.TryParse(temp, out numTemp);
            curtain.port = numTemp;//端口
            temp = this.textTranLightPort.Text;
            int.TryParse(temp, out numTemp);
            trans.port = numTemp;
            temp = this.textLight.Text;
            int.TryParse(temp, out numTemp);
            transducerServer.light = numTemp;//亮度值 
            if (trans.socketServerCreate() && curtain.socketServerCreate())
            {
                createSocket();
            }
            else
            {
                MessageBox.Show("连接失败或数据异常");
            }
        }
        public void createSocket()
        {
            
            control form2 = new control();
            this.Hide();
            form2.ShowDialog();
        }

        private void main_Load(object sender, EventArgs e)
        {
            textFreq.Text = "5000";
            textCurtainIP.Text = "192.168.0.66";
            textCurtainPort.Text = "8124";
            textTranLightIP.Text = "192.168.0.";
            textTranLightPort.Text = "4001";
        }
    }
}
