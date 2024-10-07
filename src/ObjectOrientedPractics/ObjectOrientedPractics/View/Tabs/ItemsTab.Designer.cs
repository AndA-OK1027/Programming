
namespace ObjectOrientedPractics
{
    partial class ItemsTab
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
            this.ItemsListBox = new System.Windows.Forms.ListBox();
            this.AddItemButton = new System.Windows.Forms.Button();
            this.RemoveItemButton = new System.Windows.Forms.Button();
            this.ButtonsPanel = new System.Windows.Forms.Panel();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.InfoTextBox = new System.Windows.Forms.TextBox();
            this.SelectedItemLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.CostLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.EditButton = new System.Windows.Forms.Button();
            this.ButtonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ItemsListBox
            // 
            this.ItemsListBox.FormattingEnabled = true;
            this.ItemsListBox.Location = new System.Drawing.Point(3, 28);
            this.ItemsListBox.MinimumSize = new System.Drawing.Size(187, 316);
            this.ItemsListBox.Name = "ItemsListBox";
            this.ItemsListBox.Size = new System.Drawing.Size(231, 394);
            this.ItemsListBox.TabIndex = 0;
            this.ItemsListBox.SelectedIndexChanged += new System.EventHandler(this.ItemsListBox_SelectedIndexChanged);
            // 
            // AddItemButton
            // 
            this.AddItemButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddItemButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddItemButton.Location = new System.Drawing.Point(4, 11);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.Size = new System.Drawing.Size(76, 50);
            this.AddItemButton.TabIndex = 1;
            this.AddItemButton.Text = "Add";
            this.AddItemButton.UseVisualStyleBackColor = true;
            this.AddItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
            // 
            // RemoveItemButton
            // 
            this.RemoveItemButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RemoveItemButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RemoveItemButton.Location = new System.Drawing.Point(152, 11);
            this.RemoveItemButton.Name = "RemoveItemButton";
            this.RemoveItemButton.Size = new System.Drawing.Size(76, 50);
            this.RemoveItemButton.TabIndex = 2;
            this.RemoveItemButton.Text = "Remove";
            this.RemoveItemButton.UseVisualStyleBackColor = true;
            this.RemoveItemButton.Click += new System.EventHandler(this.RemoveItemButton_Click);
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonsPanel.Controls.Add(this.EditButton);
            this.ButtonsPanel.Controls.Add(this.RemoveItemButton);
            this.ButtonsPanel.Controls.Add(this.AddItemButton);
            this.ButtonsPanel.Location = new System.Drawing.Point(3, 428);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Size = new System.Drawing.Size(231, 72);
            this.ButtonsPanel.TabIndex = 3;
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(287, 40);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.ReadOnly = true;
            this.IdTextBox.Size = new System.Drawing.Size(138, 20);
            this.IdTextBox.TabIndex = 4;
            // 
            // CostTextBox
            // 
            this.CostTextBox.Location = new System.Drawing.Point(287, 68);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.Size = new System.Drawing.Size(138, 20);
            this.CostTextBox.TabIndex = 5;
            this.CostTextBox.TextChanged += new System.EventHandler(this.CostTextBox_TextChanged);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTextBox.Location = new System.Drawing.Point(240, 132);
            this.NameTextBox.MaximumSize = new System.Drawing.Size(956, 80);
            this.NameTextBox.MinimumSize = new System.Drawing.Size(346, 80);
            this.NameTextBox.Multiline = true;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(346, 80);
            this.NameTextBox.TabIndex = 6;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // InfoTextBox
            // 
            this.InfoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoTextBox.Location = new System.Drawing.Point(240, 246);
            this.InfoTextBox.MaximumSize = new System.Drawing.Size(956, 335);
            this.InfoTextBox.MinimumSize = new System.Drawing.Size(346, 176);
            this.InfoTextBox.Multiline = true;
            this.InfoTextBox.Name = "InfoTextBox";
            this.InfoTextBox.Size = new System.Drawing.Size(346, 176);
            this.InfoTextBox.TabIndex = 7;
            this.InfoTextBox.TextChanged += new System.EventHandler(this.InfoTextBox_TextChanged);
            // 
            // SelectedItemLabel
            // 
            this.SelectedItemLabel.AutoSize = true;
            this.SelectedItemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectedItemLabel.Location = new System.Drawing.Point(236, 5);
            this.SelectedItemLabel.Name = "SelectedItemLabel";
            this.SelectedItemLabel.Size = new System.Drawing.Size(126, 20);
            this.SelectedItemLabel.TabIndex = 8;
            this.SelectedItemLabel.Text = "Selected Item:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Items: ";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IDLabel.Location = new System.Drawing.Point(240, 40);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(24, 16);
            this.IDLabel.TabIndex = 10;
            this.IDLabel.Text = "Id: ";
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CostLabel.Location = new System.Drawing.Point(240, 68);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(40, 16);
            this.CostLabel.TabIndex = 11;
            this.CostLabel.Text = "Cost: ";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(240, 113);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(50, 16);
            this.NameLabel.TabIndex = 12;
            this.NameLabel.Text = "Name: ";
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoLabel.Location = new System.Drawing.Point(240, 227);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(81, 16);
            this.InfoLabel.TabIndex = 13;
            this.InfoLabel.Text = "Description: ";
            // 
            // EditButton
            // 
            this.EditButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EditButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EditButton.Location = new System.Drawing.Point(86, 11);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(60, 50);
            this.EditButton.TabIndex = 3;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // ItemsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.CostLabel);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SelectedItemLabel);
            this.Controls.Add(this.InfoTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.CostTextBox);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.ButtonsPanel);
            this.Controls.Add(this.ItemsListBox);
            this.MinimumSize = new System.Drawing.Size(589, 507);
            this.Name = "ItemsTab";
            this.Size = new System.Drawing.Size(589, 507);
            this.ButtonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ItemsListBox;
        private System.Windows.Forms.Button AddItemButton;
        private System.Windows.Forms.Button RemoveItemButton;
        private System.Windows.Forms.Panel ButtonsPanel;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.TextBox CostTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox InfoTextBox;
        private System.Windows.Forms.Label SelectedItemLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.Button EditButton;
    }
}
