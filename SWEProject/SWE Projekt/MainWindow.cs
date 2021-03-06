﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using  System.IO;
using System.Windows.Forms.VisualStyles;

namespace SWE_Projekt
{
    public partial class CustomerDataForm : Form
    {
        
        ICustomer NCustomer = new Customer();
        IController Controller= new Controller();
        public CustomerDataForm(string connectionString)
        {
            InitializeComponent();
            //searches for the path of the log file
            string path;
            path = Path.GetFullPath("log.txt");
            Console.WriteLine(path);
            
            //formates the datetimepicker in the search criteria
            lastChangeSearchDatetimePicker.Format = DateTimePickerFormat.Custom;
            lastChangeSearchDatetimePicker.CustomFormat = "yyyy-MM-dd";

            //initializes the datagrid with given parameters
            dbDisplay.Columns.Add("0", "Customer Number");
            dbDisplay.Columns.Add("1", "First Name");
            dbDisplay.Columns.Add("2", "Last Name");
            dbDisplay.Columns.Add("3", "E-Mail Address");
            dbDisplay.Columns.Add("4", "Open Balance [€]");
            dbDisplay.Columns.Add("5", "Last Change");
            dbDisplay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

           
            toolStripStatusConnectionLabel.BackColor = Color.Green;
            toolStripStatusConnectionLabel.Text = "Connected to database!";

            NCustomer.ConnectToDatabase(connectionString);
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
            editAddressButton.Enabled = true;

        }

        public void UpdateList(List<string> [] list) //updates the datagrid with the newest data
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
                dbDisplay.Rows[number].Cells[5].Value = list[9][i];

            }
          
        }

        private void newCustomer_Click(object sender, EventArgs e) //open the new customer window
        {
            Form m = new NewCustomer();
            m.ShowDialog();
            List<string>[] list = NCustomer.SelectAllCustomer();
            UpdateList(list);

        }
        private void deleteCustomer_Click(object sender, EventArgs e)//opens the delete customer window
        {
            Form m = new DeleteCustomer();
            m.ShowDialog();
            List<string>[] list = NCustomer.SelectAllCustomer();
            UpdateList(list);
        }

        //all the filter methods when one of the search criteria textboxes changes its value
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

        private void resetSearchButton_Click(object sender, EventArgs e)//resets the search and updates the datagrid to view the whole list again
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

        private void exitButton_Click(object sender, EventArgs e) //closes this window and returns to the login view
        {
            this.Close();
        }

        private void manageMoneyButton_Click(object sender, EventArgs e)//opens the window to manage the money of customers
        {
            Form m = new ManageMoney();
            m.ShowDialog();
            List<string>[] list = NCustomer.SelectAllCustomer();
            UpdateList(list);
        }

        private void editAddressButton_Click(object sender, EventArgs e)//opens the window to edit the address of customers
        {
            Form m = new EditAddress();
            m.ShowDialog();
        }
    }
}
