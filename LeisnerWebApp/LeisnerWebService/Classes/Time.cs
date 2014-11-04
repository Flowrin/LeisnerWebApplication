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
        private int peePeeId;
        List<PeePee> _peePeeList;




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

        public int PeePeeId
        { 
            get{return peePeeId;}
        }

        public void AddSize(PeePee myPeepee)
        {
            List<PeePee> _peePeeList = new List<PeePee>();
            _peePeeList.Add(myPeepee);
        }

        public List<PeePee> GetAllPeePees()
        {
            if (_peePeeList == null)
                throw new Exception("No peepee results were found for this person");

            return _peePeeList;
        }
    }
}