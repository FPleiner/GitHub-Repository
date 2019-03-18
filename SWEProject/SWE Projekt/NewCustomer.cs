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
        public NewCustomer()
        {
            InitializeComponent();
        }

        private void createCostumer_Click(object sender, EventArgs e)
        {
            
            this.Close();
            

        }

        private void eMailAdressTextbox_TextChanged(object sender, EventArgs e)
        {
            bool chekEmail = NC.CheckEMail(eMailAdressTextbox.Text);

            if (chekEmail)
            {
                eMailAdressTextbox.BackColor=Color.Green;
            }
            else
            {
                eMailAdressTextbox.BackColor = Color.Red;
            }
        }
    }
}
