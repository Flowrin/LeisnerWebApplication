﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LeisnerWebApp.App_Code;

namespace LeisnerWebApp
{
    public partial class FrontPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            
         
            
        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("DailyInfo.aspx");
        }

     

    }

}