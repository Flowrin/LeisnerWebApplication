using System;
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
      


        public Person()
        {
            //this.personId = personId;
            //this.status = 0;
            //this.email = email;
            //this.password = password;
            //this.name = name;
            //this.address = address;
            //this.childName = childName;
            //this.doctor = doctor;
            //this.dateOfBirth = dateOfBirth;
        }



        //Properties

        public int PersonId
        {
            get { return personId; }
            set { personId = value; }
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
    }
}