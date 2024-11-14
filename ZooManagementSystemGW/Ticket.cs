using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooManagementSystemGW
{
    class Ticket
    {
        public string amount, tType, eUsername, prise;
        public int choice;
         
        public Ticket() { }

        public Ticket(string prise, int choice)
        {
            this.prise = prise;
            this.choice = choice;
        }

        public Ticket(string a, string t, string eu)
        {
            amount = a;
            tType = t;
            eUsername = eu;
        }
        public Ticket(int choice)
        {
            this.choice = choice;
        }

        public void Ticketing()
        {
            DBLayer db = new DBLayer();
            db.Ticketing(this);
            db.TicketingSp(this);
        }

        public DataSet RecordPerTime()
        {
            DBLayer db = new DBLayer();
            return db.RecordPerTimeSP(this);

        }

        public void PriseUpdate()
        {
            DBLayer db = new DBLayer();
            db.PriseUpdateSP(this);
        }
    }
}
