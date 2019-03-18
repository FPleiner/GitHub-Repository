using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SWE_Projekt
{
    class Controller : IController
    {
        public bool CheckEMail(string eMailAdress)
        {
            checkAT(eMailAdress);
            bool exactlyOneAT = eMailAdress.Contains('@');
            bool atLeastOneDot = false;
            bool charAfterLastDot = false;
            bool charBeforeAT = false;

           
            if(exactlyOneAT &&atLeastOneDot&&charAfterLastDot&&charBeforeAT )
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        private bool checkAT(string eMailAdress)
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
    }
}
