using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWE_Projekt
{
    interface ICustomer
    {
        //explanation in the class Customer
        void ConnectToDatabase(string connectionString);
        void AddCustomer(string firstName, string lastName, string email, string openBalance,string street,string houseNumber,string postalcode,string town);
        List<string>[] SelectAllCustomer();
        void CorrectBalance(string customerNumber,string amount);

        bool CheckBalance(string customerNumber);
        bool CheckUnique(string eMailAdress);
        bool TestConnection(string connectionstring);
        void CloseConnection();
        void ConnectWithoutMessage();
        void EditAddress(string costumerNumber, string street, string houseNumber, string postalCode, string town);
        void DeleteCustomer(string costumerNumber);

        List<string>[] FilterCustomerNumber(string criteria);
        List<string>[] FilterFirstName(string criteria);
        List<string>[] FilterLastName(string criteria);
        List<string>[] FilterEMail(string criteria);
        List<string>[] FilterOpenBalance(string criteria);
        List<string>[] FilterLastChanged(string criteria);
        List<string>[] FilterCustomerNumberAndEMail(string number, string eMail);




    }
    
}
