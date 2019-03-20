using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWE_Projekt
{
    public partial class CustomerDataForm : Form
    {
        bool connect = false;
        ICustomer NCustomer = new Customer();
        public CustomerDataForm()
        {
            InitializeComponent();
            lastChangeSearchDatetimePicker.Format = DateTimePickerFormat.Custom;
            lastChangeSearchDatetimePicker.CustomFormat = "yyyy-MM-dd";

            dbDisplay.Columns.Add("0", "Customer Number");
            dbDisplay.Columns.Add("1", "First Name");
            dbDisplay.Columns.Add("2", "Last Name");
            dbDisplay.Columns.Add("3", "E-Mail Address");
            dbDisplay.Columns.Add("4", "Open Balance [€]");
            dbDisplay.Columns.Add("5", "Last Change");
            dbDisplay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            toolStripStatusConnectionLabel.BackColor = Color.Red;
            newCustomer.Enabled = false;
            deleteCustomer.Enabled = false;
            customerNumberSearchUpDown.Enabled = false;
            firstNameSearchTextbox.Enabled = false;
            lastNameSearchTextbox.Enabled = false;
            eMailAddressSearchTextbox.Enabled = false;
            openBalanceSearchUpDown.Enabled = false;
            lastChangeSearchDatetimePicker.Enabled = false;
            resetSearchButton.Enabled = false;
            manageMoneyButton.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (ConnectionButton.Text == "Disconnect" && connect == true)
            {
                toolStripStatusConnectionLabel.BackColor = Color.Red;
                toolStripStatusConnectionLabel.Text = "Not Connected! Please connect to the database";

                newCustomer.Enabled = false;
                deleteCustomer.Enabled = false;
                customerNumberSearchUpDown.Enabled = false;
                firstNameSearchTextbox.Enabled = false;
                lastNameSearchTextbox.Enabled = false;
                eMailAddressSearchTextbox.Enabled = false;
                openBalanceSearchUpDown.Enabled = false;
                lastChangeSearchDatetimePicker.Enabled = false;
                resetSearchButton.Enabled = false;
                manageMoneyButton.Enabled = false;

                NCustomer.CloseConnection();
                ConnectionButton.Text = "Connect";
            }

            if (ConnectionButton.Text == "Connect"&&connect==false)
            {
                if (NCustomer.TestConnection("SERVER=127.0.0.1" + ";" + "PORT=3306" + ";" + "DATABASE=mydb" + ";" +
                                             "UID=admin" + ";" + "PASSWORD=123456" + ";" +
                                             "convert zero datetime=True" +
                                             ";"))
                {
                    toolStripStatusConnectionLabel.BackColor = Color.Green;
                    toolStripStatusConnectionLabel.Text = "Connected to database!";

                    NCustomer.ConnectToDatabase();
                    List<string>[] list = NCustomer.SelectAllCustomer();
                    UpdateList(list);

                    newCustomer.Enabled = true;
                    deleteCustomer.Enabled = true;
                    customerNumberSearchUpDown.Enabled = true;
                    firstNameSearchTextbox.Enabled = true;
                    lastNameSearchTextbox.Enabled = true;
                    eMailAddressSearchTextbox.Enabled = true;
                    openBalanceSearchUpDown.Enabled = true;
                    lastChangeSearchDatetimePicker.Enabled = true;
                    resetSearchButton.Enabled = true;
                    manageMoneyButton.Enabled = true;

                    ConnectionButton.Text = "Disconnect";
                }
                else
                {
                    MessageBox.Show(
                        "Connection not successful! Please ensure that the Database is up and running. If there is still a problem contact the programmer!");
                }
            }

            
            connect = !connect;

        }
        public void UpdateList(List<string> [] list)
        {
            

            

            int count = list[0].Count;
            dbDisplay.Rows.Clear();
            for (int i = 0; i < list[0].Count; i++)
            {

                int number = dbDisplay.Rows.Add();
                dbDisplay.Rows[number].Cells[0].Value = list[0][i];
                dbDisplay.Rows[number].Cells[1].Value = list[1][i];
                dbDisplay.Rows[number].Cells[2].Value = list[2][i];
                dbDisplay.Rows[number].Cells[3].Value = list[3][i];
                dbDisplay.Rows[number].Cells[4].Value = list[4][i];
                dbDisplay.Rows[number].Cells[5].Value = list[5][i];

            }
          
        }

        private void newCustomer_Click(object sender, EventArgs e)
        {
            Form m = new NewCustomer();
            m.ShowDialog();
            List<string>[] list = NCustomer.SelectAllCustomer();
            UpdateList(list);

        }
        private void deleteCustomer_Click(object sender, EventArgs e)
        {

        }


        private void customerNumberSearchUpDown_ValueChanged(object sender, EventArgs e)
        {

            List<string>[] list = NCustomer.FilterCustomerNumber(customerNumberSearchUpDown.Text);
            UpdateList(list);
        }

        private void firstNameSearchTextbox_TextChanged(object sender, EventArgs e)
        {
            List<string>[] list = NCustomer.FilterFirstName(firstNameSearchTextbox.Text);
            UpdateList(list);
        }

        private void lastNameSearchTextbox_TextChanged(object sender, EventArgs e)
        {
            List<string>[] list = NCustomer.FilterLastName(lastNameSearchTextbox.Text);
            UpdateList(list);
        }

        private void eMailAddressSearchTextbox_TextChanged(object sender, EventArgs e)
        {
            List<string>[] list = NCustomer.FilterEMail(eMailAddressSearchTextbox.Text);
            UpdateList(list);
        }

        private void openBalanceSearchUpDown_ValueChanged(object sender, EventArgs e)
        {
            List<string>[] list = NCustomer.FilterOpenBalance(openBalanceSearchUpDown.Text);
            UpdateList(list);
        }

        private void lastChangeSearchDatetimePicker_ValueChanged(object sender, EventArgs e)
        {
            
            List<string>[] list = NCustomer.FilterLastChanged(lastChangeSearchDatetimePicker.Text);
            UpdateList(list);
        }

        private void resetSearchButton_Click(object sender, EventArgs e)
        {
            customerNumberSearchUpDown.Text = "";
            firstNameSearchTextbox.Text = "";
            lastNameSearchTextbox.Text = "";
            eMailAddressSearchTextbox.Text = "";
            openBalanceSearchUpDown.Text = "";
            lastChangeSearchDatetimePicker.Text = DateTime.Today.ToString();

            List<string>[] list = NCustomer.SelectAllCustomer();
            UpdateList(list);

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void manageMoneyButton_Click(object sender, EventArgs e)
        {
            Form m = new ManageMoney();
            m.ShowDialog();
            List<string>[] list = NCustomer.SelectAllCustomer();
            UpdateList(list);
        }
    }
}
