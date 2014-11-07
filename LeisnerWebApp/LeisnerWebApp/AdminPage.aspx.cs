using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LeisnerWebApp.ServiceReference2;
using System.Web.UI.DataVisualization.Charting;

namespace LeisnerWebApp
{
    public partial class AdminPage : System.Web.UI.Page
    {

        DBAccessServiceClient dbAccess = new DBAccessServiceClient();

        static string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        protected void Page_Load(object sender, EventArgs e)
        {

        }







        protected void btnShowInfo_Click2(object sender, EventArgs e)
        {
            string mail = (string)listViewPerson.SelectedDataKey.Value;
            if (Session[mail] == null)
            {
                DBAccessServiceClient dbAccess = new DBAccessServiceClient();
                dbAccess.FindPerson(mail);
            }

        }


        protected void Button12_Click1(object sender, EventArgs e)
        {
            Response.Redirect("AdminCreateUser.aspx");
        }

        protected void DisplayChart_Click(object sender, EventArgs e)
        {
            Series series1 = new Series("Series1");
            series1.ChartType = SeriesChartType.Column;
            string personID = "";
            chartStats.Visible = true;
            chartStats.ItemType = "Line";
            Stats[] statsList;
            statsList = dbAccess.GetStats();
            foreach (Person person in dbAccess.FindAllPersons())
            {
                if (ddlName.SelectedValue == person.Name)
                { personID = person.Email; }
            }

            int weekId = ddlWeek.SelectedIndex + 1;

            int mon = 0, tue = 0, wed = 0, thu = 0, fri = 0, sat = 0, sun = 0;
            foreach (Stats stat in statsList)
            {
                if (stat.Email == personID && stat.Week_Id == weekId)
                {
                    if (stat.Day_of_week == "Monday")
                    {
                        mon += stat.Pee_size;
                        lblMondayH.Text += stat.Hour + "\r\n" + "/";
                    }

                    if (stat.Day_of_week == "Tuesday")
                    {
                        tue += stat.Pee_size;
                        lblTuesdayH.Text += stat.Hour + "\r\n" + "/";
                    }

                    if (stat.Day_of_week == "Wednesday")
                    {
                        wed += stat.Pee_size;
                        lblWednesdayH.Text += stat.Hour + "\r\n" + "/";
                    }

                    if (stat.Day_of_week == "Thursday")
                    {
                        thu += stat.Pee_size;
                        lblThurdayH.Text += stat.Hour + "\r\n" + "/";
                    }

                    if (stat.Day_of_week == "Friday")
                    {
                        fri += stat.Pee_size;
                        lblFridayH.Text += stat.Hour + "\r\n" + "/";
                    }

                    if (stat.Day_of_week == "Saturday")
                    {
                        sat += stat.Pee_size;
                        lblSaturdayH.Text += stat.Hour + "\r\n" + "/";
                    }

                    if (stat.Day_of_week == "Sunday")
                    {
                        sun += stat.Pee_size;
                        lblSundayH.Text += stat.Hour + "\r\n" + "/";
                    }
                }

            }
            lblMonday.Text = mon.ToString();
            lblTuesday.Text = tue.ToString();
            lblWednesday.Text = wed.ToString();
            lblThursday.Text = thu.ToString();
            lblFriday.Text = fri.ToString();
            lblSaturday.Text = sat.ToString();
            lblSunday.Text = sun.ToString();


            string[] seriesArray = { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };
            int[] pointsArray = { mon, tue, wed, thu, fri, sat, sun };
            this.chartStats.Titles.Add("Statistics");
            for (int i = 0; i < seriesArray.Length; i++)
            {
                // Add series.
                Series series = this.chartStats.Series.Add(seriesArray[i]);

                // Add point.
                series.Points.Add(pointsArray[i]);
                series.Label = seriesArray[i];

            }
        }

        protected void UpdateUser_Click(object sender, EventArgs e)
        {
            name = listViewPerson.SelectedDataKey.Value.ToString();
            Response.Redirect("AdminUpdateUser.aspx");

        }

       

        protected void DeleteUser_Click1(object sender, EventArgs e)
        {
            name = listViewPerson.SelectedDataKey.Value.ToString();

            foreach (Person person in dbAccess.FindAllPersons())
            {
                if (name == person.Name)
                {
                    dbAccess.DeletePerson(person.PersonId);
                    Response.Write("<script>alert(" + name + "'has been deleted');</script>");
                }
            }
        }
    }
}



