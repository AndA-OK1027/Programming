﻿
namespace ObjectOrientedPractics
{
    partial class UsersTab
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CustomersListBox = new System.Windows.Forms.ListBox();
            this.ButtonsPanel = new System.Windows.Forms.Panel();
            this.RemoveUserButton = new System.Windows.Forms.Button();
            this.AddUserButton = new System.Windows.Forms.Button();
            this.UsersLabel = new System.Windows.Forms.Label();
            this.SelectedUserLabel = new System.Windows.Forms.Label();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.IDLabel = new System.Windows.Forms.Label();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.FormAddressControl = new ObjectOrientedPractics.AddressControl();
            this.addressControl1 = new ObjectOrientedPractics.AddressControl();
            this.ButtonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomersListBox
            // 
            this.CustomersListBox.FormattingEnabled = true;
            this.CustomersListBox.Location = new System.Drawing.Point(3, 28);
            this.CustomersListBox.MinimumSize = new System.Drawing.Size(187, 316);
            this.CustomersListBox.Name = "CustomersListBox";
            this.CustomersListBox.Size = new System.Drawing.Size(231, 394);
            this.CustomersListBox.TabIndex = 1;
            this.CustomersListBox.SelectedIndexChanged += new System.EventHandler(this.CustomersListBox_SelectedIndexChanged);
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonsPanel.Controls.Add(this.RemoveUserButton);
            this.ButtonsPanel.Controls.Add(this.AddUserButton);
            this.ButtonsPanel.Location = new System.Drawing.Point(3, 428);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Size = new System.Drawing.Size(231, 72);
            this.ButtonsPanel.TabIndex = 4;
            // 
            // RemoveUserButton
            // 
            this.RemoveUserButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RemoveUserButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RemoveUserButton.Location = new System.Drawing.Point(128, 11);
            this.RemoveUserButton.Name = "RemoveUserButton";
            this.RemoveUserButton.Size = new System.Drawing.Size(100, 50);
            this.RemoveUserButton.TabIndex = 2;
            this.RemoveUserButton.Text = "Remove";
            this.RemoveUserButton.UseVisualStyleBackColor = true;
            this.RemoveUserButton.Click += new System.EventHandler(this.RemoveUserButton_Click);
            // 
            // AddUserButton
            // 
            this.AddUserButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddUserButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddUserButton.Location = new System.Drawing.Point(5, 11);
            this.AddUserButton.Name = "AddUserButton";
            this.AddUserButton.Size = new System.Drawing.Size(100, 50);
            this.AddUserButton.TabIndex = 1;
            this.AddUserButton.Text = "Add";
            this.AddUserButton.UseVisualStyleBackColor = true;
            this.AddUserButton.Click += new System.EventHandler(this.AddUserButton_Click);
            // 
            // UsersLabel
            // 
            this.UsersLabel.AutoSize = true;
            this.UsersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UsersLabel.Location = new System.Drawing.Point(3, 5);
            this.UsersLabel.Name = "UsersLabel";
            this.UsersLabel.Size = new System.Drawing.Size(105, 20);
            this.UsersLabel.TabIndex = 10;
            this.UsersLabel.Text = "Customers: ";
            // 
            // SelectedUserLabel
            // 
            this.SelectedUserLabel.AutoSize = true;
            this.SelectedUserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectedUserLabel.Location = new System.Drawing.Point(240, 5);
            this.SelectedUserLabel.Name = "SelectedUserLabel";
            this.SelectedUserLabel.Size = new System.Drawing.Size(172, 20);
            this.SelectedUserLabel.TabIndex = 11;
            this.SelectedUserLabel.Text = "Selected Customer: ";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(321, 46);
            this.IdTextBox.MinimumSize = new System.Drawing.Size(138, 20);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.ReadOnly = true;
            this.IdTextBox.Size = new System.Drawing.Size(138, 20);
            this.IdTextBox.TabIndex = 12;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTextBox.Location = new System.Drawing.Point(321, 75);
            this.NameTextBox.MinimumSize = new System.Drawing.Size(265, 20);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(265, 20);
            this.NameTextBox.TabIndex = 13;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            this.NameTextBox.Leave += new System.EventHandler(this.NameTextBox_Leave);
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IDLabel.Location = new System.Drawing.Point(290, 46);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(24, 16);
            this.IDLabel.TabIndex = 14;
            this.IDLabel.Text = "Id: ";
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FullNameLabel.Location = new System.Drawing.Point(240, 76);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(74, 16);
            this.FullNameLabel.TabIndex = 15;
            this.FullNameLabel.Text = "Full Name: ";
            // 
            // FormAddressControl
            // 
            this.FormAddressControl.Location = new System.Drawing.Point(237, 101);
            this.FormAddressControl.Name = "FormAddressControl";
            this.FormAddressControl.Size = new System.Drawing.Size(352, 168);
            this.FormAddressControl.TabIndex = 16;
            // 
            // addressControl1
            // 
            this.addressControl1.Location = new System.Drawing.Point(237, 101);
            this.addressControl1.Name = "addressControl1";
            this.addressControl1.Size = new System.Drawing.Size(352, 147);
            this.addressControl1.TabIndex = 16;
            // 
            // UsersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FormAddressControl);
            this.Controls.Add(this.FullNameLabel);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.SelectedUserLabel);
            this.Controls.Add(this.UsersLabel);
            this.Controls.Add(this.ButtonsPanel);
            this.Controls.Add(this.CustomersListBox);
            this.MinimumSize = new System.Drawing.Size(589, 507);
            this.Name = "UsersTab";
            this.Size = new System.Drawing.Size(589, 507);
            this.ButtonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox CustomersListBox;
        private System.Windows.Forms.Panel ButtonsPanel;
        private System.Windows.Forms.Button RemoveUserButton;
        private System.Windows.Forms.Button AddUserButton;
        private System.Windows.Forms.Label UsersLabel;
        private System.Windows.Forms.Label SelectedUserLabel;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label FullNameLabel;
        private AddressControl FormAddressControl;
        private AddressControl addressControl1;
    }
}
