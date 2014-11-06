using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LeisnerWebApp.ServiceReference2;

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
          //  lblVal.Text = listViewPerson.SelectedIndex.ToString();
        }

      

        protected void listViewPerson_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            System.Web.UI.WebControls.Button btn = e.CommandSource as System.Web.UI.WebControls.Button;

            ListViewItem item = btn.NamingContainer as ListViewItem;
            
            Label label1 = item.FindControl("ChildsNameLabel") as Label;
            string kupa = label1.Text;
        }

        protected void btnShowInfo_Click2(object sender, EventArgs e)
        {
            string mail = (string) listViewPerson.SelectedDataKey.Value;
            if (Session[mail] == null)
            { DBAccessServiceClient dbAccess = new DBAccessServiceClient();
              dbAccess.FindPerson(mail);
             }
            
        }

        //private void BindData()
        //{listViewPerson.DataSource= }
    }
}