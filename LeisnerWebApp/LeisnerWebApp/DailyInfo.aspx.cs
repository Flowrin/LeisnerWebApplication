﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LeisnerWebApp
{
    public partial class DailyInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnChart_Click(object sender, EventArgs e)
        {
            Chart1.Visible = true;
        }

  
    }
}