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
    public partial class FoodInsert : Form
    {
        public string username;
        public FoodInsert()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Food f = new Food(txtFn.Text, txtA.Text, txtFpd.Text, username);
            f.addFood();
        }
    }
}
