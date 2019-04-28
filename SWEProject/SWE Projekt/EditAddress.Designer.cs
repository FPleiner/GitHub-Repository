namespace SWE_Projekt
{
    partial class EditAddress
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
            this.resetButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridSearch = new System.Windows.Forms.DataGridView();
            this.searchButton = new System.Windows.Forms.Button();
            this.eMailAddressTextbox = new System.Windows.Forms.TextBox();
            this.customerNumberUpDown = new System.Windows.Forms.NumericUpDown();
            this.townTextbox = new System.Windows.Forms.TextBox();
            this.postCodeTextbox = new System.Windows.Forms.TextBox();
            this.houseNumberTextbox = new System.Windows.Forms.TextBox();
            this.streetNameTextbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerNumberUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(352, 99);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 37);
            this.resetButton.TabIndex = 16;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(78, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "OR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "E-Mail Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Customer Number";
            // 
            // dataGridSearch
            // 
            this.dataGridSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSearch.Location = new System.Drawing.Point(7, 170);
            this.dataGridSearch.Name = "dataGridSearch";
            this.dataGridSearch.Size = new System.Drawing.Size(473, 60);
            this.dataGridSearch.TabIndex = 12;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(352, 32);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 37);
            this.searchButton.TabIndex = 11;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // eMailAddressTextbox
            // 
            this.eMailAddressTextbox.Location = new System.Drawing.Point(82, 116);
            this.eMailAddressTextbox.Name = "eMailAddressTextbox";
            this.eMailAddressTextbox.Size = new System.Drawing.Size(206, 20);
            this.eMailAddressTextbox.TabIndex = 10;
            this.eMailAddressTextbox.TextChanged += new System.EventHandler(this.eMailAddressTextbox_TextChanged);
            // 
            // customerNumberUpDown
            // 
            this.customerNumberUpDown.Location = new System.Drawing.Point(82, 32);
            this.customerNumberUpDown.Name = "customerNumberUpDown";
            this.customerNumberUpDown.Size = new System.Drawing.Size(206, 20);
            this.customerNumberUpDown.TabIndex = 9;
            // 
            // townTextbox
            // 
            this.townTextbox.Location = new System.Drawing.Point(123, 412);
            this.townTextbox.Name = "townTextbox";
            this.townTextbox.Size = new System.Drawing.Size(157, 20);
            this.townTextbox.TabIndex = 24;
            // 
            // postCodeTextbox
            // 
            this.postCodeTextbox.Location = new System.Drawing.Point(123, 362);
            this.postCodeTextbox.Name = "postCodeTextbox";
            this.postCodeTextbox.Size = new System.Drawing.Size(157, 20);
            this.postCodeTextbox.TabIndex = 23;
            // 
            // houseNumberTextbox
            // 
            this.houseNumberTextbox.Location = new System.Drawing.Point(123, 309);
            this.houseNumberTextbox.Name = "houseNumberTextbox";
            this.houseNumberTextbox.Size = new System.Drawing.Size(157, 20);
            this.houseNumberTextbox.TabIndex = 22;
            // 
            // streetNameTextbox
            // 
            this.streetNameTextbox.Location = new System.Drawing.Point(123, 257);
            this.streetNameTextbox.Name = "streetNameTextbox";
            this.streetNameTextbox.Size = new System.Drawing.Size(157, 20);
            this.streetNameTextbox.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 412);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Town";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Postcode";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "House number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Street name ";
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(352, 443);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 37);
            this.editButton.TabIndex = 11;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // EditAddress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 506);
            this.Controls.Add(this.townTextbox);
            this.Controls.Add(this.postCodeTextbox);
            this.Controls.Add(this.houseNumberTextbox);
            this.Controls.Add(this.streetNameTextbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridSearch);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.eMailAddressTextbox);
            this.Controls.Add(this.customerNumberUpDown);
            this.Name = "EditAddress";
            this.Text = "EditAddress";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerNumberUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridSearch;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox eMailAddressTextbox;
        private System.Windows.Forms.NumericUpDown customerNumberUpDown;
        private System.Windows.Forms.TextBox townTextbox;
        private System.Windows.Forms.TextBox postCodeTextbox;
        private System.Windows.Forms.TextBox houseNumberTextbox;
        private System.Windows.Forms.TextBox streetNameTextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button editButton;
    }
}