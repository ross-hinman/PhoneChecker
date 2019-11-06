using System;
using System.Collections.Generic;

namespace PhoneChecker
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your phone number:");
            string phoneNumb = Console.ReadLine();

            bool isLegit = StaticPhoneCheck.PhoneNumbCheck(phoneNumb);

            Console.WriteLine("Static Check:");
            if (isLegit)
            {
                Console.WriteLine($"Your phone number, {phoneNumb}, is acceptable");
            }
            else
            {
                Console.WriteLine($"Your phone number, {phoneNumb}, is not acceptable");
            }

            var nonStatic = new NonStaticPhoneCheck();
            bool nonStaticIsLegit = nonStatic.PhoneNumbCheck(phoneNumb);

            Console.WriteLine("NonStatic Check");
            if (nonStaticIsLegit)
            {
                Console.WriteLine($"Your phone number, {phoneNumb}, is acceptable");
            }
            else
            {
                Console.WriteLine($"Your phone number, {phoneNumb}, is not acceptable");
            }

            Console.WriteLine("Enter a number that contains letters and numbers:");
            string alphaNumb = Console.ReadLine().ToLower();

            string newAlphaNumb = nonStatic.ConvertLetters(alphaNumb);

            Console.WriteLine("Your converted Phone Number:");
            Console.WriteLine(newAlphaNumb);

            bool convertedAlphaNumb = nonStatic.PhoneNumbCheck(newAlphaNumb);
            if (convertedAlphaNumb)
            {
                Console.WriteLine("Your phone number is acceptable");
            }
            else
            {
                Console.WriteLine("Your phone number is not acceptable");
            }
        }
    }
}
