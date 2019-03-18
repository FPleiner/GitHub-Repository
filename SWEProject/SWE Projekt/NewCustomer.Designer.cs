namespace SWE_Projekt
{
    partial class NewCustomer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.firstName = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.Label();
            this.eMailAdress = new System.Windows.Forms.Label();
            this.firstNameTextbox = new System.Windows.Forms.TextBox();
            this.lastNameTextbox = new System.Windows.Forms.TextBox();
            this.eMailAdressTextbox = new System.Windows.Forms.TextBox();
            this.createCostumer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstName.Location = new System.Drawing.Point(28, 47);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(86, 20);
            this.firstName.TabIndex = 0;
            this.firstName.Text = "First Name";
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName.Location = new System.Drawing.Point(28, 102);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(86, 20);
            this.lastName.TabIndex = 0;
            this.lastName.Text = "Last Name";
            // 
            // eMailAdress
            // 
            this.eMailAdress.AutoSize = true;
            this.eMailAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eMailAdress.Location = new System.Drawing.Point(28, 154);
            this.eMailAdress.Name = "eMailAdress";
            this.eMailAdress.Size = new System.Drawing.Size(107, 20);
            this.eMailAdress.TabIndex = 0;
            this.eMailAdress.Text = "E-Mail Adress";
            // 
            // firstNameTextbox
            // 
            this.firstNameTextbox.Location = new System.Drawing.Point(187, 47);
            this.firstNameTextbox.Name = "firstNameTextbox";
            this.firstNameTextbox.Size = new System.Drawing.Size(157, 20);
            this.firstNameTextbox.TabIndex = 1;
            // 
            // lastNameTextbox
            // 
            this.lastNameTextbox.Location = new System.Drawing.Point(187, 102);
            this.lastNameTextbox.Name = "lastNameTextbox";
            this.lastNameTextbox.Size = new System.Drawing.Size(157, 20);
            this.lastNameTextbox.TabIndex = 2;
            // 
            // eMailAdressTextbox
            // 
            this.eMailAdressTextbox.Location = new System.Drawing.Point(187, 154);
            this.eMailAdressTextbox.Name = "eMailAdressTextbox";
            this.eMailAdressTextbox.Size = new System.Drawing.Size(157, 20);
            this.eMailAdressTextbox.TabIndex = 3;
            this.eMailAdressTextbox.TextChanged += new System.EventHandler(this.eMailAdressTextbox_TextChanged);
            // 
            // createCostumer
            // 
            this.createCostumer.Location = new System.Drawing.Point(187, 306);
            this.createCostumer.Name = "createCostumer";
            this.createCostumer.Size = new System.Drawing.Size(157, 54);
            this.createCostumer.TabIndex = 4;
            this.createCostumer.Text = "Create";
            this.createCostumer.UseVisualStyleBackColor = true;
            this.createCostumer.Click += new System.EventHandler(this.createCostumer_Click);
            // 
            // NewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 395);
            this.Controls.Add(this.createCostumer);
            this.Controls.Add(this.eMailAdressTextbox);
            this.Controls.Add(this.lastNameTextbox);
            this.Controls.Add(this.firstNameTextbox);
            this.Controls.Add(this.eMailAdress);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.firstName);
            this.Name = "NewCustomer";
            this.Text = "New Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstName;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.Label eMailAdress;
        private System.Windows.Forms.TextBox firstNameTextbox;
        private System.Windows.Forms.TextBox lastNameTextbox;
        private System.Windows.Forms.TextBox eMailAdressTextbox;
        private System.Windows.Forms.Button createCostumer;
    }
}