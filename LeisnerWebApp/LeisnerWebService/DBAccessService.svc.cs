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
using LeisnerWebService.Classes;

using System.Data.Common;
using System.Reflection.Emit;
using System.Reflection;

namespace LeisnerWebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class DBAccessService : IDBAccessService
    {
        private const string CONNECTION_STRING = @"Data Source=ealdb1.eal.local;Initial Catalog=EJL12_DB;Persist Security Info=True;User ID=ejl12_usr;Password=Baz1nga12";
        Person _person;
        Time _time;
        PeePee _peePee;
        Week _week;
        Day _day;

        #region PersonMethods

        public void FindPerson()
        {
            SqlConnection con = new SqlConnection(CONNECTION_STRING);
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;

            cmd.CommandText = "Select * From " + "Person" + " Where PersonID = @PersonID";

            SqlParameter par = new SqlParameter("@PersonID", SqlDbType.Int);
            par.Value = _person.PersonId;
            cmd.Parameters.Add(par);
            _person = new Person();
            con.Open();
            SqlDataReader datareader = cmd.ExecuteReader();
            datareader.Read();

            _person.Address = (string)datareader["Address"];
            _person.ChildName = (string)datareader["ChildsName"];
            _person.DateOfBirth = (string)datareader["DateOfBirth"];
            _person.Doctor = (string)datareader["Doctor"];
            _person.Email = (string)datareader["Email"];
            _person.Name = (string)datareader["Name"];
            _person.Password = (string)datareader["Password"];
            _person.PersonId = (int)datareader["PersonID"];
            _person.Status = (int)datareader["Status"];
            con.Close();
        }

        public List<Person> FindAllPersons()
        {
            List<Person> myPersonList = new List<Person>();
            Person _person = new Person();

            SqlConnection con = new SqlConnection(CONNECTION_STRING);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "Select * From " + "Person";

            con.Open();
            SqlDataReader datareader = cmd.ExecuteReader();

            while (datareader.Read())
            {
                _person = new Person();
                _person.Address = (string)datareader["Address"];
                _person.ChildName = (string)datareader["ChildsName"];
                _person.DateOfBirth = (string)datareader["DateOfBirth"];
                _person.Doctor = (string)datareader["Doctor"];
                _person.Email = (string)datareader["Email"];
                _person.Name = (string)datareader["Name"];
                _person.Password = (string)datareader["Password"];
                _person.PersonId = (int)datareader["PersonID"];
                _person.Status = (int)datareader["Status"];
                myPersonList.Add(_person);
            }

            con.Close();

            return myPersonList;
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
        #endregion

        #region TimeMethods

        public void FindTime()
        {
            SqlConnection con = new SqlConnection(CONNECTION_STRING);
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;

            cmd.CommandText = "Select * From " + "Time" + " Where HourID = @HourID";

            SqlParameter par = new SqlParameter("@HourID", SqlDbType.Int);
            par.Value = _time.HourId;
            cmd.Parameters.Add(par);
            _time = new Time();
            con.Open();
            SqlDataReader datareader = cmd.ExecuteReader();
            datareader.Read();

            _time.HourId = (int)datareader["HourID"];
            _time.Hour = (string)datareader["Hour"];
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

        public void SaveTime(string Hour)
        {
            SqlConnection con = new SqlConnection(CONNECTION_STRING);

            string sqlstring = ("Insert into Time ( Hour) values (@Hour)");
            SqlCommand cmd = new SqlCommand(sqlstring, con);
            cmd.Parameters.AddWithValue("@Hour", Hour);

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
        #endregion

        #region CheckLogIn
        public void CheckLogIn(string email, string password)
        {
            SqlConnection con = new SqlConnection(CONNECTION_STRING);
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;

            cmd.CommandText = "Select * From " + "Person" + " Where PersonID = @PersonID";

            SqlParameter par = new SqlParameter("@Password, @Email", SqlDbType.NVarChar);
            par.Value = _person.Email;
            par.Value = _person.Password;
            cmd.Parameters.Add(par);
            _person = new Person(email, password);
            con.Open();
            SqlDataReader datareader = cmd.ExecuteReader();
            datareader.Read();


            _person.Password = (string)datareader["Password"];
            _person.Email = (string)datareader["Email"];
            con.Close();

        }

        #endregion

        #region PeePeeMethods

        public void GetPeePee() // find method
        {
            SqlConnection con = new SqlConnection(CONNECTION_STRING);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select * From " +  "PeePee" + " Where PeePeeID = @PeePeeID";

            SqlParameter par = new SqlParameter("@PeePeeID", SqlDbType.Int);
            par.Value = _peePee.PeePeeId;
            cmd.Parameters.Add(par);
            _peePee = new PeePee();
            con.Open();
            SqlDataReader datareader = cmd.ExecuteReader();
            datareader.Read();

            _peePee.PeePeeId = (int)datareader["PeePeeID"];
            _peePee.Size = (string)datareader["Size"];
            con.Close();

        }
        #endregion

        #region WeekMethods

        public void FindWeek()
        {
            SqlConnection con = new SqlConnection(CONNECTION_STRING);
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;

            cmd.CommandText = "Select * From " + "Week" + " Where WeekID = @WeekID";

            SqlParameter par = new SqlParameter("@WeekID", SqlDbType.Int);
            par.Value = _week.WeekId;
            cmd.Parameters.Add(par);
            _week = new Week();
            con.Open();
            SqlDataReader datareader = cmd.ExecuteReader();
            datareader.Read();

            _week.WeekId = (int)datareader["WeekID"];
            _week.WeekName = (string)datareader["WeekName"];
            con.Close();
        }
        #endregion

        #region DayMethods

        public void FindDay()
        {
            SqlConnection con = new SqlConnection(CONNECTION_STRING);
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;

            cmd.CommandText = "Select * From " + "Day" + " Where DayID = @DayID";

            SqlParameter par = new SqlParameter("@DayID", SqlDbType.Int);
            par.Value = _day.DayId;
            cmd.Parameters.Add(par);
            _day = new Day();
            con.Open();
            SqlDataReader datareader = cmd.ExecuteReader();
            datareader.Read();

            _day.DayId = (int)datareader["DayID"];
            _day.DayName = (string)datareader["DayName"];
            con.Close();
        }
        #endregion

        public void SaveInfo(Person personId, Week weekId, Time hourId, Day dayId, PeePee peePeeId)
        {
            SqlConnection con = new SqlConnection(CONNECTION_STRING);

            string sqlstring = ("Insert into Common (PersonID, WeekID, HourID, DayID, PeePeeID) values (@PersonID, @WeekID, @HourID, @DayID, @PeePeeID)");
            SqlCommand cmd = new SqlCommand(sqlstring, con);
            cmd.Parameters.AddWithValue("@PersonID", personId);
            cmd.Parameters.AddWithValue("@WeekID", weekId);
            cmd.Parameters.AddWithValue("@HourID", hourId);
            cmd.Parameters.AddWithValue("@DayID", dayId);
            cmd.Parameters.AddWithValue("@PeePeeID", peePeeId);
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
        public List<Common> FindInfo(int PersonId)
        {
            List<Common> myPersonList = new List<Common>();
            Common _common = new Common(PersonId);
            SqlConnection con = new SqlConnection(CONNECTION_STRING);
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;

            cmd.CommandText = "Select * From " + "Common" + " Where PersonId = @PersonID";

            SqlParameter par = new SqlParameter("@PersonID", SqlDbType.Int);
            par.Value = _person.PersonId;
            cmd.Parameters.Add(par);
            _person = new Person();
            con.Open();
            SqlDataReader datareader = cmd.ExecuteReader();
            while (datareader.Read())
            {
                
                _common.PersonId = (int)datareader["PersonID"];
               _common.WeekId = (int)datareader["WeekID"];
                _common.DayId = (int)datareader["DayID"];
                _common.HourId = (int)datareader["HourID"];
                _common.SizeId = (int)datareader["SizeID"];
                
                myPersonList.Add(_common);
            }
            con.Close();

            return myPersonList;
        }

        public void SaveHour(string Hour)
        {
            SqlConnection con = new SqlConnection(CONNECTION_STRING);

            string sqlstring = ("Insert into Time (Hour) values (@Hour)");
            SqlCommand cmd = new SqlCommand(sqlstring, con);

            cmd.Parameters.AddWithValue("@Hour", Hour);


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



        //public void FindInfo(Person personId, string size, int peePeeId)
        //{
//            public DataSet SelectOne(int id)
//        {
//            SqlConnection conn = new SqlConnection(CONNECTION_STRING);
//            DataSet result = new DataSet();
//            using (DbCommand command = conn.CreateCommand())
//            {
//                command.CommandText = @"
//            select * from table1
//            select * from table2
//                    ";

//                    var param = ParameterBuilder.CreateByKey(command, "ID", id, null);
//                command.Parameters.Add(param);

//             conn.Open();
//                using (DbDataReader reader = command.ExecuteReader())
//        {   
//            result.MainTable.Load(reader);
//            reader.NextResult();
//            result.SecondTable.Load(reader);
//            // ...
//        }
//        conn.Close();

//    }
//    return result;
//}


            //SqlConnection con = new SqlConnection(CONNECTION_STRING);
            //SqlCommand cmd = new SqlCommand();
            //cmd.Connection = con;
            //cmd.CommandText = "Select * From " + "Person" + " Where PersonID = @PersonID" + "PeePee" + " Where PeePeeID = @PeePeeID" ;

            //cmd.Parameters.Add("@PeePeeID", SqlDbType.Int, 0, "PeePeeID");
            //cmd.Parameters["@PeePeeID"].Direction = ParameterDirection.Output;

            //cmd.Parameters.AddWithValue("@PersonID", _person.PersonId);
            //cmd.Parameters.AddWithValue("@Size", size);

            //int id;
            //try
            //{
            //    cmd.ExecuteNonQuery();
            //    id = int.Parse(cmd.Parameters["@PeePeeID"].Value.ToString());
            //}
            //catch (Exception ex)
            //{
            //    throw new Exception("Could not add a result" + ex.Message);
            //}

            //peePeeId.ToString();
        
        }
        
        }
   
