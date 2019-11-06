using System;
using System.Collections.Generic;
using System.Linq;

namespace PhoneChecker
{
    public class NonStaticPhoneCheck
    {
        public NonStaticPhoneCheck()
        {
            
        }

        public bool PhoneNumbCheck(string phone)
        {
            string rawNumb = StripChars(phone);
            if (rawNumb.Length == 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string StripChars(string x)
        {
            return new string(x.Where(newString => char.IsDigit(newString)).ToArray());
        }

        public string ConvertLetters(string x)
        {
            
            var newNumb = new List<string>();

            foreach (char i in x)
            {
                switch (i)
                {
                    case 'a':
                    case 'b':
                    case 'c':
                        newNumb.Add("2");
                        break;
                    case 'd':
                    case 'e':
                    case 'f':
                        newNumb.Add("3");
                        break;
                    case 'g':
                    case 'h':
                    case 'i':
                        newNumb.Add("4");
                        break;
                    case 'j':
                    case 'k':
                    case 'l':
                        newNumb.Add("5");
                        break;
                    case 'm':
                    case 'n':
                    case 'o':
                        newNumb.Add("6");
                        break;
                    case 'p':
                    case 'q':
                    case 'r':
                    case 's':
                        newNumb.Add("7");
                        break;
                    case 't':
                    case 'u':
                    case 'v':
                        newNumb.Add("8");
                        break;
                    case 'w':
                    case 'x':
                    case 'y':
                    case 'z':
                        newNumb.Add("9");
                        break;
                    default:
                        newNumb.Add(i.ToString());
                        break;
                }
            }
            string phoneNumb = "";
            foreach(string i in newNumb)
            {
                phoneNumb = phoneNumb + i;
            }
            return phoneNumb;
        }
    }
}
