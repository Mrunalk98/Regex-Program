using System;
using System.Text.RegularExpressions;

namespace RegexProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Regex Program!");
            PinCode pincode = new PinCode();
            Email email = new Email();

            Console.WriteLine("Select option you want to validate : 1. Pin Code     2. Email");
            var choice = Convert.ToInt32(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    pincode.PinCodeValidation();
                    break;

                case 2:
                    email.EmailValidation();
                    break;

                default :
                    break;
            }
        }
    }
}
