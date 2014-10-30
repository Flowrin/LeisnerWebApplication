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
           
            dbAccess.SavePerson(0,"aaaa","aaa","sdsd","djdjd","sdsds","etrtrt","30.11.1993");
            
        }

        protected void CreateUserWizard1_CreatedUser(object sender, EventArgs e)
        {
            
        }
    }

}