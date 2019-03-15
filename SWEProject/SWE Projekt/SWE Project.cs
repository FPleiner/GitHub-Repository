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
    public partial class CustomerDataForm : Form
    {
        private DatabaseConnection connection1;
        public CustomerDataForm()
        {
            InitializeComponent();
            connection1 = new DatabaseConnection();
            dbDisplay.Columns.Add("0", "Customer Number");
            dbDisplay.Columns.Add("1", "First Name");
            dbDisplay.Columns.Add("2", "Last Name");
            dbDisplay.Columns.Add("3", "E-Mail Adress");
            dbDisplay.Columns.Add("4", "Open Balance");
            dbDisplay.Columns.Add("5", "Last Change");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection1.Connect();
            SelectCustomer("select * from customer;");
        }
        public void SelectCustomer(string query)
        {
            List<string>[] list;
            list = connection1.Select(query);

            

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
                dbDisplay.Rows[number].Cells[6].Value = list[6][i];
            }
          
        }
    }
}