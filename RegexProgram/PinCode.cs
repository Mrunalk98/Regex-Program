using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexProgram
{
    public class PinCode
    {
        public void PinCodeValidation()
        {
            string pinCodePattern = "^[1-9]{1}[0-9]{2}\\s{0,1}[0-9]{3}$";
            Regex regex = new Regex(pinCodePattern);

            Console.Write("Enter a pin code : ");
            var pinCode = Console.ReadLine();

            if (regex.IsMatch(pinCode))
            {
                Console.WriteLine("Valid Pin Code");
            }
            else
            {
                Console.WriteLine("Invalid Pin Code");

            }
        }
    }
}
