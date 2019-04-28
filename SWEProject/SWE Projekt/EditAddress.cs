﻿using System;
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
    public partial class EditAddress : Form
    {
        IController Controller = new Controller();
        ICustomer Customer = new Customer();
        public EditAddress()
        {
                InitializeComponent();



                dataGridSearch.Columns.Add("0", "Customer Number");
                dataGridSearch.Columns.Add("1", "First Name");
                dataGridSearch.Columns.Add("2", "Last Name");
                dataGridSearch.Columns.Add("3", "Open Balance [€]");
                dataGridSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


               
                dataGridSearch.Hide();
            }

            private void eMailAddressTextbox_TextChanged(object sender, EventArgs e)
            {
                bool checkMail = Controller.CheckEMail(eMailAddressTextbox.Text);

                if (checkMail)
                {
                    eMailAddressTextbox.BackColor = Color.Green;

                }
                else
                {
                    eMailAddressTextbox.BackColor = Color.Red;
                }
            }

            private void searchButton_Click(object sender, EventArgs e)
            {
                Customer.ConnectWithoutMessage();
                List<string>[] list = Customer.FilterCustomerNumberAndEMail(customerNumberUpDown.Text, eMailAddressTextbox.Text);
                UpdateList(list);
                eMailAddressTextbox.Enabled = false;
                customerNumberUpDown.Enabled = false;
                
                dataGridSearch.Show();

            }
            public void UpdateList(List<string>[] list)
            {
                int count = list[0].Count;
                dataGridSearch.Rows.Clear();
                for (int i = 0; i < list[0].Count; i++)
                {

                    int number = dataGridSearch.Rows.Add();
                    dataGridSearch.Rows[number].Cells[0].Value = list[0][i];
                    dataGridSearch.Rows[number].Cells[1].Value = list[1][i];
                    dataGridSearch.Rows[number].Cells[2].Value = list[2][i];
                    dataGridSearch.Rows[number].Cells[3].Value = list[4][i];

                    streetNameTextbox.Text = list[5][i];
                    houseNumberTextbox.Text = list[6][i];
                    postCodeTextbox.Text = list[7][i];
                    townTextbox.Text = list[8][i];

                }

            }

            private void resetButton_Click(object sender, EventArgs e)
            {
                eMailAddressTextbox.Enabled = true;
                customerNumberUpDown.Enabled = true;
                
                eMailAddressTextbox.BackColor = default(Color);
                eMailAddressTextbox.Text = "";
                customerNumberUpDown.Text = "";
                
                dataGridSearch.ClearSelection();
            }

            private void editButton_Click(object sender, EventArgs e)
            {
                if (string.IsNullOrWhiteSpace(streetNameTextbox.Text) == false &&
                    string.IsNullOrWhiteSpace(houseNumberTextbox.Text) == false &&
                    string.IsNullOrWhiteSpace(postCodeTextbox.Text) == false &&
                    string.IsNullOrWhiteSpace(townTextbox.Text) == false)
                {
                    if (Controller.CheckNumber(houseNumberTextbox.Text) && Controller.CheckNumber(postCodeTextbox.Text))
                    {
                        Customer.EditAddress(customerNumberUpDown.Text, streetNameTextbox.Text, houseNumberTextbox.Text,
                            postCodeTextbox.Text, townTextbox.Text);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Please enter the correct value");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter all fields");
                }
            }
        }
}
