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
    public partial class DeleteCustomer : Form
    {
        IController Controller = new Controller();
        ICustomer Customer = new Customer();
        string path = Path.GetFullPath("log.txt");
        public DeleteCustomer()
        {
            InitializeComponent();
            deleteButton.Enabled = false;
            
           

            //initializes datagrid with correct parameters
            dataGridSearch.Columns.Add("0", "Customer Number");
            dataGridSearch.Columns.Add("1", "First Name");
            dataGridSearch.Columns.Add("2", "Last Name");
            dataGridSearch.Columns.Add("3", "Open Balance [€]");
            dataGridSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;



            dataGridSearch.Hide();
        }

       
        public void UpdateList(List<string>[] list) //updates the datagrid by getting the newest list from the database
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

     

        private void deleteButton_Click(object sender, EventArgs e)//deletes the customer from the system. OR shows error if the open balance is not 0
        {
            if (!(customerNumberUpDown.Text == "0"))
            {
                if (Customer.CheckBalance(customerNumberUpDown.Text))
                {
                    Customer.DeleteCustomer(customerNumberUpDown.Text);
                    using (StreamWriter log = File.AppendText(path))
                    {
                        log.WriteLine("" + DateTime.Now + " : Customer delete: CustomerNumber = " +
                                      customerNumberUpDown.Text + ";");
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("The balance has to be 0 before deleting a customer");
                }
            }
            else
            {
                MessageBox.Show("Please choose a Customer!");
            }
        }

        private void searchButton_Click_1(object sender, EventArgs e) // enables the delete button and activates the datagrid with found customer
        {
            Customer.ConnectWithoutMessage();
            List<string>[] list = Customer.FilterCustomerNumberAndEMail(customerNumberUpDown.Text, eMailAddressTextbox.Text);
            UpdateList(list);
            eMailAddressTextbox.Enabled = false;
            customerNumberUpDown.Enabled = false;
            deleteButton.Enabled = true;
            dataGridSearch.Show();
        }

        private void resetButton_Click_1(object sender, EventArgs e) //resets the search and also disables the delete button
        {
            eMailAddressTextbox.Enabled = true;
            customerNumberUpDown.Enabled = true;
            deleteButton.Enabled = false;
            eMailAddressTextbox.BackColor = default(Color);
            eMailAddressTextbox.Text = "";
            customerNumberUpDown.Text = "";

            dataGridSearch.ClearSelection();
        }

        private void eMailAddressTextbox_TextChanged(object sender, EventArgs e) //checks Email
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
    }
}
