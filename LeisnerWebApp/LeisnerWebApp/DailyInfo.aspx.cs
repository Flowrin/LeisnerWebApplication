using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LeisnerWebApp.ServiceReference1;

namespace LeisnerWebApp
{
    public partial class DailyInfo : System.Web.UI.Page
    {
        FrontPage fp = new FrontPage();
        DBAccessServiceClient dbAccess = new DBAccessServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            int weekId, dayId, sizeId, hourId,personId;
            weekId = dropDownWeek.SelectedIndex+1;
            dayId = dropDownDay.SelectedIndex+1;
            sizeId = dropDownSize.SelectedIndex+1;
            hourId = dropDownHour.SelectedIndex+1;
            personId = fp.Id;
            dbAccess.SaveInfo(personId, weekId, hourId, dayId, sizeId);
        }

        protected void btnChart_Click(object sender, EventArgs e)
        {
            Stats_Chart.Visible = true;
        }
  
    }
}