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
    public partial class EmployeeUpdate : Form
    {

        public int ch=0;

        public EmployeeUpdate()
        {
            InitializeComponent();
            pnl1.Hide();
            egroup.Hide();
            ugroup.Hide();
            pgroup.Hide();
            igroup.Hide();
        }

        private void EmployeeUpdate_Load(object sender, EventArgs e)
        {
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
            txtEmail.Enabled = false;
            e4.BackColor = Color.Red;
            e5.BackColor = Color.Snow;
            e6.BackColor = Color.Snow;
            pnl1.Show();
            txtFn.Enabled = false;
            txtFn.Enabled = true;
            txtLn.Enabled = false;
            txtLn.Enabled = true;
            txtPhone.Enabled = false;
            txtPhone.Enabled = true;
            txtUn.Enabled = false;
            txtUn.Enabled = true;
            txtP.Enabled = false;
            txtP.Enabled = true;
            txtCp.Enabled = false;
            txtCp.Enabled = true;
            ch = 2;
            tableView.Show();
        }

        private void btnP_Click_1(object sender, EventArgs e)
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
            txtPhone.Enabled = false;
            e4.BackColor = Color.Snow;
            e5.BackColor = Color.Red;
            e6.BackColor = Color.Snow;
            pnl1.Show();
            txtFn.Enabled = false;
            txtFn.Enabled = true;
            txtLn.Enabled = false;
            txtLn.Enabled = true;
            txtEmail.Enabled = false;
            txtEmail.Enabled = true;
            txtUn.Enabled = false;
            txtUn.Enabled = true;
            txtP.Enabled = false;
            txtP.Enabled = true;
            txtCp.Enabled = false;
            txtCp.Enabled = true;
            ch = 3;
            tableView.Show();
        }

        private void btnU_Click_1(object sender, EventArgs e)
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
            txtUn.Enabled = false;
            e4.BackColor = Color.Snow;
            e5.BackColor = Color.Snow;
            e6.BackColor = Color.Red;
            pnl1.Show();
            txtFn.Enabled = false;
            txtFn.Enabled = true;
            txtLn.Enabled = false;
            txtLn.Enabled = true;
            txtEmail.Enabled = false;
            txtEmail.Enabled = true;
            txtPhone.Enabled = false;
            txtPhone.Enabled = true;
            txtP.Enabled = false;
            txtP.Enabled = true;
            txtCp.Enabled = false;
            txtCp.Enabled = true;
            ch = 4;
            tableView.Show();
        }

        private void btnI_Click(object sender, EventArgs e)
        {
            igroup.Show();
            igroup.Dock = DockStyle.Top;
            ugroup.Hide();
            egroup.Hide();
            pgroup.Hide();
            btnE.ForeColor = Color.White;
            btnU.ForeColor = Color.White;
            btnP.ForeColor = Color.White;
            btnI.ForeColor = Color.Yellow;
            e4.BackColor = Color.Snow;
            e5.BackColor = Color.Snow;
            e6.BackColor = Color.Snow;
            pnl1.Show();
            txtFn.Enabled = false;
            txtFn.Enabled = true;
            txtLn.Enabled = false;
            txtLn.Enabled = true;
            txtEmail.Enabled = false;
            txtEmail.Enabled = true;
            txtPhone.Enabled = false;
            txtPhone.Enabled = true;
            txtUn.Enabled = false;
            txtUn.Enabled = true;
            txtP.Enabled = false;
            txtP.Enabled = true;
            txtCp.Enabled = false;
            txtCp.Enabled = true;
            ch = 1;
            tableView.Show();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (txtP == txtCp && txtId.Text != "" || txtEm.Text != "" || txtPn.Text != "" || txtU.Text != "")
            {
                int choice;
                if (txtEmail.Enabled == false) choice = 2;
                else if (txtPhone.Enabled == false) choice = 3;
                else if (txtUn.Enabled == false) choice = 4;
                else choice = 1;

                Employee em = new Employee();
                if (choice == 1)
                    em.UpdateEmployee(txtId.Text, txtFn.Text, txtLn.Text, cbxG.Text, txtEmail.Text, txtPhone.Text, txtUn.Text, txtP.Text, cbxR.Text, choice);
                else if (choice == 2)
                    em.UpdateEmployee(txtEm.Text, txtFn.Text, txtLn.Text, cbxG.Text, txtEmail.Text, txtPhone.Text, txtUn.Text, txtP.Text, cbxR.Text, choice);
                else if (choice == 3)
                    em.UpdateEmployee(txtPn.Text, txtFn.Text, txtLn.Text, cbxG.Text, txtEmail.Text, txtPhone.Text, txtUn.Text, txtP.Text, cbxR.Text, choice);
                else if (choice == 4)
                    em.UpdateEmployee(txtU.Text, txtFn.Text, txtLn.Text, cbxG.Text, txtEmail.Text, txtPhone.Text, txtUn.Text, txtP.Text, cbxR.Text, choice);

                txtId.Clear();
                txtEm.Clear();
                txtPn.Clear();
                txtU.Clear();
                txtFn.Clear();
                txtLn.Clear();
                cbxG.Text = "";
                txtEmail.Clear();
                txtPhone.Clear();
                txtUn.Clear();
                txtP.Clear();
                txtCp.Clear();
                cbxR.Text = "";
            }
            else
            {
                MessageBox.Show("Password and Confirm Passowrd are not the same!!");
                txtP.Clear();
                txtCp.Clear();
            }
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            if (checkNumValidity(txtId.Text) == true)
            {
                if (txtId.Text == "")
                {
                    tableView.DataSource = "";
                    tableView.Hide();
                }
                else
                {
                    DBLayer db = new DBLayer();
                    DataTable dt = db.getEmployee(txtId.Text, ch);
                    tableView.DataSource = dt;
                    txtId.ForeColor = Color.White;
                    txtEm.Clear();
                    txtPn.Clear();
                    txtU.Clear();
                    tableView.Show();
                }
            }
            else
            {
                txtId.ForeColor = Color.Red;
                tableView.DataSource = "";
                tableView.Hide();
            }
        }

        private void txtEm_TextChanged(object sender, EventArgs e)
        {
            if (checkEmailValidity(txtEm.Text) == true)
            {
                if (txtEm.Text == "")
                {
                    tableView.DataSource = "";
                    tableView.Show();
                }
                else
                {
                    DBLayer db = new DBLayer();
                    DataTable dt = db.getEmployee(txtEm.Text, ch);
                    tableView.DataSource = dt;
                    txtEm.ForeColor = Color.White;
                    txtId.Clear();
                    txtPn.Clear();
                    txtU.Clear();
                    tableView.Show();
                }
            }
            else
            {
                txtEm.ForeColor = Color.Red;
                tableView.DataSource = "";
                tableView.Hide();

            }
        }

        private void txtU_TextChanged(object sender, EventArgs e)
        {
            if (checkUsernameValidity(txtU.Text) == true)
            {
                if (txtU.Text == "")
                {
                    tableView.DataSource = "";
                    tableView.Hide();
                }
                else
                {
                    DBLayer db = new DBLayer();
                    DataTable dt = db.getEmployee(txtU.Text, ch);
                    tableView.DataSource = dt;
                    txtU.ForeColor = Color.White;
                    txtId.Clear();
                    txtEm.Clear();
                    txtPn.Clear();
                    tableView.Show();
                }
            }
            else
            {
                txtU.ForeColor = Color.Red;
                tableView.DataSource = "";
                tableView.Hide();
            }
        }

        private void txtPn_TextChanged(object sender, EventArgs e)
        {
            if (checkNumValidity(txtPn.Text) == true)
            {
                if (txtPn.Text == "")
                {
                    tableView.DataSource = "";
                    tableView.Hide();
                }
                else
                {
                    DBLayer db = new DBLayer();
                    DataTable dt = db.getEmployee(txtPn.Text, ch);
                    tableView.DataSource = dt;
                    txtPn.ForeColor = Color.White;
                    txtId.Clear();
                    txtEm.Clear();
                    txtU.Clear();
                    tableView.Show();
                }
            }
            else
            {
                txtPn.ForeColor = Color.Red;
                tableView.DataSource = "";
                tableView.Hide();
            }
        }

        public bool checkNumValidity(string str)
        {
            int len = str.Length;
            for (int i = 0; i < len; i++)
            {
                if (str[i] < '0' || str[i] > '9')
                    return false;
            }
            return true;
        }

        public bool checkUsernameValidity(string str)
        {
            int len = str.Length;
            for (int i = 0; i < len; i++)
            {
                if (!(str[i] >= 'A' && str[i] <= 'Z' || str[i] >= 'a' && str[i] <= 'z' || str[i] == '_' || str[i] >= '0' && str[i] <= '9'))
                    return false;
            }
            return true;
        }

        public bool checkEmailValidity(string str)
        {
            int len = str.Length;
            for (int i = 0; i < len; i++)
            {
                if (!(str[i] >= 'A' && str[i] <= 'Z' || str[i] >= 'a' && str[i] <= 'z' || str[i] == '_' || str[i] == '@' || str[i] == '.' ||
                    str[i] >= '0' && str[i] <= '9'))
                    return false;
            }
            return true;
        }
    }
}
