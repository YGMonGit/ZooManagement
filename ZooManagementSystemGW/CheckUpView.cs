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
    public partial class CheckUpView : Form
    {
        public int choice = 0;
        public CheckUpView()
        {
            InitializeComponent();
            igroup.Hide();
            tgroup.Hide();
            egroup.Hide();
        }

        private void btnI_Click(object sender, EventArgs e)
        {
            igroup.Show();
            igroup.Dock = DockStyle.Top;
            tgroup.Hide();
            egroup.Hide();
            btnT.ForeColor = Color.White;
            btnE.ForeColor = Color.White;
            btnI.ForeColor = Color.Yellow;
            this.choice = 1;
            txtId.Clear();
            txtTT.Clear();
            txtE.Clear();
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            tgroup.Show();
            tgroup.Dock = DockStyle.Top;
            igroup.Hide();
            egroup.Hide();
            btnT.ForeColor = Color.Yellow;
            btnE.ForeColor = Color.White;
            btnI.ForeColor = Color.White;
            this.choice = 2;
            txtId.Clear();
            txtTT.Clear();
            txtE.Clear();
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            egroup.Show();
            egroup.Dock = DockStyle.Top;
            tgroup.Hide();
            igroup.Hide();
            btnT.ForeColor = Color.White;
            btnE.ForeColor = Color.Yellow;
            btnI.ForeColor = Color.White;
            this.choice = 3;
            txtId.Clear();
            txtTT.Clear();
            txtE.Clear();
        }

        public bool checkStringValidity(string str)
        {
            int len = str.Length;
            for (int i = 0; i < len; i++)
            {
                if (!(str[i] >= 'A' && str[i] <= 'Z' || str[i] >= 'a' && str[i] <= 'z'))
                    return false;
            }
            return true;
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
                    DataTable dt = db.getCheckUp(txtId.Text, choice);
                    tableView.DataSource = dt;
                    txtId.ForeColor = Color.White;
                    txtTT.Clear();
                    txtE.Clear();
                }
            }
            else
            {
                txtId.ForeColor = Color.Red;
                tableView.DataSource = "";
            }
        }

        private void txtTT_TextChanged(object sender, EventArgs e)
        {
            if (checkStringValidity(txtTT.Text) == true)
            {
                if (txtTT.Text == "")
                {
                    tableView.DataSource = "";
                }
                else
                {
                    DBLayer db = new DBLayer();
                    DataTable dt = db.getCheckUp(txtTT.Text, choice);
                    tableView.DataSource = dt;
                    txtTT.ForeColor = Color.White;
                    txtId.Clear();
                    txtE.Clear();
                }
            }
            else
            {
                txtTT.ForeColor = Color.Red;
                tableView.DataSource = "";
            }
        }

        private void txtE_TextChanged(object sender, EventArgs e)
        {
            if (checkStringValidity(txtE.Text) == true)
            {
                if (txtE.Text == "")
                {
                    tableView.DataSource = "";
                }
                else
                {
                    DBLayer db = new DBLayer();
                    DataTable dt = db.getCheckUp(txtE.Text, choice);
                    tableView.DataSource = dt;
                    txtE.ForeColor = Color.White;
                    txtTT.Clear();
                    txtId.Clear();
                }
            }
            else
            {
                txtE.ForeColor = Color.Red;
                tableView.DataSource = "";
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
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
