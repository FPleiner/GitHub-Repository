using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWE_Projekt
{
    interface ICostumer
    {
        void AddCustomer(string firstName, string lastName, string email, string openBalance);
        void SelectCustomer();
        void CorrectBalance(float amount);
        void FilterCustomer(string criteria);
        void ChangeCustomer(string customerNumber, string whatToChange, string value);
        void Test();


    }
    
}
