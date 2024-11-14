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
    public partial class EmployeeInsert : Form
    {

        public EmployeeInsert()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (txtP.Text == txtCp.Text)
            {
                Employee em = new Employee(txtFn.Text, txtLn.Text, cbxG.Text, txtEmail.Text, txtPhone.Text, txtUn.Text, txtP.Text, cbxR.Text);
                em.SaveEmployee();
                txtFn.Text = "";
                txtLn.Text = "";
                cbxG.Text = "";
                txtEmail.Text = "";
                txtPhone.Text = "";
                txtUn.Text = "";
                txtP.Text = "";
                txtCp.Text = "";
                cbxR.Text = "";
            }
            else
            {
                MessageBox.Show("Password and Confirm Passowrd are not the same!!");
                txtP.Text = "";
                txtCp.Text = "";
            }
        }
    }
}
