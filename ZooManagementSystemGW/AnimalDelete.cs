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
    public partial class AnimalDelete : Form
    {
        public AnimalDelete()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Animal a = new Animal(txtId.Text);
            a.DeleteAnimal();
        }
    }
}
