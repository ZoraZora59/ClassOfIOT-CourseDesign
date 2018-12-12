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

        private void control_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void buttonOn_Click(object sender, EventArgs e)
        {
            transducerServer ts = new transducerServer();
            System.Console.WriteLine(transducerServer.ip);
        }

        private void control_Load(object sender, EventArgs e)
        {
        }
    }
}
