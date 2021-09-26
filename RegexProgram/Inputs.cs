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
        public dynamic LastName()
        {
            Console.Write("Enter the Last-Name : ");
            string lastName = Console.ReadLine();
            string namepattern = @"^[A-Z]{1}[a-z]{3,}";
            Regex lname = new Regex(namepattern);
            return lname.Match(lastName);
        }
        public dynamic Email()
        {
            Console.Write("Enter the Email : ");
            string email = Console.ReadLine();
            string emailpattern = @"^[a-z0-9]+[@]+[a-z]+[.][a-z]{2,3}";
            Regex emailid = new Regex(emailpattern);
            return emailid.Match(email);
        }
        public dynamic PhoneNo()
        {
            Console.Write("Enter the Phone No. : ");
            string PhoneNo = Console.ReadLine();
            string numpattern = @"^[+]{0,1}[0-9]{2}" + " " + "[6-9]{1}[0-9]{9}$";
            Regex reg = new Regex(numpattern);
            return reg.Match(PhoneNo);
        }
        public dynamic Password()
        {
            Console.Write("Enter the Password : ");
            string password = Console.ReadLine();
            string passpattern = @"^[0-9a-zA-Z]{8,}$";
            Regex reg = new Regex(passpattern);
            return reg.Match(password);
        }
    }
}
