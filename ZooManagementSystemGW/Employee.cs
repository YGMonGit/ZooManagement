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
    class Employee
    {
        public string updateby, firstName, lastName, Gender, email, PhoneNo, username, opass, passcode, role;
        public int choice;

        public Employee() { }

        public Employee(string opass, string updateby, string username, int choice)
        {
            this.opass = opass;
            this.updateby = updateby;
            this.username = username;
            this.choice = choice;
        }

        public Employee(string updateby, string username,int choice)
        {
            this.updateby = updateby;
            this.username = username;
            this.choice = choice;
        }

        public Employee(string firstName, string lastName, string Gender, string email, string PhoneNo, string username, string passcode, string role)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.Gender = Gender;
            this.email = email;
            this.PhoneNo = PhoneNo;
            this.username = username;
            this.passcode = passcode;
            this.role = role;
        }
        public Employee(string firstName, string lastName, string Gender, string email, string PhoneNo, string username, string passcode, string role, int choice)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.Gender = Gender;
            this.email = email;
            this.PhoneNo = PhoneNo;
            this.username = username;
            this.passcode = passcode;
            this.role = role;
            this.choice = choice;
        }

        public void UpdateEmployee(string updateby, string firstName, string lastName, string Gender, string email, string PhoneNo, string username, string passcode, string role, int choice)
        {
            this.updateby = updateby;
            this.firstName = firstName;
            this.lastName = lastName;
            this.Gender = Gender;
            this.email = email;
            this.PhoneNo = PhoneNo;
            this.username = username;
            this.passcode = passcode;
            this.role = role;
            this.choice = choice;

            DBLayer db = new DBLayer();
            db.updateEmployee(this);
            db.updateEmployeeByStoreProc(this);
        }

        public void DeleteEmployee(string updateby,int choice)
        {
            this.updateby = updateby;
            this.choice = choice;

            DBLayer db = new DBLayer();
            db.deleteEmployee(this);
            db.deleteEmployeeByStoreProc(this);
        }

        public Employee(string username, string passcode)
        {
            this.username = username;
            this.passcode = passcode;
        }

        public bool CheckEmployee()
        {
            DBLayer dbl = new DBLayer();
            return dbl.checkDbEmployee(this);
        }

        public void SaveEmployee()
        {
            DBLayer ul3 = new DBLayer();
            ul3.SaveEmployee(this);
            ul3.saveEmployeeByStoreProc(this);
        }

    }
}
