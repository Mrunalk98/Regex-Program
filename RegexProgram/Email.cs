using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexProgram
{
    class Email
    {
        public void EmailValidation()
        {  
            string emailPattern = @"^([a-z0-9.+_-]*@([a-z0-9]*?\.)+[a-z0-9]*?)$";
            Regex regex = new Regex(emailPattern);

            Console.Write("Enter an email : ");
            var email = Console.ReadLine();

            if (regex.IsMatch(email))
            {
                Console.WriteLine("Valid Email");
            }
            else
            {
                Console.WriteLine("Invalid Email");

            }
        }
    }
}
