using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ZooManagementSystemGW
{
    public partial class RecordPerTime : Form
    {
        public RecordPerTime()
        {
            InitializeComponent();
            btnr.Hide();
            btnl.Hide();
            chart.Hide();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            int choice = 0;
            if (cbx.Text == "Today") choice = 1;
            else if (cbx.Text == "All") choice = 2;
            else if (cbx.Text == "Last Month") choice = 3;
            else if (cbx.Text == "Last Year") choice = 4;
            else MessageBox.Show("The box must be filled!!");

            Ticket t = new Ticket(choice);
            DataSet ds = new DataSet();
            ds = t.RecordPerTime();
            chart.DataSource = ds;
            chart.Series["Sales"].XValueMember = "TicketType";
            chart.Series["Sales"].YValueMembers = "Amount";
            chart.Titles.Clear();
            chart.Titles.Add("Ticket Sales");
            chart.Series["Sales"].ChartType = SeriesChartType.Column;
            chart.Show();
            btnr.Show();
            btnl.Hide();

        }

        private void btnr_Click(object sender, EventArgs e)
        {
            if (chart.Series["Sales"].ChartType == SeriesChartType.Column)
            {
                btnl.Show();
                chart.Series["Sales"].ChartType = SeriesChartType.Pie;
            }

            else if (chart.Series["Sales"].ChartType == SeriesChartType.Pie) chart.Series["Sales"].ChartType = SeriesChartType.Bar;

            else if (chart.Series["Sales"].ChartType == SeriesChartType.Bar) chart.Series["Sales"].ChartType = SeriesChartType.Area;

            else
            {
                btnr.Hide();
                chart.Series["Sales"].ChartType = SeriesChartType.Line;
            }

        }

        private void btnl_Click(object sender, EventArgs e)
        {
            if (chart.Series["Sales"].ChartType == SeriesChartType.Line)
            {
                btnr.Show();
                chart.Series["Sales"].ChartType = SeriesChartType.Area;
            }

            else if (chart.Series["Sales"].ChartType == SeriesChartType.Area) chart.Series["Sales"].ChartType = SeriesChartType.Bar;

            else if (chart.Series["Sales"].ChartType == SeriesChartType.Bar) chart.Series["Sales"].ChartType = SeriesChartType.Pie;

            else
            {
                btnl.Hide();
                chart.Series["Sales"].ChartType = SeriesChartType.Column;
            }
        }
    }
}
