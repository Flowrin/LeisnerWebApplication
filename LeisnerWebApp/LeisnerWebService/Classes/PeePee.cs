using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LeisnerWebApp.App_Code
{
    public class PeePee
    {
        private string size;
        private int peePeeId;
        private int personId;
        private List<Person> _personList;

        //Properties
        public string Size
        {
            get { return size; }
            set { size = value; }
        }


        public int PeePeeId
        {
            get { return peePeeId; }
            set { peePeeId = value; }
        }

        public int PersonId
        { get { return personId; } }

        List<Person> _personList = new List<Person>();

    }
}