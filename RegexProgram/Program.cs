﻿using System;


namespace RegexProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Regex Program");
            Inputs inputs = new Inputs();
            Console.WriteLine(inputs.FirstName());
            Console.WriteLine(inputs.LastName());
            Console.WriteLine(inputs.Email());
            Console.WriteLine(inputs.PhoneNo());
        }
    }
}
