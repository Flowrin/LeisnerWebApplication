using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LeisnerWebApp.ServiceReference1;

namespace LeisnerWebApp
{
    public partial class FrontPage : System.Web.UI.Page
    {
        DBAccessServiceClient dbAccess = new DBAccessServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {

            
         
            
        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
           
            Response.Redirect("DailyInfo.aspx");
        }

        protected void CreateUserWizard1_CreatedUser(object sender, EventArgs e)
        {
            CreateUserWizard uw = new CreateUserWizard();
            string name, childsName, doctor, address, dateOfBirth, password, email;
            
            TextBox childNameTextBox =
    (TextBox)CreateUserWizard1.CreateUserStep.ContentTemplateContainer.FindControl("ChildName");
            TextBox doctorTextBox =
    (TextBox)CreateUserWizard1.CreateUserStep.ContentTemplateContainer.FindControl("Doctor");
            TextBox addressTextBox =
    (TextBox)CreateUserWizard1.CreateUserStep.ContentTemplateContainer.FindControl("Address");
            TextBox dateOfBirthTextBox =
    (TextBox)CreateUserWizard1.CreateUserStep.ContentTemplateContainer.FindControl("ChildDoB");
            
            name = uw.UserName;
            email = uw.Email;
            childsName = childNameTextBox.Text;
            password = uw.Password;
            doctor = doctorTextBox.Text;
            address = addressTextBox.Text;
            dateOfBirth = dateOfBirthTextBox.Text;
            dbAccess.SavePerson(0,email,password,name,address,childsName,doctor,dateOfBirth);

            Response.Redirect("FrontPage.aspx");
        }
    }

}