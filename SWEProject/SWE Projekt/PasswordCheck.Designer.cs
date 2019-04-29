namespace SWE_Projekt
{
    partial class PasswordCheck
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.label_password = new System.Windows.Forms.Label();
            this.label_user = new System.Windows.Forms.Label();
            this.label_database = new System.Windows.Forms.Label();
            this.label_ServerPort = new System.Windows.Forms.Label();
            this.label_ServerAdress = new System.Windows.Forms.Label();
            this.button_connect = new System.Windows.Forms.Button();
            this.textbox_dbuserpassword = new System.Windows.Forms.TextBox();
            this.textbox_dbuser = new System.Windows.Forms.TextBox();
            this.textbox_DB_Name = new System.Windows.Forms.TextBox();
            this.textbox_ServerPort = new System.Windows.Forms.TextBox();
            this.textbox_IPAddress = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(165, 269);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(112, 39);
            this.cancelButton.TabIndex = 32;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(9, 200);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(56, 13);
            this.label_password.TabIndex = 30;
            this.label_password.Text = "Password:";
            // 
            // label_user
            // 
            this.label_user.AutoSize = true;
            this.label_user.Location = new System.Drawing.Point(9, 157);
            this.label_user.Name = "label_user";
            this.label_user.Size = new System.Drawing.Size(32, 13);
            this.label_user.TabIndex = 29;
            this.label_user.Text = "User:";
            // 
            // label_database
            // 
            this.label_database.AutoSize = true;
            this.label_database.Location = new System.Drawing.Point(9, 112);
            this.label_database.Name = "label_database";
            this.label_database.Size = new System.Drawing.Size(56, 13);
            this.label_database.TabIndex = 28;
            this.label_database.Text = "Database:";
            // 
            // label_ServerPort
            // 
            this.label_ServerPort.AutoSize = true;
            this.label_ServerPort.Location = new System.Drawing.Point(9, 68);
            this.label_ServerPort.Name = "label_ServerPort";
            this.label_ServerPort.Size = new System.Drawing.Size(63, 13);
            this.label_ServerPort.TabIndex = 27;
            this.label_ServerPort.Text = "Server Port:";
            // 
            // label_ServerAdress
            // 
            this.label_ServerAdress.AutoSize = true;
            this.label_ServerAdress.Location = new System.Drawing.Point(9, 24);
            this.label_ServerAdress.Name = "label_ServerAdress";
            this.label_ServerAdress.Size = new System.Drawing.Size(76, 13);
            this.label_ServerAdress.TabIndex = 26;
            this.label_ServerAdress.Text = "Server Adress:";
            // 
            // button_connect
            // 
            this.button_connect.Location = new System.Drawing.Point(12, 269);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(112, 37);
            this.button_connect.TabIndex = 24;
            this.button_connect.Text = "Connect";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.button_connect_Click);
            // 
            // textbox_dbuserpassword
            // 
            this.textbox_dbuserpassword.Location = new System.Drawing.Point(112, 200);
            this.textbox_dbuserpassword.Name = "textbox_dbuserpassword";
            this.textbox_dbuserpassword.PasswordChar = '*';
            this.textbox_dbuserpassword.Size = new System.Drawing.Size(71, 20);
            this.textbox_dbuserpassword.TabIndex = 25;
            this.textbox_dbuserpassword.Text = "123456";
            // 
            // textbox_dbuser
            // 
            this.textbox_dbuser.Location = new System.Drawing.Point(112, 157);
            this.textbox_dbuser.Name = "textbox_dbuser";
            this.textbox_dbuser.Size = new System.Drawing.Size(71, 20);
            this.textbox_dbuser.TabIndex = 23;
            this.textbox_dbuser.Text = "admin";
            // 
            // textbox_DB_Name
            // 
            this.textbox_DB_Name.Location = new System.Drawing.Point(112, 112);
            this.textbox_DB_Name.Name = "textbox_DB_Name";
            this.textbox_DB_Name.Size = new System.Drawing.Size(71, 20);
            this.textbox_DB_Name.TabIndex = 22;
            this.textbox_DB_Name.Text = "mydb";
            // 
            // textbox_ServerPort
            // 
            this.textbox_ServerPort.Location = new System.Drawing.Point(112, 68);
            this.textbox_ServerPort.Name = "textbox_ServerPort";
            this.textbox_ServerPort.Size = new System.Drawing.Size(71, 20);
            this.textbox_ServerPort.TabIndex = 21;
            this.textbox_ServerPort.Text = "3306";
            // 
            // textbox_IPAddress
            // 
            this.textbox_IPAddress.Location = new System.Drawing.Point(112, 24);
            this.textbox_IPAddress.Name = "textbox_IPAddress";
            this.textbox_IPAddress.Size = new System.Drawing.Size(71, 20);
            this.textbox_IPAddress.TabIndex = 20;
            this.textbox_IPAddress.Text = "127.0.0.1";
            // 
            // PasswordCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 319);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_user);
            this.Controls.Add(this.label_database);
            this.Controls.Add(this.label_ServerPort);
            this.Controls.Add(this.label_ServerAdress);
            this.Controls.Add(this.button_connect);
            this.Controls.Add(this.textbox_dbuserpassword);
            this.Controls.Add(this.textbox_dbuser);
            this.Controls.Add(this.textbox_DB_Name);
            this.Controls.Add(this.textbox_ServerPort);
            this.Controls.Add(this.textbox_IPAddress);
            this.Name = "PasswordCheck";
            this.Text = "PasswordCheck";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label label_user;
        private System.Windows.Forms.Label label_database;
        private System.Windows.Forms.Label label_ServerPort;
        private System.Windows.Forms.Label label_ServerAdress;
        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.TextBox textbox_dbuserpassword;
        private System.Windows.Forms.TextBox textbox_dbuser;
        private System.Windows.Forms.TextBox textbox_DB_Name;
        private System.Windows.Forms.TextBox textbox_ServerPort;
        private System.Windows.Forms.TextBox textbox_IPAddress;
    }
}