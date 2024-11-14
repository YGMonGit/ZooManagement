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
    class DBLayer
    {

        string constr = "Server = LAPTOP-J4C6QAOC; database = zoo; uid =lab2;pwd =123";

        public void Ticketing(Ticket t)
        {
            string query = "INSERT INTO Ticket(Amount, TicketType) VALUES ('" + t.amount + "', '" + t.tType + "')";
            MessageBox.Show(query);
        }

        public void SaveEmployee(Employee e)
        {
            string query = "INSERT INTO Employee(FirstName, LastName, Gender, Email, MobileNumber, Username, Passcode, WorkRole) VALUES ('" + 
                e.firstName + "', '" + e.lastName + "', '" + e.Gender + "', '" + e.email + "', '" + e.PhoneNo + "', '" + e.username + "', '" +
                e.passcode + "', '" + e.role + "')";
            MessageBox.Show(query);
        }

        public void updateEmployee(Employee e)
        {
            string query = "update Employee set FirstName =" + e.firstName + "'LastName ='" + e.lastName + "',Gender ='" +
                e.Gender + "',Email ='" + e.email + "',MobileNumber ='" + e.PhoneNo + "',Username ='" + e.username + "',Passcode ='" +
                e.passcode + "'WorkRole ='" + e.role + "'\nWHERE";
            if (e.choice == 1)
                query += " Eid = " + e.updateby;
            else if (e.choice == 2)
                query += " Email = " + e.updateby;
            else if (e.choice == 3)
                query += " MobileNumber = " + e.updateby;
            else
                query += " Username = " + e.updateby;

            MessageBox.Show(query);
        }

        public void deleteEmployee(Employee e)
        {
            string query = "DELETE Employee \nWHERE ";
            if (e.choice == 1)
                query += "Eid = " + e.updateby;
            else if (e.choice == 2)
                query += "Email = " + e.updateby;
            else if (e.choice == 3)
                query += "MobileNumber = " + e.updateby;
            else
                query += "Username = " + e.updateby;
            MessageBox.Show(query);
        }

        public void getEmployeeSyntax(Employee e)
        {
            string query = "SELECT *FROM Employee \nWHERE ";
            if (e.choice == 1)
                query += "Eid = " + e.updateby;
            else if (e.choice == 2)
                query += "Email = " + e.updateby;
            else if (e.choice == 3)
                query += "MobileNumber = " + e.updateby;
            else
                query += "Username = " + e.updateby;
            MessageBox.Show(query);

        }

        public bool checkDbEmployee(Employee e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();

                    string query = "select * from Employee where Username = '" + e.username + "' and Passcode = '" + e.passcode + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    DataTable dtbl = new DataTable();
                    sda.Fill(dtbl);
                    if (dtbl.Rows.Count == 1)
                        return true;
                    else
                        return false;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        public void saveEmployeeByStoreProc(Employee e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("spInsertEmployee", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@firstname", e.firstName);
                    cmd.Parameters.AddWithValue("@lastname", e.lastName);
                    cmd.Parameters.AddWithValue("@gender", e.Gender);
                    cmd.Parameters.AddWithValue("@email", e.email);
                    cmd.Parameters.AddWithValue("@mobilenumber", e.PhoneNo);
                    cmd.Parameters.AddWithValue("@username", e.username);
                    cmd.Parameters.AddWithValue("@password", e.passcode);
                    cmd.Parameters.AddWithValue("@role", e.role);
                    int row = cmd.ExecuteNonQuery();
                    con.Close();
                    if (row > 0)
                        MessageBox.Show("save succesfully");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void updateEmployeeByStoreProc(Employee e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("spUpdateEmployee", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@updateby", e.updateby);
                    cmd.Parameters.AddWithValue("@choice", e.choice);
                    cmd.Parameters.AddWithValue("@firstname", e.firstName);
                    cmd.Parameters.AddWithValue("@lastname", e.lastName);
                    cmd.Parameters.AddWithValue("@gender", e.Gender);
                    cmd.Parameters.AddWithValue("@email", e.email);
                    cmd.Parameters.AddWithValue("@mobilenumber", e.PhoneNo);
                    cmd.Parameters.AddWithValue("@username", e.username);
                    cmd.Parameters.AddWithValue("@password", e.passcode);
                    cmd.Parameters.AddWithValue("@role", e.role);
                    int row = cmd.ExecuteNonQuery();
                    con.Close();
                    if (row > 0)
                        MessageBox.Show("update succesfully");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void deleteEmployeeByStoreProc(Employee e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("spDeleteEmployee", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@updateby", e.updateby);
                    cmd.Parameters.AddWithValue("@choice", e.choice);
                    int row = cmd.ExecuteNonQuery();
                    con.Close();
                    if (row > 0)
                        MessageBox.Show("Delete succesfully");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public DataTable getEmployee(string str, int ival)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter())
                    {
                        da.SelectCommand = new SqlCommand("spSearchEmployee", con);
                        da.SelectCommand.CommandType = CommandType.StoredProcedure;
                        da.SelectCommand.Parameters.AddWithValue("@view", str);
                        da.SelectCommand.Parameters.AddWithValue("@ch", ival);

                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }

        public void TicketingSp(Ticket t)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("spInsertTicket", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@username", t.eUsername);
                    cmd.Parameters.AddWithValue("@type", t.tType);
                    cmd.Parameters.AddWithValue("@amount", t.amount);
                    int row = cmd.ExecuteNonQuery();
                    con.Close();
                    if (row > 0)
                        MessageBox.Show("save succesfully");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public DataTable PricePerTimeDiffSp(string fdate, string tdate)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter())
                    {
                        da.SelectCommand = new SqlCommand("spPrisePerTimeDiff", con);
                        da.SelectCommand.CommandType = CommandType.StoredProcedure;
                        da.SelectCommand.Parameters.AddWithValue("@fdate", fdate);
                        da.SelectCommand.Parameters.AddWithValue("@tdate", tdate);

                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }

        public DataSet RecordPerTimeSP(Ticket t)
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter())
                    {
                        da.SelectCommand = new SqlCommand("spRecordPerTime", con);
                        da.SelectCommand.CommandType = CommandType.StoredProcedure;
                        da.SelectCommand.Parameters.AddWithValue("@choice", t.choice);
                        da.Fill(ds);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ds;
        }

        public DataSet PriseUpdateSP(Ticket t)
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter())
                    {
                        da.SelectCommand = new SqlCommand("spTicketPriseUpdatea", con);
                        da.SelectCommand.CommandType = CommandType.StoredProcedure;
                        da.SelectCommand.Parameters.AddWithValue("@newPrise", t.prise);
                        da.SelectCommand.Parameters.AddWithValue("@choice", t.choice);
                        da.Fill(ds);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ds;
        }

        public void AddAnimalsp(Animal a)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("spInsertAnimal", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@animaltype", a.animalType);
                    cmd.Parameters.AddWithValue("@animalname", a.animalName);
                    cmd.Parameters.AddWithValue("@gender", a.gender);
                    cmd.Parameters.AddWithValue("@cageNo", a.cageNo);
                    cmd.Parameters.AddWithValue("@birthdate", a.birthdate);
                    cmd.Parameters.AddWithValue("@food", a.food);
                    int row = cmd.ExecuteNonQuery();
                    con.Close();
                    if (row > 0)
                        MessageBox.Show("save succesfully");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void UpdateAnimalsp(Animal a)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("spUpdateAnimal", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@sid", a.id);
                    cmd.Parameters.AddWithValue("@cageNo", a.cageNo);
                    cmd.Parameters.AddWithValue("@food", a.food);
                    int row = cmd.ExecuteNonQuery();
                    con.Close();
                    if (row > 0)
                        MessageBox.Show("update succesfully");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void DeleteAnimalsp(Animal a)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("spDeleteAnimal", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", a.id);
                    int row = cmd.ExecuteNonQuery();
                    con.Close();
                    if (row > 0)
                        MessageBox.Show("Delete succesfully");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public DataTable getAnimal(string str, int ival)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter())
                    {
                        da.SelectCommand = new SqlCommand("spSearchAnimal", con);
                        da.SelectCommand.CommandType = CommandType.StoredProcedure;
                        da.SelectCommand.Parameters.AddWithValue("@view", str);
                        da.SelectCommand.Parameters.AddWithValue("@ch", ival);

                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }

        public DataTable getAnimalId(string str)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter())
                    {
                        da.SelectCommand = new SqlCommand("spSearchAnimalById", con);
                        da.SelectCommand.CommandType = CommandType.StoredProcedure;
                        da.SelectCommand.Parameters.AddWithValue("@view", str);

                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }

        public void AddFoodsp(Food f)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("spInsertFood", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Fname", f.foodname);
                    cmd.Parameters.AddWithValue("@amount", f.amount);
                    cmd.Parameters.AddWithValue("@freqPerDay", f.freqPerDay);
                    cmd.Parameters.AddWithValue("@username", f.username);
                    int row = cmd.ExecuteNonQuery();
                    con.Close();
                    if (row > 0)
                        MessageBox.Show("save succesfully");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void UpdateFoodsp(Food f)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("spUpdateFood", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", f.id);
                    cmd.Parameters.AddWithValue("@Fname", f.foodname);
                    cmd.Parameters.AddWithValue("@amount", f.amount);
                    cmd.Parameters.AddWithValue("@freqPerDay", f.freqPerDay);
                    cmd.Parameters.AddWithValue("@username", f.username);
                    int row = cmd.ExecuteNonQuery();
                    con.Close();
                    if (row > 0)
                        MessageBox.Show("Update succesfully");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void DeleteFoodsp(Food f)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("spDeleteFood", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", f.id);
                    int row = cmd.ExecuteNonQuery();
                    con.Close();
                    if (row > 0)
                        MessageBox.Show("Delete succesfully");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public DataTable getFood(string str, int ival)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter())
                    {
                        da.SelectCommand = new SqlCommand("spSearchFood", con);
                        da.SelectCommand.CommandType = CommandType.StoredProcedure;
                        da.SelectCommand.Parameters.AddWithValue("@view", str);
                        da.SelectCommand.Parameters.AddWithValue("@ch", ival);

                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }

        public void InsertTreatmentsp(CheckUp c)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("spInsertCheckup", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@treatType", c.treatType);
                    cmd.Parameters.AddWithValue("@treatRoom", c.treatRoom);
                    cmd.Parameters.AddWithValue("@animal", c.animal);
                    cmd.Parameters.AddWithValue("@medicine", c.medicine);
                    cmd.Parameters.AddWithValue("@username", c.username);
                    int row = cmd.ExecuteNonQuery();
                    con.Close();
                    if (row > 0)
                        MessageBox.Show("save succesfully");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void UpdateTreatmentsp(CheckUp c)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("spUpdateCheckup", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", c.id);
                    cmd.Parameters.AddWithValue("@treatType", c.treatType);
                    cmd.Parameters.AddWithValue("@treatRoom", c.treatRoom);
                    cmd.Parameters.AddWithValue("@animal", c.animal);
                    cmd.Parameters.AddWithValue("@medicine", c.medicine);
                    cmd.Parameters.AddWithValue("@username", c.username);
                    int row = cmd.ExecuteNonQuery();
                    con.Close();
                    if (row > 0)
                        MessageBox.Show("Update succesfully");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void DeleteTreatmentsp(CheckUp c)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("spDeleteCheckup", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", c.id);
                    int row = cmd.ExecuteNonQuery();
                    con.Close();
                    if (row > 0)
                        MessageBox.Show("Delete succesfully");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public DataTable getCheckUp(string str, int ival)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter())
                    {
                        da.SelectCommand = new SqlCommand("spViewFood", con);
                        da.SelectCommand.CommandType = CommandType.StoredProcedure;
                        da.SelectCommand.Parameters.AddWithValue("@view", str);
                        da.SelectCommand.Parameters.AddWithValue("@ch", ival);

                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }

        public void InsertMedicinesp(Medicine m)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("spInsertMedicine", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@name", m.name);
                    cmd.Parameters.AddWithValue("@description", m.description);
                    cmd.Parameters.AddWithValue("@expiredate", m.expiredate);
                    int row = cmd.ExecuteNonQuery();
                    con.Close();
                    if (row > 0)
                        MessageBox.Show("save succesfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void UpdateMedicinesp(Medicine m)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("spUpdateMedicine", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", m.id);
                    cmd.Parameters.AddWithValue("@name", m.name);
                    cmd.Parameters.AddWithValue("@description", m.description);
                    cmd.Parameters.AddWithValue("@expiredate", m.expiredate);
                    int row = cmd.ExecuteNonQuery();
                    con.Close();
                    if (row > 0)
                        MessageBox.Show("Update succesfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void DeleteMedicinesp(Medicine m)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("spDeleteMedicine", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", m.id);
                    int row = cmd.ExecuteNonQuery();
                    con.Close();
                    if (row > 0)
                        MessageBox.Show("Delete succesfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public DataTable ViewMedicinesp()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter())
                    {
                        da.SelectCommand = new SqlCommand("spViewMedicine", con);
                        da.SelectCommand.CommandType = CommandType.StoredProcedure;

                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }

    }
}
