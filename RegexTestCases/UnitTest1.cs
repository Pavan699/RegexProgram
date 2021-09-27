using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegexProgram;
using System.Text.RegularExpressions;

namespace RegexTestCases
{
    /// <summary>
    /// UnitTest1 class to check regex program  
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        Inputs input = new Inputs();//Arrenge or Object for the Inputs Calss
        /// <summary>
        /// TestFirstName() to check the First-Name is valid or not
        /// </summary>
        [TestMethod]
        public void TestFirstName()
        {
            string firstName = "Pavan";     //Act
            string namepattern = @"^[A-Z]{1}[a-z]{3,}";
            Regex fname = new Regex(namepattern);
            bool res = fname.IsMatch(firstName);

            Assert.AreEqual(true, res);//Assert
        }
        /// <summary>
        /// TestLastName() to check the Last-Name is valid or not
        /// </summary>
        [TestMethod]
        public void TestLastName()
        {
            string lastName = "Nakate";     //Act
            string namepattern = @"^[A-Z]{1}[a-z]{3,}";
            Regex lname = new Regex(namepattern);
            bool res = lname.IsMatch(lastName);

            Assert.AreEqual(true, res);//Assert
        }
        /// <summary>
        /// TestEmail() to check the all types of emails are valid or not
        /// </summary>
        [TestMethod]
        public void TestEmail()
        {
            string email = "pavan.nakate03@gamil.coep.co.in";     //Act
            string emailpattern = @"^[a-z0-9]+[.]{0,1}[a-z0-9]+[@]+[a-z]+[.][a-z]{2,4}([.][a-z]{2,3}){0,2}";
            Regex emailid = new Regex(emailpattern);
            bool res = emailid.IsMatch(email);

            Assert.AreEqual(true, res);//Assert
        }
        /// <summary>
        /// TestPhoneNo() to check the Phone No. with country Code
        /// </summary>
        [TestMethod]
        public void TestPhoneNo()
        {
            string PhoneNo = "+91 9966748857";//act
            string phoneNo = @"^[+]{0,1}[0-9]{2}" + " " + "[6-9]{1}[0-9]{9}$";
            Regex reg = new Regex(phoneNo);           
            bool res = reg.IsMatch(PhoneNo);

            Assert.AreEqual(true, res);//Assert
        }
        /// <summary>
        /// TestPassword() to check password with One Upper-cse character,one number and one special symbol and minimum 8 digits
        /// </summary>
        [TestMethod]
        public void TestPassword()
        {          
            string password = "Pavan@699"; //act
            string passpattern = @"^[0-9a-zA-Z!@#$%^&*()?]{8,}$";
            Regex reg = new Regex(passpattern);
            bool res = reg.IsMatch(password);

            Assert.AreEqual(true, res);//Assert
        }
    }
}
