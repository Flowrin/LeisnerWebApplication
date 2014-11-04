using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LeisnerWebService.Classes
{
    public class Stats
    {
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        private int week_Id;

        public int Week_Id
        {
            get { return week_Id; }
            set { week_Id = value; }
        }
        private string _hour;

        public string Hour
        {
            get { return _hour; }
            set { _hour = value; }
        }
        private string _pee_size;

        public string Pee_size
        {
            get { return _pee_size; }
            set { _pee_size = value; }
        }
        private string day_of_week;

        public string Day_of_week
        {
            get { return day_of_week; }
            set { day_of_week = value; }
        }

        // we don't need a constructor!

        



    }
}