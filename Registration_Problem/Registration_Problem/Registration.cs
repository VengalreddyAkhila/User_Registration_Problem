using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Registration_Problem
{
    class Registration
    {
        string REGEX_FIRSTNAME = "^[A-Za-z]{3,10}$";
        public bool validateFirstname(string firstname)
        {
            return Regex.IsMatch(firstname, REGEX_FIRSTNAME);
        }
    }
}
