﻿using System;

namespace Registration_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Registraion problem");           
            Registration registration = new Registration();
            Console.WriteLine(registration.validateFirstname("Rmun"));

        }
    }
}