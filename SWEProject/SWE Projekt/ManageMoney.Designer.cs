namespace SWE_Projekt
{
    partial class ManageMoney
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
            this.customerNumberUpDown = new System.Windows.Forms.NumericUpDown();
            this.eMailAddressTextbox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.enteredAmountTextbox = new System.Windows.Forms.TextBox();
            this.dataGridSearch = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.addMoneyButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.customerNumberUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // customerNumberUpDown
            // 
            this.customerNumberUpDown.Location = new System.Drawing.Point(89, 64);
            this.customerNumberUpDown.Name = "customerNumberUpDown";
            this.customerNumberUpDown.Size = new System.Drawing.Size(206, 20);
            this.customerNumberUpDown.TabIndex = 0;
            this.customerNumberUpDown.ValueChanged += new System.EventHandler(this.customerNumberUpDown_ValueChanged);
            // 
            // eMailAddressTextbox
            // 
            this.eMailAddressTextbox.Location = new System.Drawing.Point(89, 148);
            this.eMailAddressTextbox.Name = "eMailAddressTextbox";
            this.eMailAddressTextbox.Size = new System.Drawing.Size(206, 20);
            this.eMailAddressTextbox.TabIndex = 1;
            this.eMailAddressTextbox.TextChanged += new System.EventHandler(this.eMailAddressTextbox_TextChanged);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(359, 64);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 37);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // enteredAmountTextbox
            // 
            this.enteredAmountTextbox.Location = new System.Drawing.Point(16, 361);
            this.enteredAmountTextbox.Name = "enteredAmountTextbox";
            this.enteredAmountTextbox.Size = new System.Drawing.Size(206, 20);
            this.enteredAmountTextbox.TabIndex = 3;
            this.enteredAmountTextbox.TextChanged += new System.EventHandler(this.enteredAmountTextbox_TextChanged);
            // 
            // dataGridSearch
            // 
            this.dataGridSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSearch.Location = new System.Drawing.Point(14, 202);
            this.dataGridSearch.Name = "dataGridSearch";
            this.dataGridSearch.Size = new System.Drawing.Size(473, 60);
            this.dataGridSearch.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Customer Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "E-Mail Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(85, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "OR";
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(359, 131);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 37);
            this.resetButton.TabIndex = 8;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "enter Amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(226, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(261, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "positive Balance = add money owed";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(228, 359);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(260, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "negative Balance = add money paid";
            // 
            // addMoneyButton
            // 
            this.addMoneyButton.Location = new System.Drawing.Point(319, 382);
            this.addMoneyButton.Name = "addMoneyButton";
            this.addMoneyButton.Size = new System.Drawing.Size(75, 37);
            this.addMoneyButton.TabIndex = 12;
            this.addMoneyButton.Text = "Add Money";
            this.addMoneyButton.UseVisualStyleBackColor = true;
            this.addMoneyButton.Click += new System.EventHandler(this.addMoneyButton_Click);
            // 
            // ManageMoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 431);
            this.Controls.Add(this.addMoneyButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridSearch);
            this.Controls.Add(this.enteredAmountTextbox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.eMailAddressTextbox);
            this.Controls.Add(this.customerNumberUpDown);
            this.Name = "ManageMoney";
            this.Text = "ManageMoney";
            ((System.ComponentModel.ISupportInitialize)(this.customerNumberUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown customerNumberUpDown;
        private System.Windows.Forms.TextBox eMailAddressTextbox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox enteredAmountTextbox;
        private System.Windows.Forms.DataGridView dataGridSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addMoneyButton;
    }
}