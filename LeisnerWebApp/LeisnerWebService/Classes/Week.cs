using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LeisnerWebApp.App_Code
{
    public class Week
    {

        private int weekId;
        private string weekName;
        private int dayId;
        List<Day> _dayList;



        //Properties
        public int WeekId
        {
            get { return weekId; }
            set { weekId = value; }
        }
       

        public string WeekName
        {
            get { return weekName; }
            set { weekName = value; }
        }

        public int DayId
        { get { return dayId; } }

        
        
        public void AddDay(Day myDay)
        {
            List<Day> _dayList = new List<Day>();
            _dayList.Add(myDay);
        }

        public List<Day> GetAllDays()
        {
            if (_dayList == null)
                throw new Exception("No peepee results were found for this person");

            return _dayList;
        }

     
    }
}