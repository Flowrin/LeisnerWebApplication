using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LeisnerWebApp.App_Code
{
    public class Time
    {
        public int hourId { get; }
        public string hour { get; set; }

        public Time(int hourId,string hour)
        {
            this.hour = hour;
            this.hourId = hourId;
        }
    }
}