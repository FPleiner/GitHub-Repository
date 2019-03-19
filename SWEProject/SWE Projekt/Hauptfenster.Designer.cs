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
            ((System.ComponentModel.ISupportInitialize)(this.dbDisplay)).BeginInit();
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
            this.dbDisplay.Location = new System.Drawing.Point(150, 12);
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
            this.deleteCustomer.Location = new System.Drawing.Point(12, 136);
            this.deleteCustomer.Name = "deleteCustomer";
            this.deleteCustomer.Size = new System.Drawing.Size(115, 35);
            this.deleteCustomer.TabIndex = 0;
            this.deleteCustomer.Text = "Delete Customer";
            this.deleteCustomer.UseVisualStyleBackColor = true;
            this.deleteCustomer.Click += new System.EventHandler(this.deleteCustomer_Click);
            // 
            // CustomerDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 771);
            this.Controls.Add(this.dbDisplay);
            this.Controls.Add(this.deleteCustomer);
            this.Controls.Add(this.newCustomer);
            this.Controls.Add(this.ConnectionButton);
            this.Name = "CustomerDataForm";
            this.Text = "SWE Project";
            ((System.ComponentModel.ISupportInitialize)(this.dbDisplay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ConnectionButton;
        private System.Windows.Forms.DataGridView dbDisplay;
        private System.Windows.Forms.Button newCustomer;
        private System.Windows.Forms.Button deleteCustomer;
    }
}

