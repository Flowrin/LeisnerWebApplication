using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LeisnerWebApp.ServiceReference2;

namespace LeisnerWebApp
{
    public partial class UserUpdateProfile : System.Web.UI.Page
    {
        DBAccessServiceClient dbAccess = new DBAccessServiceClient();
        FrontPage fp = new FrontPage();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                fillBoxes();
            }
        }
        private void fillBoxes()
        {
            foreach (Person person in dbAccess.FindAllPersons())
            {
                if (fp.Email == person.Email)
                {
                    txtName.Text = person.Name;
                    txtEmail.Text = person.Email;
                    txtChildName.Text = person.ChildName;
                    txtPass.Text = person.Password;
                    txtConfirmPass.Text = person.Password;
                    txtAddress.Text = person.Address;
                    txtDoctor.Text = person.Doctor;
                    txtBirthDate.Text = person.DateOfBirth;
                    ddlType.SelectedIndex = person.Status;
                }
            }
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string email = txtEmail.Text;
            string childsName = txtChildName.Text;
            string password = txtPass.Text;
            string confirmpass = txtConfirmPass.Text;
            string address = txtAddress.Text;
            string doctor = txtDoctor.Text;
            string dateOfBirth = txtBirthDate.Text;


            if (password == confirmpass)
            {
                dbAccess.UpdatePerson(email, password, name, address, doctor, childsName, dateOfBirth, int.Parse(ddlType.SelectedValue));
                Response.Redirect("DailyInfo.aspx");
            }
        }

       
    }
}