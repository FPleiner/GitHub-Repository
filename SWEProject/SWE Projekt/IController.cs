﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWE_Projekt
{
    interface IController
    {
         bool CheckEMail(string eMailAdress);
        bool CheckNumber(string number);
    }
}
