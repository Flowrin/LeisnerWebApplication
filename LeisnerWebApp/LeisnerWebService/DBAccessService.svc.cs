using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using LeisnerWebApp.App_Code;

namespace LeisnerWebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class DBAccessService : IDBAccessService
    {
        private const string CONNECTION_STRING = @"Data Source=ealdb1.eal.local;Initial Catalog=EJL12_DB;Persist Security Info=True;User ID=ejl12_usr;Password=Baz1nga12";
        Person myPerson;
        Time myTime;
        public void FindPerson()
        {
            SqlConnection con = new SqlConnection(CONNECTION_STRING);
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;

            cmd.CommandText = "Select * From " + "Person" + " Where PersonID = @PersonID";

            SqlParameter par = new SqlParameter("@PersonID", SqlDbType.Int);
            par.Value = myPerson.PersonId;
            cmd.Parameters.Add(par);
            myPerson = new Person();
            con.Open();
            SqlDataReader datareader = cmd.ExecuteReader();
            datareader.Read();

            myPerson.Address = (string)datareader["Address"];
            myPerson.ChildName = (string)datareader["ChildsName"];
            myPerson.DateOfBirth = (string)datareader["DateOfBirth"];
            myPerson.Doctor = (string)datareader["Doctor"];
            myPerson.Email = (string)datareader["Email"];
            myPerson.Name = (string)datareader["Name"];
            myPerson.Password = (string)datareader["Password"];
            myPerson.PersonId = (int)datareader["PersonID"];
            myPerson.Status = (int)datareader["Status"];
            con.Close();
        }

        public List<Person> FindAllPersons()
        {
            List<Person> myPersonList = new List<Person>();
            Person myPerson = new Person();

            SqlConnection con = new SqlConnection(CONNECTION_STRING);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "Select * From " + "Person";

            con.Open();
            SqlDataReader datareader = cmd.ExecuteReader();

            while (datareader.Read())
            {
                myPerson = new Person();
                myPerson.Address = (string)datareader["Address"];
                myPerson.ChildName = (string)datareader["ChildsName"];
                myPerson.DateOfBirth = (string)datareader["DateOfBirth"];
                myPerson.Doctor = (string)datareader["Doctor"];
                myPerson.Email = (string)datareader["Email"];
                myPerson.Name = (string)datareader["Name"];
                myPerson.Password = (string)datareader["Password"];
                myPerson.PersonId = (int)datareader["PersonID"];
                myPerson.Status = (int)datareader["Status"];
                myPersonList.Add(myPerson);
            }

            con.Close();

            return myPersonList;
        }
        public void FindTime()
        {  
            SqlConnection con = new SqlConnection(CONNECTION_STRING);
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;

            cmd.CommandText = "Select * From " + "Time" + " Where HourID = @HourID";

            SqlParameter par = new SqlParameter("@HourID", SqlDbType.Int);
            par.Value = myTime.HourId;
            cmd.Parameters.Add(par);
            myTime = new Time();
            con.Open();
            SqlDataReader datareader = cmd.ExecuteReader();
            datareader.Read();

            myTime.HourId = (int)datareader["HourID"];
            myTime.Hour = (string)datareader["Hour"];
            con.Close();
        }
        public List<Time> FindAllTimes()
        {
            List<Time> myTimeList = new List<Time>();
            Time myTime = new Time();

            SqlConnection con = new SqlConnection(CONNECTION_STRING);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "Select * From " + "Time";

            con.Open();
            SqlDataReader datareader = cmd.ExecuteReader();

            while (datareader.Read())
            {
                myTime.HourId = (int)datareader["HourID"];
                myTime.Hour = (string)datareader["Hour"];
                myTimeList.Add(myTime);
            }

            con.Close();

            return myTimeList;
        }
        public void SavePerson(int Status, string Email, string Password, string Name, string Address, string ChildsName, string Doctor, string DateOfBirth)
        {
            SqlConnection con = new SqlConnection(CONNECTION_STRING);

            string sqlstring = ("Insert into Person ( Status,  Email,  Password,  Name,  Address,  ChildsName,  Doctor,  DateOfBirth) values (@Status, @Email, @Password, @Name,@Address, @ChildsName, @Doctor, @DateOfBirth)");
            SqlCommand cmd = new SqlCommand(sqlstring, con);
            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@Address", Address);
            cmd.Parameters.AddWithValue("@Doctor", Doctor);
            cmd.Parameters.AddWithValue("@ChildsName", ChildsName);
            cmd.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@Password", Password);
            cmd.Parameters.AddWithValue("@Status", Status);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }
    }
}
