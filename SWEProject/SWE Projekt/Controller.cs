using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SWE_Projekt
{
    class Controller : IController
    {
        public bool CheckEMail(string eMailAdress) //checks if the given email address is valid according to the given standard
        {
            ;
            bool exactlyOneAT = checkAT(eMailAdress);
            if (exactlyOneAT)
            {
                bool atLeastOneDot = DotAfterAT(eMailAdress);
                if (atLeastOneDot)
                {
                bool charAfterLastDot = CountCharsAfterLastDot(eMailAdress);
                    if (charAfterLastDot)
                    {
                        bool charBeforeAT = CharBeforeAT(eMailAdress);
                        if (charBeforeAT)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
             
            
        }

        private bool checkAT(string eMailAdress) //checks for @
        {
            if (eMailAdress.Contains('@'))
            {
                string [] split = eMailAdress.Split('@');
                if (split.Count() > 2)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
            

        }

        private bool DotAfterAT(string eMailAdress) //checks for the dot after @
        {
            string[] split = eMailAdress.Split('@');
            if (split[1].Contains('.'))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool CountCharsAfterLastDot(string eMailAdress) //checks for the country letters after last dot
         {
            string[] split = eMailAdress.Split('@');
            string trimmed = split[1].Substring(split[1].LastIndexOf('.')+1);
            if (trimmed.Length > 1 && trimmed.Length < 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool CharBeforeAT(string eMailAdress) //checks if there are letters before @
        {
            string[] split = eMailAdress.Split('@');
            if (split[0].Length > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckNumber(string number) //checks if given string is a number or not
        {
            float parsedValue;
            if (!float.TryParse(number, out parsedValue))
            {

                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
