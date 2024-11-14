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
    public partial class CheckUpUpdate : Form
    {
        public string username;
        public CheckUpUpdate()
        {
            InitializeComponent();
            tableView.Hide();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            CheckUp c = new CheckUp(txtId.Text, cbxTT.Text, cbxR.Text, txtAT.Text, txtM.Text, username);
            c.updateCheckUp();
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
                    DataTable dt = db.getCheckUp(txtId.Text, 1);
                    tableView.DataSource = dt;
                    txtId.ForeColor = Color.White;
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
    }
}
