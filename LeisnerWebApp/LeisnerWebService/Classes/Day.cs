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
        private int hourId;
        private List<Time> _timeList;


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

        public int HourId
        { get { return hourId; } }

        
        public void AddHour(Time myTime)
        {
            List<Time> _timeList = new List<Time>();
            _timeList.Add(myTime);
        }

        public List<Time> GetAllHours()
        {
            if (_timeList == null)
                throw new Exception("No peepee results were found for this person");

            return _timeList;
        }
        
   
    }

}