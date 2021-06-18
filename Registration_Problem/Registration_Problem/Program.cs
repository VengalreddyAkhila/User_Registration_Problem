using System;

namespace Registration_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Registraion problem");           
            Registration registration = new Registration();
            Console.WriteLine(registration.validateFirstname("Ram"));
            Console.WriteLine(registration.validateLastname("Anu"));
            Console.WriteLine(registration.validateEmail("akhila123@gmail.com"));
            Console.WriteLine(registration.validatePhonenumber("+919908556919"));
            Console.WriteLine(registration.validatePassword("abc132ef"));
            Console.WriteLine(registration.validatePassworduppercase("Akhila12"));
        }
    }
}
