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
    public partial class CheckUpInsert : Form
    {
        public string username;

        public CheckUpInsert()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            CheckUp c = new CheckUp(cbxTT.Text, cbxR.Text, txtAT.Text, txtM.Text,username);
            c.insertCheckUp();
        }
    }
}
