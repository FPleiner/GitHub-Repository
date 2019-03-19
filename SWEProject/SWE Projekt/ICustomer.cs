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

        void ChangeCustomer(string customerNumber, string whatToChange, string value);
        bool CheckUnique(string eMailAdress);
        bool TestConnection(string connectionstring);
        void CloseConnection();

        List<string>[] FilterCustomerNumber(string criteria);
        List<string>[] FilterFirstName(string criteria);
        List<string>[] FilterLastName(string criteria);
        List<string>[] FilterEMail(string criteria);
        List<string>[] FilterOpenBalance(string criteria);
        List<string>[] FilterLastChanged(string criteria);




    }
    
}
