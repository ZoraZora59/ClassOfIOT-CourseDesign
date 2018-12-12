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
        transducerServer ts;

        public main()
        {
            InitializeComponent();
        }

        private void buttonSet_Click(object sender, EventArgs e)
        {
            if (this.textCurtainIP.Text.Length > 15)
                MessageBox.Show("IP地址异常");
            else
            {
                createSocket();
            }
        }
        public void createSocket()
        {
            ts = new transducerServer();
            ts.ip = this.textCurtainIP.Text;//IP
            var temp = this.textFreq.Text;
            int numTemp;
            int.TryParse(temp, out numTemp);
            transducerServer.freq = numTemp;//频率
            temp = this.textCurtainPort.Text;
            int.TryParse(temp, out numTemp);
            ts.port = numTemp;//端口
            temp = this.textLight.Text;
            int.TryParse(temp, out numTemp);
            transducerServer.light = numTemp;//亮度值 
            MessageBox.Show("设定成功！");
            control form2 = new control();
            this.Hide();
            form2.ShowDialog();
        }

        private void main_Load(object sender, EventArgs e)
        {
            textFreq.Text = "暂不可用";
            textCurtainIP.Text = "192.168.0.66";
            textCurtainPort.Text = "8124";
        }
    }
}
