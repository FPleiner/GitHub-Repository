using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using MySql.Data.MySqlClient;

namespace SWE_Projekt
{
    class DatabaseConnection
    {

            private MySqlConnection connection;

            public DatabaseConnection()
            {

            }
            public void Connect(/*string connectionsstring*/)
            {
                connection = new MySqlConnection("SERVER=127.0.0.1" + ";" + "PORT=3306" + ";" + "DATABASE=mydb" + ";" + "UID=admin" + ";" + "PASSWORD=123456" + ";"+ "convert zero datetime=True"+";");
                if (this.OpenConnection() == true)
                {
                   // MessageBox.Show("Connection to Server successfully established:" + connection.DataSource + "\n Database: " + connection.Database);
                    this.CloseConnection();
                }


            }
        public void ConnectWithoutMessage(/*string connectionsstring*/)
        {
            connection = new MySqlConnection("SERVER=127.0.0.1" + ";" + "PORT=3306" + ";" + "DATABASE=mydb" + ";" + "UID=admin" + ";" + "PASSWORD=123456" + ";" + "convert zero datetime=True" + ";");
            if (this.OpenConnection() == true)
            {
                
                this.CloseConnection();
            }


        }
        public bool OpenConnection()
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch (MySqlException ex)
                {
                    switch (ex.Number)
                    {
                        case 0:
                            MessageBox.Show("Cannot connect to server. Check you Networkconnetion.  Contact administrator");
                            break;
                        case 1045:
                            MessageBox.Show("Invalid username/password, please try again");
                            break;
                    }
                    return false;
                }
            }
            public bool CloseConnection()
            {
                try
                {
                    connection.Close();
                    return true;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            public bool TryConnection(string connectionstring)
            {
                connection = new MySqlConnection(connectionstring);
                try
                {
                    connection.Open();
                    return true;
                }
                catch (MySqlException ex)
                {
                    return false;
                }
            }

            //Select statement
            public List<string>[] Select(string query)
            {
                //Create a list to store the result
                List<string>[] list = new List<string>[7];
                list[0] = new List<string>();
                list[1] = new List<string>();
                list[2] = new List<string>();
                list[3] = new List<string>();
                list[4] = new List<string>();
                list[5] = new List<string>();


                //Open connection
                if (this.OpenConnection() == true)
                {
                    //Create Command
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    //Create a data reader and Execute the command
                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    //Read the data and store them in the list
                    while (dataReader.Read())
                    {
                        list[0].Add(dataReader["CustomerNumber"] + "");
                        list[1].Add(dataReader["FirstName"] + "");
                        list[2].Add(dataReader["LastName"] + "");
                        list[3].Add(dataReader["EmailAdress"] + "");
                        list[4].Add(dataReader["OpenBalance"] + "");
                        list[5].Add(dataReader["LastChange"] + "");



                    }

                    //close Data Reader
                    dataReader.Close();

                    //close Connection
                    this.CloseConnection();

                    //return list to be displayed
                    return list;
                }
                else
                {
                    return list;
                }
            }
            //Insert statement
            public void Insert(string query)
            {
                //open connection
                if (this.OpenConnection() == true)
                {
                    //create command and assign the query and connection from the constructor
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    //Execute command
                    cmd.ExecuteNonQuery();

                    //close connection
                    this.CloseConnection();
                }
            }
            //Update statement
            public void Update(string query)
            {
                //Open connection
                if (this.OpenConnection() == true)
                {
                    //create mysql command
                    MySqlCommand cmd = new MySqlCommand();
                    //Assign the query using CommandText
                    cmd.CommandText = query;
                    //Assign the connection using Connection
                    cmd.Connection = connection;

                    //Execute query
                    cmd.ExecuteNonQuery();

                    //close connection
                    this.CloseConnection();
                }
            }

            //Delete statement
            public void Delete(string query)
            {
                if (this.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    this.CloseConnection();
                }
            }


        }
    }



