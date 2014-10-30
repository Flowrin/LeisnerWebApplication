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
        {Login login = new Login();
            List<Person> personList = new List<Person>();
            foreach(Person person in personList )
                if(person.Email == login.UserName && person.Password == login.Password && person.Status ==0 )
            Response.Redirect("DailyInfo.aspx");
        }

        protected void CreateUserWizard1_CreatedUser(object sender, EventArgs e)
        {
            CreateUserWizard uw = new CreateUserWizard();
            string name, childsName, doctor, address, dateOfBirth, password, email,question,answer;
            
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
            question = uw.Question;
            answer = uw.Answer;

            Response.Redirect("FrontPage.aspx");
        }
    }

}