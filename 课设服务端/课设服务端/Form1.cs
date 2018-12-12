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
        public main()
        {
            InitializeComponent();
        }

        private void buttonSet_Click(object sender, EventArgs e)
        {
            if (this.textIP.Text.Length > 15)
                MessageBox.Show("IP地址异常");
            else
            {
                transducerServer ts = new transducerServer();
                ts.ip=this.textIP.Text;//IP
                var temp = this.textFreq.Text;
                int numTemp;
                int.TryParse(temp, out numTemp);
                ts.freq=numTemp;//频率
                temp = this.textPort.Text;
                int.TryParse(temp, out numTemp);
                ts.port=numTemp;//端口
                temp = this.textLight.Text;
                int.TryParse(temp, out numTemp);
                ts.light=numTemp;//亮度值 
                MessageBox.Show("设定成功！");
                control form2 = new control();
                this.Hide();
                form2.ShowDialog();
            }
        }
    }
}
