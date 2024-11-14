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
    public partial class PrisePerTimeDiff : Form
    {
        public PrisePerTimeDiff()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (cbxYf.Text != "Year" && cbxMf.Text != "Month" && cbxDf.Text != "Day" && cbxYt.Text != "Year" && cbxMt.Text != "Month" && cbxDt.Text != "Day")
            {
                string fdate, tdate;
                fdate = cbxYf.Text + '-' + cbxMf.Text + '-' + cbxDf.Text;
                tdate = cbxYt.Text + '-' + cbxMt.Text + '-' + cbxDt.Text;

                DBLayer db = new DBLayer();
                DataTable dt = db.PricePerTimeDiffSp(fdate, tdate);
                tableView.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Every box must be filled!!");
                tableView.DataSource = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cbxYf.Text = "Year";
            cbxMf.Text = "Month";
            cbxDf.Text = "Day";
            cbxYt.Text = "Year";
            cbxMt.Text = "Month";
            cbxDt.Text = "Day";
            tableView.DataSource = "";
        }
    }
}
