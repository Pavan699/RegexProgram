using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexProgram
{
    /// <summary>
    /// Inputs class to declaer methods
    /// </summary>
    public class Inputs
    {
        /// <summary>
        /// FirstName() method to check the name is valid or not
        /// </summary>
        /// <returns>if valid returns the name else returns blank</returns>
        public bool FirstName()
        {
            Console.Write("Enter the Frist-Name : ");
            string firstName = Console.ReadLine();
            string namepattern = @"^[A-Z]{1}[a-z]{3,}";// p = @"^[A-Z]{1}[a-zA-Z]{3,}";
            Regex fname = new Regex(namepattern);
            try
            {
                if (firstName.Equals(string.Empty))
                {
                    throw new CustomExcp(CustomExcp.ExcpRegex.Empty_String, "Entered Empty String");
                }
                if (fname.IsMatch(firstName) == true)
                {
                    Console.WriteLine("Name is Valid {0}", firstName);
                    return true;
                }
                else
                {
                    throw new CustomExcp(CustomExcp.ExcpRegex.Invalid_Name, "Entered Name is Invalid");                  
                }
            }
            catch (NullReferenceException)
            {
                throw new CustomExcp(CustomExcp.ExcpRegex.Null_String, "You Entered Null Value ");
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
                return fname.IsMatch(firstName);
            }
        }
        /// <summary>
        /// LastName() method to check the name is valid or not
        /// </summary>
        /// <returns>if valid returns the name else returns blank</returns>
        public bool LastName()
        {
            Console.Write("Enter the Last-Name : ");
            string lastName = Console.ReadLine();
            string namepattern = @"^[A-Z]{1}[a-z]{3,}";
            Regex lname = new Regex(namepattern);
            try
            {
                if (lastName.Equals(string.Empty))
                {
                    throw new CustomExcp(CustomExcp.ExcpRegex.Empty_String, "Entered Empty String");
                }
                if (lname.IsMatch(lastName) == true)
                {
                    Console.WriteLine("Name is Valid {0}", lastName);
                    return true;
                }
                else
                {
                    throw new CustomExcp(CustomExcp.ExcpRegex.Invalid_Name, "Entered Name is Invalid");
                }
            }
            catch (NullReferenceException)
            {
                throw new CustomExcp(CustomExcp.ExcpRegex.Null_String, "You Entered Null Value ");
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
                return lname.IsMatch(lastName);
            }
        }
        /// <summary>
        /// Email() method to check all types of email is valid or not
        /// </summary>
        /// <returns>if valid returns the email else returns blank</returns>
        public bool Email()
        {
            Console.Write("Enter the Email : ");
            string email = Console.ReadLine();
            string emailpattern = @"^[a-z]{1}[a-z0-9]+[.]{0,1}[a-z0-9]+[@]+[a-z]+[.][a-z]{2,3}([.][a-z]{2,3}){0,2}";
            Regex emailid = new Regex(emailpattern);
            try
            {
                if (email.Equals(string.Empty))
                {
                    throw new CustomExcp(CustomExcp.ExcpRegex.Empty_String, "Entered Empty String");
                }
                if (emailid.IsMatch(email) == true)
                {
                    Console.WriteLine("Email is Valid ", email);
                    return true;
                }
                else
                {
                    throw new CustomExcp(CustomExcp.ExcpRegex.Invalid_Name, "Entered Email is Invalid");
                }
            }
            catch (NullReferenceException)
            {
                throw new CustomExcp(CustomExcp.ExcpRegex.Null_String, "You Entered Null Value ");
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
                return emailid.IsMatch(email);
            }
        }
        /// <summary>
        /// PhoneNo() method to check phone no. with country code
        /// </summary>
        /// <returns>'+' is optional but code,' '(Sapce) and number(10digit) then it will return or else none</returns>
        public bool PhoneNo()
        {
            Console.Write("Enter the Phone No. with Country Code : ");
            string PhoneNo = Console.ReadLine();
            string numpattern = @"^[+]{0,1}[0-9]{2}" + " " + "[6-9]{1}[0-9]{9}$";
            Regex reg = new Regex(numpattern);
            try
            {
                if (PhoneNo.Equals(string.Empty))
                {
                    throw new CustomExcp(CustomExcp.ExcpRegex.Empty_String, "Entered Empty Phone No.");
                }
                if (reg.IsMatch(PhoneNo) == true)
                {
                    Console.WriteLine("Phone No. is Valid", PhoneNo);
                    return true;
                }
                else
                {
                    throw new CustomExcp(CustomExcp.ExcpRegex.Invalid_Name, "Entered Phone No. is Invalid");
                }
            }
            catch (NullReferenceException)
            {
                throw new CustomExcp(CustomExcp.ExcpRegex.Null_String, "You Entered Null Value ");
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
                return reg.IsMatch(PhoneNo);
            }
        }
        /// <summary>
        /// Password() method to check password with at least one Upper-character,one number and one Special symbol
        /// </summary>
        /// <returns>if all cases should match then it will return</returns>
        public bool Password()
        {
            Console.Write("Enter the Password with One Upper-Case,One Number and One Special-Symbol : ");
            string password = Console.ReadLine();
            string passpattern = @"^[0-9a-zA-Z!@#$%^&*()?]{8,}$";
            Regex reg = new Regex(passpattern);

            try
            {
                if (password.Equals(string.Empty))
                {
                    throw new CustomExcp(CustomExcp.ExcpRegex.Empty_String, "Entered Empty Password");
                }
                if (password.Length >= 8 && upperCase(password) >= 1 && numCase(password) >= 1 && SpecialCase(password) >= 1)
                {
                    Console.WriteLine("Entered Password is Valid ", password);
                    return true;
                }
                else
                {
                    throw new CustomExcp(CustomExcp.ExcpRegex.Invalid_Name, "Entered Password is Invalid");
                }
            }
            catch (NullReferenceException)
            {
                throw new CustomExcp(CustomExcp.ExcpRegex.Null_String, "You Entered Null Value ");
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
                return reg.IsMatch(password);
            }       
        }
        /// <summary>
        /// upperCase() method to check the Upper-Case-character
        /// </summary>
        /// <param name="pass">Password as input</param>
        /// <returns>if upper-case is present returns 1 or more, else 0</returns>
        private int upperCase(string pass)
        {
            int num = 0;
            foreach (char ch in pass)
            {
                if (char.IsUpper(ch))
                {
                    num++;
                }
            }
            return num;
        }
        /// <summary>
        /// numCase() method to check the Number-character
        /// </summary>
        /// <param name="pass">Password as input</param>
        /// <returns>if Number is present returns 1 or more, else 0</returns>
        private int numCase(string pass)
        {
            int num = 0;
            foreach (char ch in pass)
            {
                if (char.IsDigit(ch))
                {
                    num++;
                }
            }
            return num;
        }
        /// <summary>
        /// SpecialCase() method to check the special-character
        /// </summary>
        /// <param name="pass">Password as input</param>
        /// <returns>if special-character is present returns 1 or more, else 0</returns>
        private int SpecialCase(string pass)
        {
            int num = 0;
            foreach (char ch in pass)
            {
                if (ch == '!' || ch == '@' || ch == '#' || ch == '$' || ch == '%' || ch == '^' || ch == '&' || ch == '*' || ch == '(' || ch == ')' || ch == '?' || ch == '.')
                {
                    num++;
                }
            }
            return num;
        }
    }
}
