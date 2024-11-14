using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooManagementSystemGW
{
    public partial class Dashbord : Form
    {
        public Dashbord()
        {
            InitializeComponent();
        }

        private void circularProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void TBB_Scroll(object sender, EventArgs e)
        {
            cprogress.Value = TBB.Value * 10;
            cprogress.Text = (TBB.Value * 10).ToString() + "%";

        }
    }
}
