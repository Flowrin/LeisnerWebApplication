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
    public partial class DailyInfo : System.Web.UI.Page
    {
        FrontPage fp = new FrontPage();
        DBAccessServiceClient dbAccess = new DBAccessServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            int weekId, dayId, sizeId, hourId, personId;
            weekId = dropDownWeek.SelectedIndex + 1;
            dayId = dropDownDay.SelectedIndex + 1;
            sizeId = dropDownSize.SelectedIndex + 1;
            hourId = dropDownHour.SelectedIndex + 1;
            personId = fp.Id;
            dbAccess.SaveInfo(personId, weekId, hourId, dayId, sizeId);
        }

        protected void btnChart_Click(object sender, EventArgs e)
        {
            Series series1 = new Series("Series1");
            series1.ChartType = SeriesChartType.Column;
            
           chartStats.Visible = true;
           chartStats.ItemType = "Line";
            Stats[] statsList;
            statsList = dbAccess.GetStats();
            string personID = fp.Email;
            int weekId = dropDownWeek.SelectedIndex + 1;
            //this.BindData();
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

            chartStats.Legends.Add(new Legend("Week Day") { Docking = Docking.Right });
            chartStats.Legends.Add(new Legend("Amount") {Docking=Docking.Right});
            
            
            string[] seriesArray = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            string[] amountArray = {"1 - extra small","2 - small", "3 - medium", "4 - large", "5 - extra large"};
            

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
            for(int i=0;i<amountArray.Length;i++)
            {
            Series amount = this.chartStats.Series.Add(amountArray[i]);
             
            }
        }
            }
        }
    
