using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Registration_Problem
{
    /// <summary>
    /// Validating the user details with boolean
    /// </summary>
    class Registration
    {
        /// <summary>
        /// UC1-validating Firstname with Caps and minimum 3 character
        /// </summary>
        string REGEX_FIRSTNAME = "^[A-Za-z]{3}$";       
        public bool validateFirstname(string firstname)
        {
            return Regex.IsMatch(firstname, REGEX_FIRSTNAME);
        }
        /// <summary>
        ///UC2- validating lastname with Caps and minimum 3 characters
        /// </summary>
        string REGEX_LASTNAME = "^[A-Za-z]{3}$";
        public bool validateLastname(string lastname)
        {
            return Regex.IsMatch(lastname, REGEX_LASTNAME);
        }
        /// <summary>
        /// UC3-validating the valid email id
        /// </summary>
        string REGEX_EMAIL = "^[A-Za-z0-9.]{3,20}@[a-z]{3,20}.(com)$";
        public bool validateEmail(string Email)
        {
            return Regex.IsMatch(Email, REGEX_EMAIL);
        }
        /// <summary>
        /// UC4-validating the predefined mobile number with country code
        /// </summary>
        string REGEX_PHONE_NUMBER = "^([0\\+[0-9]{1,4})([0-9]{9,10})$";
        public bool validatePhonenumber(string phonenumber)
        {
            return Regex.IsMatch(phonenumber, REGEX_PHONE_NUMBER);
        }
        /// <summary>
        /// UC5-validating the password with minimum 8 characters
        /// </summary>

        string REGEX_PASSWORD = "^[A-Za-z0-9]{8}$";
       
        public bool validatePassword(string password)
        {
            return Regex.IsMatch(password, REGEX_PASSWORD);
           
        }
        /// <summary>
        /// UC6-validating the password with Atleast one uppercase
        /// </summary>
        string REGEX_PASSWORD_UPPERCASE = "^(?=.*[A-Z])(?=.*[a-z]).{8}$";
        public bool validatePassworduppercase(string passworduppercase)
        {
            return Regex.IsMatch(passworduppercase, REGEX_PASSWORD_UPPERCASE);
        }
        /// <summary>
        /// UC7-validating the password with Atleast one numeric
        /// </summary>
        string REGEX_PASSWORD_NUMERIC = "^(?=.*[A-Z])(?=.*[0-9]).{8}$";
        public bool validatePasswordnumeric(string passwordnumeric)
        {
            return Regex.IsMatch(passwordnumeric, REGEX_PASSWORD_NUMERIC);
        }

            /// <summary>
            /// UC8-validating the password with special charecters
            /// </summary>
            string REGEX_PASSWORD_SPCLCHAR = "^(?=.*[A-Z])(?=.*[0-9])(?=.*[~!@#$%^&*()]).{8,}$";
            public bool validatePasswordspclchar(string passwordspclchar)
            {
                return Regex.IsMatch(passwordspclchar, REGEX_PASSWORD_SPCLCHAR);
            }


        }
    }
