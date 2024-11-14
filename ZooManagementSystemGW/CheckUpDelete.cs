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
    public partial class CheckUpDelete : Form
    {
        public CheckUpDelete()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            CheckUp c = new CheckUp(txtId.Text);
            c.deleteCheckUp();
        }
    }
}
