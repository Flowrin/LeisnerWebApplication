using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LeisnerWebApp.App_Code
{
    public class Day
    {
        private int dayId;
        private string dayName;



        //Properties
        public int DayId
        {
            get { return dayId; }
            set { dayId = value; }
        }


        public string DayName
        {
            get { return dayName; }
            set { dayName = value; }
        }
   
    }

}