using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LeisnerWebApp.ServiceReference2;

namespace LeisnerWebApp
{
    public partial class AdminCreateUser : System.Web.UI.Page
    {
        DBAccessServiceClient dbAccess = new DBAccessServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            { }
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
                dbAccess.SavePerson(int.Parse(ddlType.SelectedValue), email, password, name, address, childsName, doctor, dateOfBirth);
                Response.Redirect("FrontPage.aspx");
            }
        }





    }
}