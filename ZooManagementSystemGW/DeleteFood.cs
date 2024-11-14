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
    public partial class DeleteFood : Form
    {
        public DeleteFood()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Food f = new Food(txtID.Text);
            f.DeleteFood();
        }
    }
}
