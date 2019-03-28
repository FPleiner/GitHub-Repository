namespace SWE_Projekt
{
    partial class CustomerDataForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.ConnectionButton = new System.Windows.Forms.Button();
            this.dbDisplay = new System.Windows.Forms.DataGridView();
            this.newCustomer = new System.Windows.Forms.Button();
            this.deleteCustomer = new System.Windows.Forms.Button();
            this.firstNameSearchTextbox = new System.Windows.Forms.TextBox();
            this.lastNameSearchTextbox = new System.Windows.Forms.TextBox();
            this.eMailAddressSearchTextbox = new System.Windows.Forms.TextBox();
            this.lastChangeSearchDatetimePicker = new System.Windows.Forms.DateTimePicker();
            this.customerNumberSearchUpDown = new System.Windows.Forms.NumericUpDown();
            this.openBalanceSearchUpDown = new System.Windows.Forms.NumericUpDown();
            this.resetSearchButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusConnectionLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.exitButton = new System.Windows.Forms.Button();
            this.manageMoneyButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dbDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerNumberSearchUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.openBalanceSearchUpDown)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConnectionButton
            // 
            this.ConnectionButton.Location = new System.Drawing.Point(12, 12);
            this.ConnectionButton.Name = "ConnectionButton";
            this.ConnectionButton.Size = new System.Drawing.Size(115, 35);
            this.ConnectionButton.TabIndex = 0;
            this.ConnectionButton.Text = "Connect";
            this.ConnectionButton.UseVisualStyleBackColor = true;
            this.ConnectionButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // dbDisplay
            // 
            this.dbDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbDisplay.Location = new System.Drawing.Point(144, 80);
            this.dbDisplay.Name = "dbDisplay";
            this.dbDisplay.RowHeadersWidth = 100;
            this.dbDisplay.Size = new System.Drawing.Size(1200, 646);
            this.dbDisplay.TabIndex = 1;
            // 
            // newCustomer
            // 
            this.newCustomer.Location = new System.Drawing.Point(12, 69);
            this.newCustomer.Name = "newCustomer";
            this.newCustomer.Size = new System.Drawing.Size(115, 35);
            this.newCustomer.TabIndex = 0;
            this.newCustomer.Text = "New Costumer";
            this.newCustomer.UseVisualStyleBackColor = true;
            this.newCustomer.Click += new System.EventHandler(this.newCustomer_Click);
            // 
            // deleteCustomer
            // 
            this.deleteCustomer.Location = new System.Drawing.Point(12, 617);
            this.deleteCustomer.Name = "deleteCustomer";
            this.deleteCustomer.Size = new System.Drawing.Size(115, 35);
            this.deleteCustomer.TabIndex = 0;
            this.deleteCustomer.Text = "Delete Customer";
            this.deleteCustomer.UseVisualStyleBackColor = true;
            this.deleteCustomer.Click += new System.EventHandler(this.deleteCustomer_Click);
            // 
            // firstNameSearchTextbox
            // 
            this.firstNameSearchTextbox.Location = new System.Drawing.Point(177, 40);
            this.firstNameSearchTextbox.Name = "firstNameSearchTextbox";
            this.firstNameSearchTextbox.Size = new System.Drawing.Size(143, 20);
            this.firstNameSearchTextbox.TabIndex = 3;
            this.firstNameSearchTextbox.TextChanged += new System.EventHandler(this.firstNameSearchTextbox_TextChanged);
            // 
            // lastNameSearchTextbox
            // 
            this.lastNameSearchTextbox.Location = new System.Drawing.Point(364, 41);
            this.lastNameSearchTextbox.Name = "lastNameSearchTextbox";
            this.lastNameSearchTextbox.Size = new System.Drawing.Size(143, 20);
            this.lastNameSearchTextbox.TabIndex = 4;
            this.lastNameSearchTextbox.TextChanged += new System.EventHandler(this.lastNameSearchTextbox_TextChanged);
            // 
            // eMailAddressSearchTextbox
            // 
            this.eMailAddressSearchTextbox.Location = new System.Drawing.Point(548, 40);
            this.eMailAddressSearchTextbox.Name = "eMailAddressSearchTextbox";
            this.eMailAddressSearchTextbox.Size = new System.Drawing.Size(143, 20);
            this.eMailAddressSearchTextbox.TabIndex = 5;
            this.eMailAddressSearchTextbox.TextChanged += new System.EventHandler(this.eMailAddressSearchTextbox_TextChanged);
            // 
            // lastChangeSearchDatetimePicker
            // 
            this.lastChangeSearchDatetimePicker.Location = new System.Drawing.Point(891, 40);
            this.lastChangeSearchDatetimePicker.Name = "lastChangeSearchDatetimePicker";
            this.lastChangeSearchDatetimePicker.Size = new System.Drawing.Size(200, 20);
            this.lastChangeSearchDatetimePicker.TabIndex = 8;
            this.lastChangeSearchDatetimePicker.ValueChanged += new System.EventHandler(this.lastChangeSearchDatetimePicker_ValueChanged);
            // 
            // customerNumberSearchUpDown
            // 
            this.customerNumberSearchUpDown.Location = new System.Drawing.Point(4, 41);
            this.customerNumberSearchUpDown.Name = "customerNumberSearchUpDown";
            this.customerNumberSearchUpDown.Size = new System.Drawing.Size(142, 20);
            this.customerNumberSearchUpDown.TabIndex = 9;
            this.customerNumberSearchUpDown.ValueChanged += new System.EventHandler(this.customerNumberSearchUpDown_ValueChanged);
            // 
            // openBalanceSearchUpDown
            // 
            this.openBalanceSearchUpDown.Location = new System.Drawing.Point(734, 40);
            this.openBalanceSearchUpDown.Name = "openBalanceSearchUpDown";
            this.openBalanceSearchUpDown.Size = new System.Drawing.Size(142, 20);
            this.openBalanceSearchUpDown.TabIndex = 10;
            this.openBalanceSearchUpDown.ValueChanged += new System.EventHandler(this.openBalanceSearchUpDown_ValueChanged);
            // 
            // resetSearchButton
            // 
            this.resetSearchButton.Location = new System.Drawing.Point(132, 12);
            this.resetSearchButton.Name = "resetSearchButton";
            this.resetSearchButton.Size = new System.Drawing.Size(115, 35);
            this.resetSearchButton.TabIndex = 11;
            this.resetSearchButton.Text = "Reset Search";
            this.resetSearchButton.UseVisualStyleBackColor = true;
            this.resetSearchButton.Click += new System.EventHandler(this.resetSearchButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Customer Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(173, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(360, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(544, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "E-Mail Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(730, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Open Balance";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(887, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Date of last change";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusConnectionLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 782);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(1379, 22);
            this.statusStrip1.TabIndex = 17;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusConnectionLabel
            // 
            this.toolStripStatusConnectionLabel.BackColor = System.Drawing.Color.Red;
            this.toolStripStatusConnectionLabel.Name = "toolStripStatusConnectionLabel";
            this.toolStripStatusConnectionLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripStatusConnectionLabel.Size = new System.Drawing.Size(257, 17);
            this.toolStripStatusConnectionLabel.Text = "Not Connected! Please connect to the database";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(12, 680);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(115, 35);
            this.exitButton.TabIndex = 18;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // manageMoneyButton
            // 
            this.manageMoneyButton.Location = new System.Drawing.Point(12, 136);
            this.manageMoneyButton.Name = "manageMoneyButton";
            this.manageMoneyButton.Size = new System.Drawing.Size(115, 35);
            this.manageMoneyButton.TabIndex = 19;
            this.manageMoneyButton.Text = "Manage Money";
            this.manageMoneyButton.UseVisualStyleBackColor = true;
            this.manageMoneyButton.Click += new System.EventHandler(this.manageMoneyButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lastChangeSearchDatetimePicker);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.openBalanceSearchUpDown);
            this.groupBox1.Controls.Add(this.customerNumberSearchUpDown);
            this.groupBox1.Controls.Add(this.eMailAddressSearchTextbox);
            this.groupBox1.Controls.Add(this.lastNameSearchTextbox);
            this.groupBox1.Controls.Add(this.firstNameSearchTextbox);
            this.groupBox1.Location = new System.Drawing.Point(253, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1091, 67);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Criteria";
            // 
            // CustomerDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1379, 804);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.manageMoneyButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.resetSearchButton);
            this.Controls.Add(this.dbDisplay);
            this.Controls.Add(this.deleteCustomer);
            this.Controls.Add(this.newCustomer);
            this.Controls.Add(this.ConnectionButton);
            this.Name = "CustomerDataForm";
            this.Text = "SWE Project";
            ((System.ComponentModel.ISupportInitialize)(this.dbDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerNumberSearchUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.openBalanceSearchUpDown)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConnectionButton;
        private System.Windows.Forms.DataGridView dbDisplay;
        private System.Windows.Forms.Button newCustomer;
        private System.Windows.Forms.Button deleteCustomer;
        private System.Windows.Forms.TextBox firstNameSearchTextbox;
        private System.Windows.Forms.TextBox lastNameSearchTextbox;
        private System.Windows.Forms.TextBox eMailAddressSearchTextbox;
        private System.Windows.Forms.DateTimePicker lastChangeSearchDatetimePicker;
        private System.Windows.Forms.NumericUpDown customerNumberSearchUpDown;
        private System.Windows.Forms.NumericUpDown openBalanceSearchUpDown;
        private System.Windows.Forms.Button resetSearchButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusConnectionLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button manageMoneyButton;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

