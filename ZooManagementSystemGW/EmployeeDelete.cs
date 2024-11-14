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
    public partial class EmployeeDelete : Form
    {
        public EmployeeDelete()
        {
            InitializeComponent();
            egroup.Hide();
            ugroup.Hide();
            pgroup.Hide();
            igroup.Hide();
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            egroup.Show();
            egroup.Dock = DockStyle.Top;
            ugroup.Hide();
            pgroup.Hide();
            igroup.Hide();
            btnE.ForeColor = Color.Yellow;
            btnU.ForeColor = Color.White;
            btnP.ForeColor = Color.White;
            btnI.ForeColor = Color.White;
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            pgroup.Show();
            pgroup.Dock = DockStyle.Top;
            ugroup.Hide();
            egroup.Hide();
            igroup.Hide();
            btnE.ForeColor = Color.White;
            btnU.ForeColor = Color.White;
            btnP.ForeColor = Color.Yellow;
            btnI.ForeColor = Color.White;
        }

        private void btnU_Click(object sender, EventArgs e)
        {
            ugroup.Show();
            ugroup.Dock = DockStyle.Top;
            egroup.Hide();
            pgroup.Hide();
            igroup.Hide();
            btnE.ForeColor = Color.White;
            btnU.ForeColor = Color.Yellow;
            btnP.ForeColor = Color.White;
            btnI.ForeColor = Color.White;
        }

        private void btnI_Click(object sender, EventArgs e)
        {
            igroup.Show();
            igroup.Dock = DockStyle.Top;
            egroup.Hide();
            pgroup.Hide();
            ugroup.Hide();
            btnE.ForeColor = Color.White;
            btnU.ForeColor = Color.White;
            btnP.ForeColor = Color.White;
            btnI.ForeColor = Color.Yellow;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "" || txtEm.Text != "" || txtPn.Text != "" || txtU.Text != "")
            {
                int choice = 0;
                if (btnI.ForeColor == Color.Yellow) choice = 1;
                else if (btnE.ForeColor == Color.Yellow) choice = 2;
                else if (btnP.ForeColor == Color.Yellow) choice = 3;
                else if (btnU.ForeColor == Color.Yellow) choice = 4;
                else MessageBox.Show("Choose a way to Delete!!");

                Employee em = new Employee();
                if (choice == 1)
                    em.DeleteEmployee(txtId.Text, choice);
                else if (choice == 2)
                    em.DeleteEmployee(txtEm.Text, choice);
                else if (choice == 3)
                    em.DeleteEmployee(txtPn.Text, choice);
                else if (choice == 4)
                    em.DeleteEmployee(txtU.Text, choice);

                txtId.Clear();
                txtEm.Clear();
                txtPn.Clear();
                txtU.Clear();
            }
            else MessageBox.Show("TextBox can not be empity!!");
        }
    }
}
