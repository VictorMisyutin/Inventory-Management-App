namespace Inventory_Management_App
{
    partial class Register
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
            this.RegisterUsernameBox = new System.Windows.Forms.TextBox();
            this.PasswordBox1 = new System.Windows.Forms.TextBox();
            this.PasswordBox2 = new System.Windows.Forms.TextBox();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.RegisterUsernameLabel = new System.Windows.Forms.Label();
            this.NewPasswordLabel = new System.Windows.Forms.Label();
            this.RepeatPasswordLabel = new System.Windows.Forms.Label();
            this.LoginLink = new System.Windows.Forms.LinkLabel();
            this.OrganizationDropBox = new System.Windows.Forms.ComboBox();
            this.OrganizationLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.RepeatEmailLabel = new System.Windows.Forms.Label();
            this.RepeatEmailBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // RegisterUsernameBox
            // 
            this.RegisterUsernameBox.Location = new System.Drawing.Point(174, 98);
            this.RegisterUsernameBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RegisterUsernameBox.Name = "RegisterUsernameBox";
            this.RegisterUsernameBox.Size = new System.Drawing.Size(114, 20);
            this.RegisterUsernameBox.TabIndex = 0;
            // 
            // PasswordBox1
            // 
            this.PasswordBox1.Location = new System.Drawing.Point(174, 147);
            this.PasswordBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PasswordBox1.MaxLength = 30;
            this.PasswordBox1.Name = "PasswordBox1";
            this.PasswordBox1.PasswordChar = '*';
            this.PasswordBox1.Size = new System.Drawing.Size(114, 20);
            this.PasswordBox1.TabIndex = 1;
            // 
            // PasswordBox2
            // 
            this.PasswordBox2.Location = new System.Drawing.Point(174, 200);
            this.PasswordBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PasswordBox2.MaxLength = 30;
            this.PasswordBox2.Name = "PasswordBox2";
            this.PasswordBox2.PasswordChar = '*';
            this.PasswordBox2.Size = new System.Drawing.Size(114, 20);
            this.PasswordBox2.TabIndex = 2;
            // 
            // RegisterButton
            // 
            this.RegisterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterButton.Location = new System.Drawing.Point(276, 226);
            this.RegisterButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(66, 23);
            this.RegisterButton.TabIndex = 6;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // RegisterUsernameLabel
            // 
            this.RegisterUsernameLabel.AutoSize = true;
            this.RegisterUsernameLabel.Location = new System.Drawing.Point(172, 82);
            this.RegisterUsernameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RegisterUsernameLabel.Name = "RegisterUsernameLabel";
            this.RegisterUsernameLabel.Size = new System.Drawing.Size(55, 13);
            this.RegisterUsernameLabel.TabIndex = 4;
            this.RegisterUsernameLabel.Text = "Username";
            // 
            // NewPasswordLabel
            // 
            this.NewPasswordLabel.AutoSize = true;
            this.NewPasswordLabel.Location = new System.Drawing.Point(172, 132);
            this.NewPasswordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NewPasswordLabel.Name = "NewPasswordLabel";
            this.NewPasswordLabel.Size = new System.Drawing.Size(78, 13);
            this.NewPasswordLabel.TabIndex = 5;
            this.NewPasswordLabel.Text = "New Password";
            // 
            // RepeatPasswordLabel
            // 
            this.RepeatPasswordLabel.AutoSize = true;
            this.RepeatPasswordLabel.Location = new System.Drawing.Point(172, 184);
            this.RepeatPasswordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RepeatPasswordLabel.Name = "RepeatPasswordLabel";
            this.RepeatPasswordLabel.Size = new System.Drawing.Size(91, 13);
            this.RepeatPasswordLabel.TabIndex = 6;
            this.RepeatPasswordLabel.Text = "Repeat Password";
            // 
            // LoginLink
            // 
            this.LoginLink.AutoSize = true;
            this.LoginLink.Location = new System.Drawing.Point(266, 252);
            this.LoginLink.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LoginLink.Name = "LoginLink";
            this.LoginLink.Size = new System.Drawing.Size(97, 13);
            this.LoginLink.TabIndex = 7;
            this.LoginLink.TabStop = true;
            this.LoginLink.Text = "Already a member?";
            this.LoginLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LoginLink_LinkClicked);
            // 
            // OrganizationDropBox
            // 
            this.OrganizationDropBox.FormattingEnabled = true;
            this.OrganizationDropBox.Location = new System.Drawing.Point(324, 96);
            this.OrganizationDropBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OrganizationDropBox.Name = "OrganizationDropBox";
            this.OrganizationDropBox.Size = new System.Drawing.Size(114, 21);
            this.OrganizationDropBox.TabIndex = 3;
            // 
            // OrganizationLabel
            // 
            this.OrganizationLabel.AutoSize = true;
            this.OrganizationLabel.Location = new System.Drawing.Point(322, 80);
            this.OrganizationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.OrganizationLabel.Name = "OrganizationLabel";
            this.OrganizationLabel.Size = new System.Drawing.Size(66, 13);
            this.OrganizationLabel.TabIndex = 9;
            this.OrganizationLabel.Text = "Organization";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(322, 132);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Email";
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(324, 147);
            this.EmailBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(114, 20);
            this.EmailBox.TabIndex = 4;
            // 
            // RepeatEmailLabel
            // 
            this.RepeatEmailLabel.AutoSize = true;
            this.RepeatEmailLabel.Location = new System.Drawing.Point(322, 184);
            this.RepeatEmailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RepeatEmailLabel.Name = "RepeatEmailLabel";
            this.RepeatEmailLabel.Size = new System.Drawing.Size(70, 13);
            this.RepeatEmailLabel.TabIndex = 13;
            this.RepeatEmailLabel.Text = "Repeat Email";
            // 
            // RepeatEmailBox
            // 
            this.RepeatEmailBox.Location = new System.Drawing.Point(324, 200);
            this.RepeatEmailBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RepeatEmailBox.Name = "RepeatEmailBox";
            this.RepeatEmailBox.Size = new System.Drawing.Size(114, 20);
            this.RepeatEmailBox.TabIndex = 5;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.RepeatEmailLabel);
            this.Controls.Add(this.RepeatEmailBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.OrganizationLabel);
            this.Controls.Add(this.OrganizationDropBox);
            this.Controls.Add(this.LoginLink);
            this.Controls.Add(this.RepeatPasswordLabel);
            this.Controls.Add(this.NewPasswordLabel);
            this.Controls.Add(this.RegisterUsernameLabel);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.PasswordBox2);
            this.Controls.Add(this.PasswordBox1);
            this.Controls.Add(this.RegisterUsernameBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RegisterUsernameBox;
        private System.Windows.Forms.TextBox PasswordBox1;
        private System.Windows.Forms.TextBox PasswordBox2;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.Label RegisterUsernameLabel;
        private System.Windows.Forms.Label NewPasswordLabel;
        private System.Windows.Forms.Label RepeatPasswordLabel;
        private System.Windows.Forms.LinkLabel LoginLink;
        private System.Windows.Forms.ComboBox OrganizationDropBox;
        private System.Windows.Forms.Label OrganizationLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.Label RepeatEmailLabel;
        private System.Windows.Forms.TextBox RepeatEmailBox;
    }
}