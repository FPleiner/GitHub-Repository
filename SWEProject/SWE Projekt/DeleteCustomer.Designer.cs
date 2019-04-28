namespace SWE_Projekt
{
    partial class DeleteCustomer
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
            this.deleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerNumberUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(354, 99);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 37);
            this.resetButton.TabIndex = 24;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(80, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "OR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "E-Mail Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Customer Number";
            // 
            // dataGridSearch
            // 
            this.dataGridSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSearch.Location = new System.Drawing.Point(9, 170);
            this.dataGridSearch.Name = "dataGridSearch";
            this.dataGridSearch.Size = new System.Drawing.Size(473, 60);
            this.dataGridSearch.TabIndex = 20;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(354, 32);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 37);
            this.searchButton.TabIndex = 19;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click_1);
            // 
            // eMailAddressTextbox
            // 
            this.eMailAddressTextbox.Location = new System.Drawing.Point(84, 116);
            this.eMailAddressTextbox.Name = "eMailAddressTextbox";
            this.eMailAddressTextbox.Size = new System.Drawing.Size(206, 20);
            this.eMailAddressTextbox.TabIndex = 18;
            this.eMailAddressTextbox.TextChanged += new System.EventHandler(this.eMailAddressTextbox_TextChanged);
            // 
            // customerNumberUpDown
            // 
            this.customerNumberUpDown.Location = new System.Drawing.Point(84, 32);
            this.customerNumberUpDown.Name = "customerNumberUpDown";
            this.customerNumberUpDown.Size = new System.Drawing.Size(206, 20);
            this.customerNumberUpDown.TabIndex = 17;
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(106, 275);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(286, 118);
            this.deleteButton.TabIndex = 25;
            this.deleteButton.Text = "DELETE";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // DeleteCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 430);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridSearch);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.eMailAddressTextbox);
            this.Controls.Add(this.customerNumberUpDown);
            this.Name = "DeleteCustomer";
            this.Text = "DeleteCustomer";
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
        private System.Windows.Forms.Button deleteButton;
    }
}