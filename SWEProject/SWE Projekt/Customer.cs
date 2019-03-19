using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SWE_Projekt
{
    public class Customer : ICustomer
    {
        private DatabaseConnection connection = new DatabaseConnection();
        public void ConnectToDatabase()
        {
            connection.Connect();
            
        }
        public void AddCustomer(string firstName, string lastName, string email, string openBalance)
         {
            //convert the incoming string into a 2 digget string (curreny format)
            openBalance=openBalance.Replace(',', '.');
            openBalance= openBalance.Remove(openBalance.IndexOf('.') + 3);


            string query = "INSERT INTO Customer(FirstName, LastName, EmailAdress, OpenBalance, LastChange) VALUES('"+firstName+"', '"+lastName+"', '"+email+"', '"+openBalance+"','"+ DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")+"');"; //change Datetime still error
            //find way to implement one Interface of controller in NesCustomer AND Hauptfenster
            connection.ConnectWithoutMessage();
            connection.Insert(query);

        }

        public List<String> [] SelectAllCustomer()
        {
            List<string>[] list;
            list = connection.Select("select * from customer;");
            return list;
        }

        public void CorrectBalance(float amount)
        {
            throw new NotImplementedException();
        }

        public void FilterCustomer(string criteria)
        {
            throw new NotImplementedException();
        }

        public void ChangeCustomer(string customerNumber, string whatToChange, string value)
        {
            throw new NotImplementedException();
        }

        
    }
    
   
}
