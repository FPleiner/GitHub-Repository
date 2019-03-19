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
            //convert the incoming string into decimal number with '.' instead of ',' and 2 digits after the dot.
            openBalance=openBalance.Replace(',', '.');
            openBalance= openBalance.Remove(openBalance.IndexOf('.') + 3);


            string query = "INSERT INTO Customer(FirstName, LastName, EmailAdress, OpenBalance, LastChange) VALUES('"+firstName+"', '"+lastName+"', '"+email+"', '"+openBalance+"','"+ DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")+"');";
            
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

       
        public void ChangeCustomer(string customerNumber, string whatToChange, string value)
        {
            throw new NotImplementedException();
        }

        public bool CheckUnique(string eMailAdress)
        {
            connection.ConnectWithoutMessage();
            List<string>[] list = SelectAllCustomer();
            foreach (string var in list[3])
            {
                if (eMailAdress == var)
                {
                    return false;
                }
            }

            return true;
        }

        public bool TestConnection(string connectionstring)
        {
            return connection.TryConnection(connectionstring);
        }

        public void CloseConnection()
        {
            connection.CloseConnection();
        }

        public List<string>[] FilterCustomerNumber(string criteria)
        {
            List<string>[] list;
            list = connection.Select("select * from customer where CustomerNumber like '%"+criteria+"%';");
            return list;
        }

        public List<string>[] FilterFirstName(string criteria)
        {
            List<string>[] list;
            list = connection.Select("select * from customer where FirstName like '%" + criteria + "%';");
            return list;
        }

        public List<string>[] FilterLastName(string criteria)
        {
            List<string>[] list;
            list = connection.Select("select * from customer where LastName like '%" + criteria + "%';");
            return list;
        }

        public List<string>[] FilterEMail(string criteria)
        {
            List<string>[] list;
            list = connection.Select("select * from customer where EmailAdress like '%" + criteria + "%';");
            return list;
        }

        public List<string>[] FilterOpenBalance(string criteria)
        {
            List<string>[] list;
            list = connection.Select("select * from customer where OpenBalance like '%" + criteria + "%';");
            return list;
        }

        public List<string>[] FilterLastChanged(string criteria)
        {
            List<string>[] list;
            list = connection.Select("select * from customer where LastChange like '%" + criteria + "%';");
            return list;
        }
    }
    
   
}
