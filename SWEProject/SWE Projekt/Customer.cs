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
        public void ConnectToDatabase(string connectionString)
        {
            connection.Connect(connectionString);
            
        }
        public void AddCustomer(string firstName, string lastName, string email, string openBalance, string street,string houseNumber,string postalcode,string town)
         {
            //convert the incoming string into decimal number with '.' instead of ',' and 2 digits after the dot.
            openBalance=openBalance.Replace(',', '.');
            
            if (openBalance.Contains('.')&& openBalance.Substring(openBalance.LastIndexOf('.')).Length>3)
            {
               openBalance= openBalance.Remove(openBalance.IndexOf('.') + 3);  
            }
           


            string query = "INSERT INTO Customer(FirstName, LastName, EmailAdress, OpenBalance, Street, HouseNumber, PostalCode, Town, LastChange) VALUES('"+firstName+"', '"+lastName+"', '"+email+"', '"+openBalance+"','"+street+ "','" +houseNumber+ "','" +postalcode+ "','" +town+ "','" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")+"');";
            
            connection.ConnectWithoutMessage();
            connection.Insert(query);

        }

        public List<String> [] SelectAllCustomer()
        {
            List<string>[] list;
            list = connection.Select("select * from customer;");
            return list;
        }

        public void CorrectBalance(string customerNumber,string amount)
        {
            string openBalance=amount;
            if (amount.Contains(',')&&amount.Substring(amount.LastIndexOf(',')).Length > 3)
            {
                openBalance = amount.Remove(amount.IndexOf(',') + 3);
            }

            List<string>[] list = connection.Select("Select * From customer WHERE CustomerNumber ='" + customerNumber + "';");
            string number = "0";
            foreach (string var in list[4])
            {
                 number = var;
            }

            float amountDB;
            float.TryParse(number,out amountDB);
            float enteredAmount;
            float.TryParse(openBalance, out enteredAmount);
            float newAmount = amountDB + enteredAmount;
            string newDB = newAmount.ToString().Replace(',', '.');
            if (newDB.Contains('.'))
            {
                newDB = newDB.Remove(openBalance.IndexOf('.') + 3);
            }
            connection.Update("update customer set OpenBalance = '" + newDB + "' where CustomerNumber = '" + customerNumber + "';");
            
        }

        public bool CheckBalance(string customerNumber)
        {
            List<string>[] list = connection.Select("Select * From customer WHERE CustomerNumber ='" + customerNumber + "';");
            string number = "0";
            foreach (string var in list[4])
            {
                number = var;
            }

            if (number == "0")
            {
                return true;
            }
            else
            {
                return false;
            }
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

        public void ConnectWithoutMessage()
        {
            connection.ConnectWithoutMessage();
        }

        public void DeleteCustomer(string costumerNumber)
        {
            connection.Delete("delete from Customer where CustomerNumber = '"+costumerNumber+"';");
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

        public List<string>[] FilterCustomerNumberAndEMail(string Number, string EMail)
        {
            List<string>[] list;
            list = connection.Select("select * from customer where CustomerNumber like '%" + Number + "%' AND EmailAdress like '%"+ EMail +"%';");
            return list;
        }

        public void EditAddress(string customerNumber, string street, string houseNumber, string postalcode,
            string town)
        {
            connection.Update("update customer set Street = '"+street+"' , HouseNumber ='"+houseNumber+"' , PostalCode ='"+postalcode+"' , Town = '"+town+"' where CustomerNumber='"+customerNumber+"';");
        }
    }
    
   
}
