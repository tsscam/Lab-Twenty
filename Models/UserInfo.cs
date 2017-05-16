using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LabTwenty.Models
{
    public class UserInfo
    {
        private string FirstName;
        private string LastName;
        private string Email;
        private string Phone;
        private string Password;

        public string UserFirstName 
        {
            get
            {
                return FirstName;
            }

            set
            {
                FirstName = value;
            }
        }

        public string UserLastName          
        {
            get
            {
                return LastName;
            }

            set
            {
                LastName = value;
            }
        }

        public string UserEmail
        {
            get
            {
                return Email;
            }

            set
            {
                Email = value;
            }
        }

        public string UserPhone
        {
            get
            {
                return Phone;
            }

            set
            {
                Phone = value;
            }
        }

        public string UserPassword
        {
            get
            {
                return Password;
            }

            set
            {
                Password = value;
            }
        }
        public UserInfo():this("","","","","")
        {
            //FirstName = "";
            //LastName = "";
            //Email = "";
            //Phone = "";
            //Password = "";
        }

        public UserInfo(string firstName, string lastName, string email, string phone, string password)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
            Password = password;
        }
    }
}