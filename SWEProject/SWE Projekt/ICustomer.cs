using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWE_Projekt
{
    interface ICustomer
    {
        void ConnectToDatabase();
        void AddCustomer(string firstName, string lastName, string email, string openBalance);
        List<string>[] SelectAllCustomer();
        void CorrectBalance(float amount);
        void FilterCustomer(string criteria);
        void ChangeCustomer(string customerNumber, string whatToChange, string value);

        

    
    }
    
}
