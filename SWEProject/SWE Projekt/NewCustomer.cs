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

            if(string.IsNullOrWhiteSpace(firstNameTextbox.Text)==false && string.IsNullOrWhiteSpace(lastNameTextbox.Text)==false && NC.CheckEMail(eMailAdressTextbox.Text)&&NC.CheckNumber(balanceTextbox.Text)&&string.IsNullOrWhiteSpace(streetNameTextbox.Text)==false&&string.IsNullOrWhiteSpace(houseNumberTextbox.Text)==false&&string.IsNullOrWhiteSpace(postCodeTextbox.Text)==false&&string.IsNullOrWhiteSpace(townTextbox.Text)==false)
            {
                if (NCostumer.CheckUnique(eMailAdressTextbox.Text))
                {
                    NCostumer.AddCustomer(firstNameTextbox.Text, lastNameTextbox.Text, eMailAdressTextbox.Text,
                        balanceTextbox.Text,streetNameTextbox.Text,houseNumberTextbox.Text,postCodeTextbox.Text,townTextbox.Text);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("E-Mail address is already used");
                }
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
            if (string.IsNullOrWhiteSpace(eMailAdressTextbox.Text))
            {
                eMailAdressTextbox.ResetBackColor();
            }
        }
        private void balanceTextbox_TextChanged(object sender, EventArgs e)
        {
            
            bool checkNumber = NC.CheckNumber(balanceTextbox.Text);

            if (checkNumber)
            {
                balanceTextbox.BackColor = Color.Green;
                createCostumer.Enabled = true;
            }
            else
            {
                balanceTextbox.BackColor = Color.Red;
                createCostumer.Enabled = false;
            }
            if (string.IsNullOrWhiteSpace(balanceTextbox.Text))
            {
                balanceTextbox.ResetBackColor();
            }
        }
            private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void postCodeTextbox_TextChanged(object sender, EventArgs e)
        {
            bool checkNumber = NC.CheckNumber(postCodeTextbox.Text);

            if (checkNumber)
            {
                postCodeTextbox.BackColor = Color.Green;
                createCostumer.Enabled = true;
            }
            else
            {
                postCodeTextbox.BackColor = Color.Red;
                createCostumer.Enabled = false;
            }

            if (string.IsNullOrWhiteSpace(postCodeTextbox.Text))
            {
                postCodeTextbox.ResetBackColor();
            }
        }

        private void houseNumberTextbox_TextChanged(object sender, EventArgs e)
        {
            bool checkNumber = NC.CheckNumber(houseNumberTextbox.Text);

            if (checkNumber)
            {
                houseNumberTextbox.BackColor = Color.Green;
                createCostumer.Enabled = true;
            }
            else
            {
                houseNumberTextbox.BackColor = Color.Red;
                createCostumer.Enabled = false;
            }
            if (string.IsNullOrWhiteSpace(houseNumberTextbox.Text))
            {
                houseNumberTextbox.ResetBackColor();
            }
        }
    }
}
