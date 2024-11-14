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
    public partial class EmployeeSearch : Form
    {
        int choice = 0;
        public EmployeeSearch()
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
            this.choice = 2;
            txtEm.Clear();
            txtId.Clear();
            txtPn.Clear();
            txtU.Clear();
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
            this.choice = 3;
            txtEm.Clear();
            txtId.Clear();
            txtPn.Clear();
            txtU.Clear();
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
            this.choice = 4;
            txtEm.Clear();
            txtId.Clear();
            txtPn.Clear();
            txtU.Clear();
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
            this.choice = 1;
            txtEm.Clear();
            txtId.Clear();
            txtPn.Clear();
            txtU.Clear();
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            if (checkNumValidity(txtId.Text) == true)
            {
                if (txtId.Text == "")
                {
                    tableView.DataSource = "";
                }
                else
                {
                    DBLayer db = new DBLayer();
                    DataTable dt = db.getEmployee(txtId.Text, choice);
                    tableView.DataSource = dt;
                    txtId.ForeColor = Color.White;
                    txtEm.Clear();
                    txtPn.Clear();
                    txtU.Clear();
                }
            }
            else
            {
                txtId.ForeColor = Color.Red;
                tableView.DataSource = "";
            }
        }

        private void txtEm_TextChanged(object sender, EventArgs e)
        {
            if (checkEmailValidity(txtEm.Text) == true)
            {
                if (txtEm.Text == "")
                {
                    tableView.DataSource = "";
                }
                else
                {
                    DBLayer db = new DBLayer();
                    DataTable dt = db.getEmployee(txtEm.Text, choice);
                    tableView.DataSource = dt;
                    txtEm.ForeColor = Color.White;
                    txtId.Clear();
                    txtPn.Clear();
                    txtU.Clear();
                }
            }
            else
            {
                txtEm.ForeColor = Color.Red;
                tableView.DataSource = "";
            }
        }

        private void txtU_TextChanged(object sender, EventArgs e)
        {
            if (checkUsernameValidity(txtU.Text) == true)
            {
                if (txtU.Text == "")
                {
                    tableView.DataSource = "";
                }
                else
                {
                    DBLayer db = new DBLayer();
                    DataTable dt = db.getEmployee(txtU.Text, choice);
                    tableView.DataSource = dt;
                    txtU.ForeColor = Color.White;
                    txtId.Clear();
                    txtEm.Clear();
                    txtPn.Clear();
                }
            }
            else
            {
                txtU.ForeColor = Color.Red;
                tableView.DataSource = "";
            }
        }

        private void txtPn_TextChanged(object sender, EventArgs e)
        {
            if (checkNumValidity(txtPn.Text) == true)
            {
                if (txtPn.Text == "")
                {
                    tableView.DataSource = "";
                }
                else
                {
                    DBLayer db = new DBLayer();
                    DataTable dt = db.getEmployee(txtPn.Text, choice);
                    tableView.DataSource = dt;
                    txtPn.ForeColor = Color.White;
                    txtId.Clear();
                    txtEm.Clear();
                    txtU.Clear();
                }
            }
            else
            {
                txtPn.ForeColor = Color.Red;
                tableView.DataSource = "";
            }
        }

        public bool checkNumValidity(string str)
        {
            int len = str.Length;
            for(int i=0; i<len; i++)
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
                if (!(str[i] >= 'A' && str[i] <= 'Z' || str[i] >= 'a' && str[i] <= 'z' || str[i] == '_' || str[i] >= '0'&& str[i] <= '9'))
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

        private void tableView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl0_Click(object sender, EventArgs e)
        {

        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }
    }
}
