using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LeisnerWebApp.App_Code
{
    public class Time
    {
        private int hourId;
        private string hour;




        //Properties
        public int HourId
        {
            get { return hourId; }
            set { hourId = value; }
        }
       

        public string Hour
        {
            get { return hour; }
            set { hour = value; }
        }


    }
}