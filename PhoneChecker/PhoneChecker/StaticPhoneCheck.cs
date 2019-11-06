using System;
using System.Linq;

namespace PhoneChecker
{
    public static class StaticPhoneCheck
    {
        public static bool PhoneNumbCheck(string phone)
        {
            string rawNumb = StripChars(phone);
            if(rawNumb.Length == 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string StripChars(string x)
        { 
            return new string(x.Where(newString => char.IsDigit(newString)).ToArray());           
        }
    }
}
