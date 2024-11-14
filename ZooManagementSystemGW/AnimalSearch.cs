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
    public partial class AnimalSearch : Form
    {

        public int choice = 0;
        public AnimalSearch()
        {
            InitializeComponent();
            ngroup.Hide();
            tgroup.Hide();
            cgroup.Hide();
            fgroup.Hide();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            ngroup.Show();
            ngroup.Dock = DockStyle.Top;
            tgroup.Hide();
            cgroup.Hide();
            fgroup.Hide();
            btnN.ForeColor = Color.Yellow;
            btnT.ForeColor = Color.White;
            btnC.ForeColor = Color.White;
            BtnF.ForeColor = Color.White;
            choice = 1;
            txtN.Clear();
            txtt.Clear();
            txtC.Clear();
            txtF.Clear();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            tgroup.Show();
            tgroup.Dock = DockStyle.Top;
            ngroup.Hide();
            cgroup.Hide();
            fgroup.Hide();
            btnN.ForeColor = Color.White;
            btnT.ForeColor = Color.Yellow;
            btnC.ForeColor = Color.White;
            BtnF.ForeColor = Color.White;
            choice = 2;
            txtN.Clear();
            txtt.Clear();
            txtC.Clear();
            txtF.Clear();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            cgroup.Show();
            cgroup.Dock = DockStyle.Top;
            tgroup.Hide();
            ngroup.Hide();
            fgroup.Hide();
            btnN.ForeColor = Color.White;
            btnT.ForeColor = Color.White;
            btnC.ForeColor = Color.Yellow;
            BtnF.ForeColor = Color.White;
            choice = 3;
            txtN.Clear();
            txtt.Clear();
            txtC.Clear();
            txtF.Clear();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            fgroup.Show();
            fgroup.Dock = DockStyle.Top;
            tgroup.Hide();
            cgroup.Hide();
            ngroup.Hide();
            btnN.ForeColor = Color.White;
            btnT.ForeColor = Color.White;
            btnC.ForeColor = Color.White;
            BtnF.ForeColor = Color.Yellow;
            choice = 4;
            txtN.Clear();
            txtt.Clear();
            txtC.Clear();
            txtF.Clear();
        }

        private void btn_Click(object sender, EventArgs e)
        {

        }

        private void txtN_TextChanged(object sender, EventArgs e)
        {
            if (checkStringValidity(txtN.Text) == true)
            {
                if (txtN.Text == "")
                {
                    tableView.DataSource = "";
                }
                else
                {
                    DBLayer db = new DBLayer();
                    DataTable dt = db.getAnimal(txtN.Text, choice);
                    tableView.DataSource = dt;
                    txtN.ForeColor = Color.White;
                    txtt.Clear();
                    txtC.Clear();
                    txtF.Clear();
                }
            }
            else
            {
                txtN.ForeColor = Color.Red;
                tableView.DataSource = "";
            }
        }

        private void txtt_TextChanged(object sender, EventArgs e)
        {
            if (checkStringValidity(txtt.Text) == true)
            {
                if (txtt.Text == "")
                {
                    tableView.DataSource = "";
                }
                else
                {
                    DBLayer db = new DBLayer();
                    DataTable dt = db.getAnimal(txtt.Text, choice);
                    tableView.DataSource = dt;
                    txtt.ForeColor = Color.White;
                    txtN.Clear();
                    txtC.Clear();
                    txtF.Clear();
                }
            }
            else
            {
                txtt.ForeColor = Color.Red;
                tableView.DataSource = "";
            }
        }

        private void txtC_TextChanged(object sender, EventArgs e)
        {
            if (checkCageNoValidity(txtC.Text) == true)
            {
                if (txtC.Text == "")
                {
                    tableView.DataSource = "";
                }
                else
                {
                    DBLayer db = new DBLayer();
                    DataTable dt = db.getAnimal(txtC.Text, choice);
                    tableView.DataSource = dt;
                    txtC.ForeColor = Color.White;
                    txtt.Clear();
                    txtN.Clear();
                    txtF.Clear();
                }
            }
            else
            {
                txtC.ForeColor = Color.Red;
                tableView.DataSource = "";
            }
        }

        private void txtF_TextChanged(object sender, EventArgs e)
        {
            if (checkStringValidity(txtF.Text) == true)
            {
                if (txtF.Text == "")
                {
                    tableView.DataSource = "";
                }
                else
                {
                    DBLayer db = new DBLayer();
                    DataTable dt = db.getAnimal(txtF.Text, choice);
                    tableView.DataSource = dt;
                    txtF.ForeColor = Color.White;
                    txtt.Clear();
                    txtN.Clear();
                    txtC.Clear();
                }
            }
            else
            {
                txtF.ForeColor = Color.Red;
                tableView.DataSource = "";
            }
        }

        public bool checkCageNoValidity(string str)
        {
            int len = str.Length;
            for (int i = 0; i < len; i++)
            {
                if (!(str[i] >= 'A' && str[i] <= 'Z' || str[i] >= 'a' && str[i] <= 'z' || str[i] >= '0' && str[i] <= '9'))
                    return false;
            }
            return true;
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
    }
}
