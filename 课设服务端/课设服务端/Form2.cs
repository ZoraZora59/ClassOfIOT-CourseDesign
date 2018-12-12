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
    public partial class control : Form
    {

        public control()
        {
            InitializeComponent();
        }
        transducerServer ts;
        private void control_FormClosed(object sender, FormClosedEventArgs e)
        {
            ts.socketServerClose();
            System.Environment.Exit(0);
        }

        private void buttonOn_Click(object sender, EventArgs e)
        {
            ts.ctrlLightOn();
        }
        private void control_Load(object sender, EventArgs e)
        {
            ts = new transducerServer();
            ts.socketServerCreate();
        }

        private void buttonOff_Click(object sender, EventArgs e)
        {
            ts.ctrlLightOff();
        }
    }
}
