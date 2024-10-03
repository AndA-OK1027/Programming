
namespace ObjectOrientedPractics
{
    partial class MainForm
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
            this.Tabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.CostLabel = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SelectedItemLabel = new System.Windows.Forms.Label();
            this.InfoTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.ButtonsPanel = new System.Windows.Forms.Panel();
            this.RemoveItemButton = new System.Windows.Forms.Button();
            this.AddItemButton = new System.Windows.Forms.Button();
            this.ItemsListBox = new System.Windows.Forms.ListBox();
            this.Tabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.ButtonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.tabPage1);
            this.Tabs.Controls.Add(this.tabPage2);
            this.Tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tabs.Location = new System.Drawing.Point(0, 0);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(715, 571);
            this.Tabs.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.InfoLabel);
            this.tabPage1.Controls.Add(this.NameLabel);
            this.tabPage1.Controls.Add(this.CostLabel);
            this.tabPage1.Controls.Add(this.IDLabel);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.SelectedItemLabel);
            this.tabPage1.Controls.Add(this.InfoTextBox);
            this.tabPage1.Controls.Add(this.NameTextBox);
            this.tabPage1.Controls.Add(this.CostTextBox);
            this.tabPage1.Controls.Add(this.IdTextBox);
            this.tabPage1.Controls.Add(this.ButtonsPanel);
            this.tabPage1.Controls.Add(this.ItemsListBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(707, 545);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Items";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(676, 435);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Customers";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoLabel.Location = new System.Drawing.Point(284, 192);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(82, 16);
            this.InfoLabel.TabIndex = 25;
            this.InfoLabel.Text = "Description: ";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(284, 78);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(51, 16);
            this.NameLabel.TabIndex = 24;
            this.NameLabel.Text = "Name: ";
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CostLabel.Location = new System.Drawing.Point(284, 33);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(41, 16);
            this.CostLabel.TabIndex = 23;
            this.CostLabel.Text = "Cost: ";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IDLabel.Location = new System.Drawing.Point(284, 5);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(25, 16);
            this.IDLabel.TabIndex = 22;
            this.IDLabel.Text = "Id: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(47, -30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Items: ";
            // 
            // SelectedItemLabel
            // 
            this.SelectedItemLabel.AutoSize = true;
            this.SelectedItemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectedItemLabel.Location = new System.Drawing.Point(280, -30);
            this.SelectedItemLabel.Name = "SelectedItemLabel";
            this.SelectedItemLabel.Size = new System.Drawing.Size(126, 20);
            this.SelectedItemLabel.TabIndex = 20;
            this.SelectedItemLabel.Text = "Selected Item:";
            // 
            // InfoTextBox
            // 
            this.InfoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoTextBox.Location = new System.Drawing.Point(284, 211);
            this.InfoTextBox.MaximumSize = new System.Drawing.Size(956, 335);
            this.InfoTextBox.MinimumSize = new System.Drawing.Size(346, 176);
            this.InfoTextBox.Multiline = true;
            this.InfoTextBox.Name = "InfoTextBox";
            this.InfoTextBox.Size = new System.Drawing.Size(377, 286);
            this.InfoTextBox.TabIndex = 19;
            this.InfoTextBox.TextChanged += new System.EventHandler(this.InfoTextBox_TextChanged);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTextBox.Location = new System.Drawing.Point(284, 97);
            this.NameTextBox.MaximumSize = new System.Drawing.Size(956, 80);
            this.NameTextBox.MinimumSize = new System.Drawing.Size(346, 80);
            this.NameTextBox.Multiline = true;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(377, 80);
            this.NameTextBox.TabIndex = 18;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // CostTextBox
            // 
            this.CostTextBox.Location = new System.Drawing.Point(331, 33);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.Size = new System.Drawing.Size(138, 20);
            this.CostTextBox.TabIndex = 17;
            this.CostTextBox.TextChanged += new System.EventHandler(this.CostTextBox_TextChanged);
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(331, 5);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.ReadOnly = true;
            this.IdTextBox.Size = new System.Drawing.Size(138, 20);
            this.IdTextBox.TabIndex = 16;
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonsPanel.Controls.Add(this.RemoveItemButton);
            this.ButtonsPanel.Controls.Add(this.AddItemButton);
            this.ButtonsPanel.Location = new System.Drawing.Point(47, 445);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Size = new System.Drawing.Size(231, 72);
            this.ButtonsPanel.TabIndex = 15;
            // 
            // RemoveItemButton
            // 
            this.RemoveItemButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RemoveItemButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RemoveItemButton.Location = new System.Drawing.Point(124, 11);
            this.RemoveItemButton.Name = "RemoveItemButton";
            this.RemoveItemButton.Size = new System.Drawing.Size(76, 50);
            this.RemoveItemButton.TabIndex = 2;
            this.RemoveItemButton.Text = "Remove";
            this.RemoveItemButton.UseVisualStyleBackColor = true;
            this.RemoveItemButton.Click += new System.EventHandler(this.RemoveItemButton_Click);
            // 
            // AddItemButton
            // 
            this.AddItemButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddItemButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddItemButton.Location = new System.Drawing.Point(30, 11);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.Size = new System.Drawing.Size(76, 50);
            this.AddItemButton.TabIndex = 1;
            this.AddItemButton.Text = "Add";
            this.AddItemButton.UseVisualStyleBackColor = true;
            this.AddItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
            // 
            // ItemsListBox
            // 
            this.ItemsListBox.FormattingEnabled = true;
            this.ItemsListBox.Location = new System.Drawing.Point(47, 33);
            this.ItemsListBox.MinimumSize = new System.Drawing.Size(187, 316);
            this.ItemsListBox.Name = "ItemsListBox";
            this.ItemsListBox.Size = new System.Drawing.Size(231, 394);
            this.ItemsListBox.TabIndex = 14;
            this.ItemsListBox.SelectedIndexChanged += new System.EventHandler(this.ItemsListBox_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 571);
            this.Controls.Add(this.Tabs);
            this.Name = "MainForm";
            this.Text = "Object oriented practics";
            this.Tabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ButtonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label SelectedItemLabel;
        private System.Windows.Forms.TextBox InfoTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox CostTextBox;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Panel ButtonsPanel;
        private System.Windows.Forms.Button RemoveItemButton;
        private System.Windows.Forms.Button AddItemButton;
        private System.Windows.Forms.ListBox ItemsListBox;
    }
}

