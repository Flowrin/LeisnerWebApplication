using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LeisnerWebService.Classes
{
    public class Common
    {
        int personId, weekId, dayId, hourId, sizeId;
        public Common(int personId)
        {
            this.personId = personId;
            
        }
        public int SizeId
        {
            get { return sizeId; }
            set { sizeId = value; }
        }

        public int HourId
        {
            get { return hourId; }
            set { hourId = value; }
        }

        public int DayId
        {
            get { return dayId; }
            set { dayId = value; }
        }

        public int WeekId
        {
            get { return weekId; }
            set { weekId = value; }
        }

        public int PersonId
        {
            get { return personId; }
            set { personId = value; }
        }
    }
}