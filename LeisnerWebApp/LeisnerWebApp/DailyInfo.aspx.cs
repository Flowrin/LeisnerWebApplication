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
        DBAccessServiceClient dbAccess = new DBAccessServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            int weekId, dayId, sizeId, hourId,personId;
            weekId = dropDownWeek.SelectedIndex;
            dayId = dropDownDay.SelectedIndex;
            sizeId = dropDownSize.SelectedIndex;
            hourId = dropDownHour.SelectedIndex;
        }

        protected void btnChart_Click(object sender, EventArgs e)
        {

        }
  
    }
}