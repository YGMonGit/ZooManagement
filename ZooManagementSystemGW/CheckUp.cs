using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooManagementSystemGW
{
    class CheckUp
    {
        public string id, treatType, treatRoom, animal,medicine, username;

        public CheckUp() { }

        public CheckUp(string id) 
        {
            this.id = id;
        }

        public CheckUp(string id, string treatType,string treatRoom,string animal, string medicine,string username)
        {
            this.id = id;
            this.treatType = treatType;
            this.treatRoom = treatRoom;
            this.animal = animal;
            this.medicine = medicine;
            this.username = username;
        }

        public CheckUp(string treatType, string treatRoom, string animal, string medicine, string username)
        {
            this.treatType = treatType;
            this.treatRoom = treatRoom;
            this.animal = animal;
            this.medicine = medicine;
            this.username = username;
        }

        public void insertCheckUp()
        {
            DBLayer db = new DBLayer();
            db.InsertTreatmentsp(this);
        }

        public void updateCheckUp()
        {
            DBLayer db = new DBLayer();
            db.UpdateTreatmentsp(this);
        }
        public void deleteCheckUp()
        {
            DBLayer db = new DBLayer();
            db.DeleteTreatmentsp(this);
        }

    }
}
