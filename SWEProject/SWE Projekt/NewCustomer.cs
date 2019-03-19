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
    
    public partial class NewCustomer : Form
    {
        IController NC = new Controller();
        ICustomer NCostumer = new Customer();
        public NewCustomer()
        {
            InitializeComponent();
        }

        private void createCostumer_Click(object sender, EventArgs e)
        {

            if(string.IsNullOrWhiteSpace(firstNameTextbox.Text)==false && string.IsNullOrWhiteSpace(lastNameTextbox.Text)==false && NC.CheckEMail(eMailAdressTextbox.Text)&&NC.CheckNumber(balanceTextbox.Text))
            {
                
                NCostumer.AddCustomer(firstNameTextbox.Text, lastNameTextbox.Text, eMailAdressTextbox.Text, balanceTextbox.Text);
                this.Close();
               
            }
            else
            {
                MessageBox.Show("Please enter all fields correctly");
            }
            
            

        }

        private void eMailAdressTextbox_TextChanged(object sender, EventArgs e)
        {
            bool checkEmail = NC.CheckEMail(eMailAdressTextbox.Text);

            if (checkEmail)
            {
                eMailAdressTextbox.BackColor=Color.Green;

            }
            else
            {
                eMailAdressTextbox.BackColor = Color.Red;
            }
        }
        private void balanceTextbox_TextChanged(object sender, EventArgs e)
        {
            
            bool checkNumber = NC.CheckNumber(balanceTextbox.Text);

            if (checkNumber)
            {
                balanceTextbox.BackColor = Color.Green;

            }
            else
            {
                balanceTextbox.BackColor = Color.Red;
            }
        }
            private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
