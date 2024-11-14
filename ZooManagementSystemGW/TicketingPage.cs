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
    public partial class TicketingPage : Form
    {

        public string username;

        public TicketingPage()
        {
            InitializeComponent();
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            Ticket t = new Ticket(txtA.Text, cbxTT.Text, username);
            t.Ticketing();
        }
    }
}
