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
    public partial class TicketPriceUpdate : Form
    {

        public int choice = 0;

        public TicketPriceUpdate()
        {
            InitializeComponent();
            lagroup.Hide();
            lcgroup.Hide();
            fagroup.Hide();
            fcgroup.Hide();
            btn.Hide();
        }

        private void btnLA_Click(object sender, EventArgs e)
        {
            lagroup.Show();
            lagroup.Dock = DockStyle.Top;
            lcgroup.Hide();
            fagroup.Hide();
            fcgroup.Hide();
            btnLA.ForeColor = Color.Yellow;
            btnLC.ForeColor = Color.White;
            btnFA.ForeColor = Color.White;
            btnFC.ForeColor = Color.White;
            btn.Show();
            choice = 1;
            txtLA.Clear();
            txtLC.Clear();
            txtFA.Clear();
            txtFC.Clear();
        }

        private void btnLC_Click(object sender, EventArgs e)
        {
            lcgroup.Show();
            lcgroup.Dock = DockStyle.Top;
            lagroup.Hide();
            fagroup.Hide();
            fcgroup.Hide();
            btnLA.ForeColor = Color.White;
            btnLC.ForeColor = Color.Yellow;
            btnFA.ForeColor = Color.White;
            btnFC.ForeColor = Color.White;
            btn.Show();
            choice = 2;
            txtLA.Clear();
            txtLC.Clear();
            txtFA.Clear();
            txtFC.Clear();
        }

        private void btnFA_Click(object sender, EventArgs e)
        {
            fagroup.Show();
            fagroup.Dock = DockStyle.Top;
            lcgroup.Hide();
            lagroup.Hide();
            fcgroup.Hide();
            btnLA.ForeColor = Color.White;
            btnLC.ForeColor = Color.White;
            btnFA.ForeColor = Color.Yellow;
            btnFC.ForeColor = Color.White;
            btn.Show();
            choice = 3;
            txtLA.Clear();
            txtLC.Clear();
            txtFA.Clear();
            txtFC.Clear();
        }

        private void btnFC_Click(object sender, EventArgs e)
        {
            fcgroup.Show();
            fcgroup.Dock = DockStyle.Top;
            lcgroup.Hide();
            fagroup.Hide();
            lagroup.Hide();
            btnLA.ForeColor = Color.White;
            btnLC.ForeColor = Color.White;
            btnFA.ForeColor = Color.White;
            btnFC.ForeColor = Color.Yellow;
            btn.Show();
            choice = 4;
            txtLA.Clear();
            txtLC.Clear();
            txtFA.Clear();
            txtFC.Clear();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if(choice == 1)
            {
                Ticket t = new Ticket(txtLA.Text, choice);
                t.PriseUpdate();
            }else if(choice == 2)
            {
                Ticket t = new Ticket(txtLC.Text, choice);
                t.PriseUpdate();
            }else if(choice == 3)
            {
                Ticket t = new Ticket(txtFA.Text, choice);
                t.PriseUpdate();
            }
            else
            {
                Ticket t = new Ticket(txtFC.Text, choice);
                t.PriseUpdate();
            }
        }
    }
}
