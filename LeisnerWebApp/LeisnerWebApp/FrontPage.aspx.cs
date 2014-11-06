using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LeisnerWebApp.ServiceReference2;

namespace LeisnerWebApp
{
    public partial class FrontPage : System.Web.UI.Page
    {
        static string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        static int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        DBAccessServiceClient dbAccess = new DBAccessServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {




        }



        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("SignUp.aspx");
        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {


        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            
            Person[] personList;
            personList = dbAccess.FindAllPersons();
            string tempUser = txtName.Text;
            string tempPass = txtPassword.Text;
            foreach (Person person in personList)
            {
                if (person.Email == tempUser && person.Password == tempPass && person.Status == 0)
                {
                    Email = person.Email;
                    Id = person.PersonId;
                    Response.Redirect("DailyInfo.aspx");
                    
                }
                else if (person.Email == tempUser && person.Password == tempPass && person.Status == 1)
                {
                    Email = person.Email;
                    Id = person.PersonId;
                    Response.Redirect("AdminPage.aspx");
                    
                }
               // else FailureText.Text = "Invalid username and/or password";

            }
        }


    }

}