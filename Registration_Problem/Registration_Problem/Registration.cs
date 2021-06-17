using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Registration_Problem
{
    class Registration
    {
        string REGEX_FIRSTNAME = "^[A-Za-z]{3}$";
        string REGEX_LASTNAME = "^[A-Za-z]{3}$";
        string REGEX_EMAIL = "^[A-Za-z0-9]{3,10}@[A-Za-z]{3,10}.(com|co.in|co.uk)$";
        string REGEX_PHONE_NUMBER = "^([0\\+[0-9]{1,4})([0-9]{9,10})$";
        string REGEX_PASSWORD = "^[A-Za-z0-9]{8,10}$";
        public bool validateFirstname(string firstname)
        {
            return Regex.IsMatch(firstname, REGEX_FIRSTNAME);
        }
        public bool validateLastname(string lastname)
        {
            return Regex.IsMatch(lastname, REGEX_LASTNAME);
        }
        public bool validateEmail(string Email)
        {
            return Regex.IsMatch(Email, REGEX_EMAIL);
        }
        public bool validatePhonenumber(string phonenumber)
        {
            return Regex.IsMatch(phonenumber, REGEX_PHONE_NUMBER);
        }
        public bool validatePassword(string password)
        {
            return Regex.IsMatch(password, REGEX_PASSWORD);
        }
    }
}
