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
    public partial class FoodTableView : Form
    {
        public int choice = 0;
        public FoodTableView()
        {
            InitializeComponent();
            igroup.Hide();
            ngroup.Hide();
            agroup.Hide();
            fgroup.Hide();
        }

        private void btnI_Click(object sender, EventArgs e)
        {
            igroup.Show();
            igroup.Dock = DockStyle.Top;
            ngroup.Hide();
            agroup.Hide();
            fgroup.Hide();
            btnN.ForeColor = Color.White;
            btnFpd.ForeColor = Color.White;
            btnA.ForeColor = Color.White;
            btnI.ForeColor = Color.Yellow;
            this.choice = 1;
            txtFn.Clear();
            txtId.Clear();
            txtFpd.Clear();
            txtA.Clear();
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

        private void btnN_Click(object sender, EventArgs e)
        {
            ngroup.Show();
            ngroup.Dock = DockStyle.Top;
            igroup.Hide();
            agroup.Hide();
            fgroup.Hide();
            btnN.ForeColor = Color.Yellow;
            btnFpd.ForeColor = Color.White;
            btnA.ForeColor = Color.White;
            btnI.ForeColor = Color.White;
            this.choice = 2;
            txtFn.Clear();
            txtId.Clear();
            txtFpd.Clear();
            txtA.Clear();
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            agroup.Show();
            agroup.Dock = DockStyle.Top;
            igroup.Hide();
            ngroup.Hide();
            fgroup.Hide();
            btnN.ForeColor = Color.White;
            btnFpd.ForeColor = Color.White;
            btnA.ForeColor = Color.Yellow;
            btnI.ForeColor = Color.White;
            this.choice = 3;
            txtFn.Clear();
            txtId.Clear();
            txtFpd.Clear();
            txtA.Clear();
        }

        private void btnFpd_Click(object sender, EventArgs e)
        {
            fgroup.Show();
            fgroup.Dock = DockStyle.Top;
            igroup.Hide();
            ngroup.Hide();
            agroup.Hide();
            btnN.ForeColor = Color.White;
            btnFpd.ForeColor = Color.Yellow;
            btnA.ForeColor = Color.White;
            btnI.ForeColor = Color.White;
            this.choice = 3;
            txtFn.Clear();
            txtId.Clear();
            txtFpd.Clear();
            txtA.Clear();
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
                    DataTable dt = db.getFood(txtId.Text, choice);
                    tableView.DataSource = dt;
                    txtId.ForeColor = Color.White;
                    txtFn.Clear();
                    txtFpd.Clear();
                    txtA.Clear();
                }
            }
            else
            {
                txtId.ForeColor = Color.Red;
                tableView.DataSource = "";
            }
        }

        private void txtFn_TextChanged(object sender, EventArgs e)
        {
            if (checkStringValidity(txtFn.Text) == true)
            {
                if (txtFn.Text == "")
                {
                    tableView.DataSource = "";
                }
                else
                {
                    DBLayer db = new DBLayer();
                    DataTable dt = db.getFood(txtFn.Text, choice);
                    tableView.DataSource = dt;
                    txtFn.ForeColor = Color.White;
                    txtId.Clear();
                    txtFpd.Clear();
                    txtA.Clear();
                }
            }
            else
            {
                txtFn.ForeColor = Color.Red;
                tableView.DataSource = "";
            }
        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {
            if (checkNumValidity(txtA.Text) == true)
            {
                if (txtA.Text == "")
                {
                    tableView.DataSource = "";
                }
                else
                {
                    DBLayer db = new DBLayer();
                    DataTable dt = db.getFood(txtA.Text, choice);
                    tableView.DataSource = dt;
                    txtA.ForeColor = Color.White;
                    txtId.Clear();
                    txtFpd.Clear();
                    txtFn.Clear();
                }
            }
            else
            {
                txtA.ForeColor = Color.Red;
                tableView.DataSource = "";
            }
        }

        private void txtFpd_TextChanged(object sender, EventArgs e)
        {
            if (checkNumValidity(txtFpd.Text) == true)
            {
                if (txtFpd.Text == "")
                {
                    tableView.DataSource = "";
                }
                else
                {
                    DBLayer db = new DBLayer();
                    DataTable dt = db.getFood(txtFpd.Text, choice);
                    tableView.DataSource = dt;
                    txtFpd.ForeColor = Color.White;
                    txtId.Clear();
                    txtFn.Clear();
                    txtA.Clear();
                }
            }
            else
            {
                txtFpd.ForeColor = Color.Red;
                tableView.DataSource = "";
            }
        }
    }
}
