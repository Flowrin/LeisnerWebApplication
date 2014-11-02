using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LeisnerWebApp
{
    public partial class AdminPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnShowInfo_Click(object sender, EventArgs e)
        {
           
        }

        protected void btnShowInfo_Click1(object sender, EventArgs e)
        {
            lblVal.Text = listViewPerson.SelectedIndex.ToString();
        }
    }
}