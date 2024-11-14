using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooManagementSystemGW
{
    class Food
    {
        public string id, foodname, amount, freqPerDay, username;

        public Food() { }


        public Food(string id)
        {
            this.id = id;
        }

        public Food(string foodname, string amount, string freqPerDay, string username)
        {
            this.foodname = foodname;
            this.amount = amount;
            this.freqPerDay = freqPerDay;
            this.username = username;
        }

        public Food(string id, string foodname, string amount, string freqPerDay, string username)
        {
            this.id = id;
            this.foodname = foodname;
            this.amount = amount;
            this.freqPerDay = freqPerDay;
            this.username = username;
        }

        public void addFood()
        {
            DBLayer db = new DBLayer();
            db.AddFoodsp(this);
        }
        public void UpdateFood()
        {
            DBLayer db = new DBLayer();
            db.UpdateFoodsp(this);
        }

        public void DeleteFood()
        {
            DBLayer db = new DBLayer();
            db.DeleteFoodsp(this);
        }

    }
}
