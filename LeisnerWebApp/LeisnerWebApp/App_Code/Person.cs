using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LeisnerWebApp.App_Code
{
    public class Person
    {
        public int personId { get; private set; }
        public int status;
        public string email { get; set; }
        public string password { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string childName { get; set; }
        public string doctor { get; set; }
        public string dateOfBirth { get; set; }


        public Person(int personId, int status, string email, string password, string name, string address, string childName, string doctor, string dateOfBirth)
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
        }
    }
}