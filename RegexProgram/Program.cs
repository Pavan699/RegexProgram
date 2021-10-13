using System;


namespace RegexProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Regex Program");
            Inputs inputs = new Inputs();
            //callinf methods from Inputs class
            
            int count = 1,choice;
            while(count != 2)
            {
                Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                Console.WriteLine("1.First-Name\t2.LastName\t3.Email\n4.Phone No. \t5.Password  \t6.Exit");
                Console.Write("Enter Choice : ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter the Frist-Name : ");
                        string firstName = Console.ReadLine();
                        Console.WriteLine(inputs.FirstNameValid(firstName, Inputs.namepattern));
                        break;
                    case 2:
                        Console.Write("Enter the Last-Name : ");
                        string lastName = Console.ReadLine();
                        Console.WriteLine(inputs.LastNameValid(lastName, Inputs.namepattern));
                        break;
                    case 3:
                        Console.Write("Enter the Email : ");
                        string email = Console.ReadLine();
                        Console.WriteLine(inputs.EmailValid(email,Inputs.emailpattern));
                        break;
                    case 4:
                        Console.Write("Enter the Phone No. with Country Code : ");
                        string PhoneNo = Console.ReadLine();
                        Console.WriteLine(inputs.PhoneNoValid(PhoneNo,Inputs.numpattern));
                        break;
                    case 5:
                        Console.Write("Enter the Password with One Upper-Case,One Number and One Special-Symbol : ");
                        string password = Console.ReadLine();
                        Console.WriteLine(inputs.PasswordValid(password,Inputs.passpattern));
                        break;
                    default:
                        Console.WriteLine("Thank You..... :)");
                        count++;
                        break;
                }
            }
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Reflections.ReflectionsTests();
        }
    }
}
