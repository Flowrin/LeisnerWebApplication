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
            Stats[] statsList;
            statsList = dbAccess.GetStats();
            string personID = fp.Email;
            int weekId = dropDownWeek.SelectedIndex + 1;
            int mon=0, tue=0, wed=0, thu=0, fri=0, sat=0, sun=0;
            foreach (Stats stat in statsList)
            {
                if (stat.Email == personID && stat.Week_Id == weekId)
                {
                    if (stat.Day_of_week == "Monday")
                    { mon += stat.Pee_size; }
                    if (stat.Day_of_week == "Tuesday")
                    { tue += stat.Pee_size; }
                    if (stat.Day_of_week == "Wednesday")
                    { wed += stat.Pee_size; }
                    if (stat.Day_of_week == "Thursday")
                    { thu += stat.Pee_size; }
                    if (stat.Day_of_week == "Friday")
                    { fri += stat.Pee_size; }
                    if (stat.Day_of_week == "Saturday")
                    { sat += stat.Pee_size; }
                    if (stat.Day_of_week == "Sunday")
                    { sun += stat.Pee_size; }
                }
            }
             Response.Write("<script>alert("+mon+tue+wed+thu+fri+sat+sun+");</script>");


        }
  
    }
}