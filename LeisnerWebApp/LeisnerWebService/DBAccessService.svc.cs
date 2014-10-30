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
    public class Service1 : IDBAccessService
    {
        private const string CONNECTION_STRING = @"Data Source=ealdb1.eal.local;Initial Catalog=EJL12_DB;Persist Security Info=True;User ID=ejl12_usr;Password=Baz1nga12";
        Person myPerson ;
        public void Find()
        {
            SqlConnection con = new SqlConnection(CONNECTION_STRING);
            SqlCommand cmd = new SqlCommand();
            
            cmd.Connection = con;

            cmd.CommandText = "Select * From " + "Person"+ " Where PersonID = @PersonID";

            SqlParameter par = new SqlParameter("@ItemNo", SqlDbType.Int);
            par.Value = myPerson.PersonId;
            cmd.Parameters.Add(par);

            con.Open();
            SqlDataReader datareader = cmd.ExecuteReader();
            datareader.Read();

            //this.Description = (string)datareader["Description"];
            //this.Price = (double)datareader["Price"];
            //this.ItemsInStock = (int)datareader["ItemsInStock"];
            //this.Version = (int)datareader["Version"];

            con.Close();
        }


        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
