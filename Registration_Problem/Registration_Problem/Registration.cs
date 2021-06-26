using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Registration_Problem
{
    /// <summary>
    /// Validating the user details with boolean and exceptions
    /// </summary>
    public class Registration
    {
        /// <summary>
        /// UC1-validating Firstname with Caps and minimum 3 character
        /// UC2-validating Lastname with caps and minimum 3 cahracters
        /// validate using custom exceptions
        /// </summary>
        public bool ValidateFirstName(string firstName)
        {
            string ValidateName = "^[A-Za-z]{3}$";
            try
            {
                if (string.IsNullOrEmpty(ValidateName))
                {
                    throw new RegexCustomException(RegexCustomException.InvalidUserDetails.EMPTY_MESSAGE, "Name should not be empty");
                }
                if (Regex.IsMatch(firstName, ValidateName))
                {
                    Console.WriteLine(" valid firstname");
                    return true;
                }
            }
            catch (NullReferenceException)
            {
                throw new RegexCustomException(RegexCustomException.InvalidUserDetails.NULL_MESSAGE, "Name should not be null");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }
        
        /// <summary>
        /// UC3-validating the valid email id 
        /// validate using custom exceptions
        /// </summary>        
        public bool ValidateEmail(string Email)
        {
            string ValidateEmail = "^[A-Za-z0-9]+[.+-]{0,1}[0-9a-zA-Z]+@[A-Za-z]+[.][A-Za-z]{2,3}(.[a-zA-Z]{2,3}){0,1}$";
            try
            {
                if (string.IsNullOrEmpty(ValidateEmail))
                {
                    throw new RegexCustomException(RegexCustomException.InvalidUserDetails.EMPTY_MESSAGE, "Email should not be empty");
                }
                if (Regex.IsMatch(Email, ValidateEmail))
                {
                    Console.WriteLine(" valid email id");
                    return true;
                }
            }
            catch (NullReferenceException)
            {
                throw new RegexCustomException(RegexCustomException.InvalidUserDetails.NULL_MESSAGE, "Email should not be null");
            }
        
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }
        /// <summary>
        /// UC4-validating the predefined mobile number with country code
        /// validate using custom exception
        /// </summary>       
        public bool ValidatePhonenumber(string phonenumber)
        {
            string ValidatePhonenumber = "^[0-9]{1,4}\\s([0-9]{10,12})$";
            try
            {
                if (string.IsNullOrEmpty(ValidatePhonenumber))
                {
                    throw new RegexCustomException(RegexCustomException.InvalidUserDetails.EMPTY_MESSAGE, "phonenumber should not be empty");
                }
                if (Regex.IsMatch(phonenumber, ValidatePhonenumber))
                {
                    Console.WriteLine(" valid phonenumber");
                    return true;
                }
            }
            catch (NullReferenceException)
            {
                throw new RegexCustomException(RegexCustomException.InvalidUserDetails.NULL_MESSAGE, "phonenumber should not be null");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }
        /// <summary>
        /// UC5-validating the password with minimum 8 characters
        /// UC6-Validating the password with atleast one uppercase
        /// Uc7-validating the password with atleast one numeric
        /// UC8-validating the password with spcl cahracters
        /// validate using custom exception
        /// </summary>       
        public bool ValidatePassword(string password)
        {
            string ValidatePassword = "^(?=.*[A-Z])(?=.*[0-9])(?=.*[~!@#$%^&*()]).{8,}$";
            try
            {
                if (string.IsNullOrEmpty(ValidatePassword))
                {
                    throw new RegexCustomException(RegexCustomException.InvalidUserDetails.EMPTY_MESSAGE, "password should not be empty");
                }
                if (Regex.IsMatch(password, ValidatePassword))
                {
                    Console.WriteLine(" valid password");
                    return true;
                }
            }
            catch (NullReferenceException)
            {
                throw new RegexCustomException(RegexCustomException.InvalidUserDetails.NULL_MESSAGE, "password should not be null");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }
    }
}
