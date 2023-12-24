namespace Inventory_Management_App
{
    partial class CreateOrganization
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
            this.OrgoNameBox = new System.Windows.Forms.TextBox();
            this.LocationBox = new System.Windows.Forms.TextBox();
            this.CreateOrganizationButton = new System.Windows.Forms.Button();
            this.OrganizationNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OrgoNameBox
            // 
            this.OrgoNameBox.Location = new System.Drawing.Point(355, 159);
            this.OrgoNameBox.Name = "OrgoNameBox";
            this.OrgoNameBox.Size = new System.Drawing.Size(119, 20);
            this.OrgoNameBox.TabIndex = 0;
            // 
            // LocationBox
            // 
            this.LocationBox.Location = new System.Drawing.Point(355, 213);
            this.LocationBox.Name = "LocationBox";
            this.LocationBox.Size = new System.Drawing.Size(119, 20);
            this.LocationBox.TabIndex = 1;
            // 
            // CreateOrganizationButton
            // 
            this.CreateOrganizationButton.Location = new System.Drawing.Point(374, 239);
            this.CreateOrganizationButton.Name = "CreateOrganizationButton";
            this.CreateOrganizationButton.Size = new System.Drawing.Size(75, 23);
            this.CreateOrganizationButton.TabIndex = 2;
            this.CreateOrganizationButton.Text = "Create";
            this.CreateOrganizationButton.UseVisualStyleBackColor = true;
            this.CreateOrganizationButton.Click += new System.EventHandler(this.CreateOrganizationButton_Click);
            // 
            // OrganizationNameLabel
            // 
            this.OrganizationNameLabel.AutoSize = true;
            this.OrganizationNameLabel.Location = new System.Drawing.Point(352, 143);
            this.OrganizationNameLabel.Name = "OrganizationNameLabel";
            this.OrganizationNameLabel.Size = new System.Drawing.Size(97, 13);
            this.OrganizationNameLabel.TabIndex = 3;
            this.OrganizationNameLabel.Text = "Organization Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(352, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Location";
            // 
            // CreateOrganization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OrganizationNameLabel);
            this.Controls.Add(this.CreateOrganizationButton);
            this.Controls.Add(this.LocationBox);
            this.Controls.Add(this.OrgoNameBox);
            this.Name = "CreateOrganization";
            this.Text = "CreateOrganization";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox OrgoNameBox;
        private System.Windows.Forms.TextBox LocationBox;
        private System.Windows.Forms.Button CreateOrganizationButton;
        private System.Windows.Forms.Label OrganizationNameLabel;
        private System.Windows.Forms.Label label1;
    }
}