using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexProgram
{
    class Inputs
    {
        public dynamic FirstName()
        {
            Console.Write("Enter the Frist-Name : ");
            string firstName = Console.ReadLine();
            string namepattern = @"^[A-Z]{1}[a-z]{3,}";
            Regex fname = new Regex(namepattern);
            return fname.Match(firstName);
        }       
    }
}
