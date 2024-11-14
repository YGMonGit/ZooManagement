using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooManagementSystemGW
{
    class Animal
    {
        public string id, animalType, animalName,gender, cageNo, birthdate, food;
        public Animal() { }

        public Animal(string id)
        {
            this.id = id;
        }

        public Animal(string animalType, string animalName,string gender, string cageNo, string birthdate, string food)
        {
            this.animalType = animalType;
            this.animalName = animalName;
            this.gender = gender;
            this.cageNo = cageNo;
            this.birthdate = birthdate;
            this.food = food;
        }
        public Animal(string id, string cageNo, string food)
        {
            this.id = id;
            this.cageNo = cageNo;
            this.food = food;
        }

        public void animalAdd()
        {
            DBLayer db = new DBLayer();
            db.AddAnimalsp(this);
        }

        public void animalUpdate()
        {
            DBLayer db = new DBLayer();
            db.UpdateAnimalsp(this);
        }
        public void DeleteAnimal()
        {
            DBLayer db = new DBLayer();
            db.DeleteAnimalsp(this);
        }
    }
}
