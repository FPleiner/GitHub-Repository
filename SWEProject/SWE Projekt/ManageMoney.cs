using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace SWE_Projekt
{
    
    public partial class ManageMoney : Form
    {
        IController Controller=new Controller();
        ICustomer Customer=new Customer();
        public ManageMoney( )
        {
            InitializeComponent();
            
           
            //initialize the datagrid with correct parameters
            dataGridSearch.Columns.Add("0", "Customer Number");
            dataGridSearch.Columns.Add("1", "First Name");
            dataGridSearch.Columns.Add("2", "Last Name");
            dataGridSearch.Columns.Add("3", "Open Balance [€]");
            dataGridSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            
            enteredAmountTextbox.Enabled = false;
            dataGridSearch.Hide();
        }

        private void eMailAddressTextbox_TextChanged(object sender, EventArgs e) //checks input email and changes the backcolor of the textbox accordingly
        {
            bool checkMail=Controller.CheckEMail(eMailAddressTextbox.Text);

            if (checkMail)
            {
                eMailAddressTextbox.BackColor = Color.Green;

            }
            else
            {
                eMailAddressTextbox.BackColor = Color.Red;
            }
        }

        private void searchButton_Click(object sender, EventArgs e)//searches the database after the user with the given criteria and updates datagrid
        {
            Customer.ConnectWithoutMessage();
            List<string>[] list= Customer.FilterCustomerNumberAndEMail(customerNumberUpDown.Text, eMailAddressTextbox.Text);
            UpdateList(list);
            eMailAddressTextbox.Enabled = false;
            customerNumberUpDown.Enabled = false;
            enteredAmountTextbox.Enabled = true;
            dataGridSearch.Show();

        }
        public void UpdateList(List<string>[] list)//updates datagrid and gets newest data from database
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


            }

        }

        private void resetButton_Click(object sender, EventArgs e) //resets the search and disables the money input
        {
            eMailAddressTextbox.Enabled = true;
            customerNumberUpDown.Enabled = true;
            enteredAmountTextbox.Enabled = false;
            eMailAddressTextbox.BackColor = default(Color);
            eMailAddressTextbox.Text = "";
            customerNumberUpDown.Text = "";
            enteredAmountTextbox.Text = "";
            dataGridSearch.ClearSelection();
        }

        private void enteredAmountTextbox_TextChanged(object sender, EventArgs e) //checks if the entered string in the textbox is a number
        {
            if (Controller.CheckNumber(enteredAmountTextbox.Text))
            {
                enteredAmountTextbox.BackColor = Color.Green;

            }
            else
            {
                enteredAmountTextbox.BackColor = Color.Red;
            }
        }

        private void addMoneyButton_Click(object sender, EventArgs e) //adds the money to the customer                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              
        {
            if (Controller.CheckNumber(enteredAmountTextbox.Text))
            {
                Customer.CorrectBalance(customerNumberUpDown.Text,enteredAmountTextbox.Text);
            }
            this.Close();
        }

        private void customerNumberUpDown_ValueChanged(object sender, EventArgs e)
        {
           
        }
    }
}
