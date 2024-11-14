using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooManagementSystemGW
{
    class Medicine
    {
        public string id, name, description, expiredate;
        public Medicine() { }

        public Medicine(string id)
        {
            this.id = id;
        }

        public Medicine(string id,string name,string description, string expiredate)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.expiredate = expiredate;
        }

        public Medicine(string name, string description, string expiredate)
        {
            this.name = name;
            this.description = description;
            this.expiredate = expiredate;
        }

        public void InsertMedicine()
        {
            DBLayer db = new DBLayer();
            db.InsertMedicinesp(this);
        }
        public void UpdateMedicine()
        {
            DBLayer db = new DBLayer();
            db.UpdateMedicinesp(this);
        }
        public void DeleteMedicine()
        {
            DBLayer db = new DBLayer();
            db.DeleteMedicinesp(this);
        }

        public DataTable ViewMedicine()
        {
            DBLayer db = new DBLayer();
            return db.ViewMedicinesp();
        }
    }
}
