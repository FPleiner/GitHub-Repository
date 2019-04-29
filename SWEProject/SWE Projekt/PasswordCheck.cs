using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SWE_Projekt
{
    public partial class PasswordCheck : Form
    {
        ICustomer Customer = new Customer();
        private int failedconnections = 0;
        string path;
        public PasswordCheck()
        {
            //get the path of the log file to write any errors to it
            path = Path.GetFullPath("log.txt");
            InitializeComponent();
        }

        private void button_connect_Click(object sender, EventArgs e) //takes the input strings, builds a connectionstring out of them and tries to connect to the database. If successful window closes and main window opens if not error displayed and 1 out of 3 tries gone
        {
            
            string connectionstring = "SERVER=" + textbox_IPAddress.Text + ";" + "PORT=" + textbox_ServerPort.Text + ";" + "DATABASE=" + textbox_DB_Name.Text + ";" + "UID=" + textbox_dbuser.Text + ";" + "PASSWORD=" + textbox_dbuserpassword.Text + ";";
            if (Customer.TestConnection(connectionstring))
            {
                Customer.ConnectToDatabase(connectionstring);
                Form m = new CustomerDataForm(connectionstring);
                this.Hide();
                m.ShowDialog();
             this.Show();
            }
            else
            {
                failedconnections++;
                MessageBox.Show("Check login data and try again! \n " + (3 - failedconnections) + " Tries left");
            }

            if (failedconnections > 2)
            {
                using (StreamWriter log = File.AppendText(path))
                {
                    log.WriteLine("" + DateTime.Now + " : Login Error: To many tries");
                    this.Close();
                }
                failedconnections = 0;
                this.Close();
            }
            
        }

        private void cancelButton_Click(object sender, EventArgs e) //exit application
        {
            Application.Exit();
        }
    }
}
