﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LeisnerWebApp.App_Code
{
    public class Person
    {
        private int personId;
        private int status;
        private string email;
        private string password;
        private string name;
        private string address;
        private string childName;
        private string doctor;
        private string dateOfBirth;
        private int weekID;

        

        private List<Week> weeks;


        #region Constructors
        public Person(int personId, int status, string email, string password, 
            string name, string address, string childName, string dateOfBirth, string doctor)
        {
            this.personId = personId;
            this.status = 0;
            this.email = email;
            this.password = password;
            this.name = name;
            this.address = address;
            this.childName = childName;
            this.doctor = doctor;
            this.dateOfBirth = dateOfBirth;
            this.weeks = new List<Week>();
        }

        public Person(string email, string password)
        {
            this.email = email;
            this.password = password;
        }

        public Person()
        {
            // TODO: Complete member initialization
        }

        //public Person(int personId, List<PeePee> peepees)
        //{
        //    this.personId = personId;
        //    peepees = new List<PeePee>();
        //}
        #endregion

        #region Properties
        public int PersonId
        {
            get { return personId; }
            set { personId = value; }
        }

        public int WeekID
        {
            get { return weekID; }
            set { weekID = value; }
        }
        public int Status
        {
            get { return status; }
            set { status = value; }
        }


        public string Email
        {
            get { return email; }
            set { email = value; }
        }


        public string Password
        {
            get { return password; }
            set { password = value; }
        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        public string Address
        {
            get { return address; }
            set { address = value; }
        }


        public string ChildName
        {
            get { return childName; }
            set { childName = value; }
        }


        public string Doctor
        {
            get { return doctor; }
            set { doctor = value; }
        }


        public string DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }
        #endregion

        public void AddPeePee(Week myWeek)
        {
            weeks.Add(myWeek);
        }

        public List<Week> GetAllWeeks()
        {
            if (weeks == null)
                throw new Exception("No peepee results were found for this person");

            return weeks;
        }
    }
}