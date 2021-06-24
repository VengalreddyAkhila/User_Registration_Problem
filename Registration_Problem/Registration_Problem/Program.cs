using System;

namespace Registration_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Registraion problem");
            Registration registration = new Registration();
            Console.WriteLine("enter first name with starting caps and minimum three characters");
            string firstname = Console.ReadLine();        
            registration.ValidateFirstName(firstname);
            Console.WriteLine("enter Email id ");
            string emailid = Console.ReadLine();
            registration.ValidateEmail(emailid);
            Console.WriteLine("enter phone number with predefined country code with space");
            string phonenumber = Console.ReadLine();
            registration.ValidatePhonenumber(phonenumber);
            Console.WriteLine("enter password atleast one caps ,numerics and special characters");
            string password = Console.ReadLine();
            registration.ValidatePassword(password);           
        }
    }
}
