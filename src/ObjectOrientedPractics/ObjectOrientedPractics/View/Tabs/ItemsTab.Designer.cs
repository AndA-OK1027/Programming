namespace ObjectOrientedPractics.View.Tabs
{
    partial class ItemsTab
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            ItemsPanel = new Panel();
            RemoveItemButton = new Button();
            AddItemButton = new Button();
            ItemsListBox = new ListBox();
            label2 = new Label();
            SelectedItemPanel = new Panel();
            CategoryComboBox = new ComboBox();
            NameTextBox = new TextBox();
            InfoTextBox = new TextBox();
            CostTextBox = new TextBox();
            IdTextBox = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            ItemsPanel.SuspendLayout();
            SelectedItemPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ItemsPanel
            // 
            ItemsPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ItemsPanel.Controls.Add(RemoveItemButton);
            ItemsPanel.Controls.Add(AddItemButton);
            ItemsPanel.Controls.Add(ItemsListBox);
            ItemsPanel.Controls.Add(label2);
            ItemsPanel.Location = new Point(3, 3);
            ItemsPanel.Name = "ItemsPanel";
            ItemsPanel.Size = new Size(287, 501);
            ItemsPanel.TabIndex = 0;
            // 
            // RemoveItemButton
            // 
            RemoveItemButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            RemoveItemButton.Location = new Point(103, 461);
            RemoveItemButton.Name = "RemoveItemButton";
            RemoveItemButton.Size = new Size(94, 37);
            RemoveItemButton.TabIndex = 4;
            RemoveItemButton.Text = "Remove";
            RemoveItemButton.UseVisualStyleBackColor = true;
            RemoveItemButton.Click += RemoveItemButton_Click;
            // 
            // AddItemButton
            // 
            AddItemButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddItemButton.Location = new Point(3, 461);
            AddItemButton.Name = "AddItemButton";
            AddItemButton.Size = new Size(94, 37);
            AddItemButton.TabIndex = 3;
            AddItemButton.Text = "Add";
            AddItemButton.UseVisualStyleBackColor = true;
            AddItemButton.Click += AddItemButton_Click;
            // 
            // ItemsListBox
            // 
            ItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.ItemHeight = 15;
            ItemsListBox.Location = new Point(5, 24);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(279, 424);
            ItemsListBox.TabIndex = 2;
            ItemsListBox.SelectedIndexChanged += ItemsListBox_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(5, 4);
            label2.Name = "label2";
            label2.Size = new Size(42, 17);
            label2.TabIndex = 1;
            label2.Text = "Items";
            // 
            // SelectedItemPanel
            // 
            SelectedItemPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SelectedItemPanel.Controls.Add(CategoryComboBox);
            SelectedItemPanel.Controls.Add(NameTextBox);
            SelectedItemPanel.Controls.Add(InfoTextBox);
            SelectedItemPanel.Controls.Add(CostTextBox);
            SelectedItemPanel.Controls.Add(IdTextBox);
            SelectedItemPanel.Controls.Add(label7);
            SelectedItemPanel.Controls.Add(label6);
            SelectedItemPanel.Controls.Add(label5);
            SelectedItemPanel.Controls.Add(label4);
            SelectedItemPanel.Controls.Add(label3);
            SelectedItemPanel.Controls.Add(label1);
            SelectedItemPanel.Location = new Point(296, 3);
            SelectedItemPanel.Name = "SelectedItemPanel";
            SelectedItemPanel.Size = new Size(290, 464);
            SelectedItemPanel.TabIndex = 1;
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.Location = new Point(72, 89);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(140, 23);
            CategoryComboBox.TabIndex = 10;
            CategoryComboBox.SelectedIndexChanged += CategoryComboBox_SelectedIndexChanged;
            // 
            // NameTextBox
            // 
            NameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NameTextBox.Location = new Point(3, 147);
            NameTextBox.Multiline = true;
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(284, 95);
            NameTextBox.TabIndex = 9;
            NameTextBox.TextChanged += NameTextBox_TextChanged;
            // 
            // InfoTextBox
            // 
            InfoTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            InfoTextBox.Location = new Point(4, 274);
            InfoTextBox.Multiline = true;
            InfoTextBox.Name = "InfoTextBox";
            InfoTextBox.Size = new Size(284, 145);
            InfoTextBox.TabIndex = 8;
            InfoTextBox.TextChanged += InfoTextBox_TextChanged;
            // 
            // CostTextBox
            // 
            CostTextBox.Location = new Point(72, 57);
            CostTextBox.Name = "CostTextBox";
            CostTextBox.Size = new Size(140, 23);
            CostTextBox.TabIndex = 7;
            CostTextBox.TextChanged += CostTextBox_TextChanged;
            // 
            // IdTextBox
            // 
            IdTextBox.Location = new Point(72, 24);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.ReadOnly = true;
            IdTextBox.Size = new Size(140, 23);
            IdTextBox.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 255);
            label7.Name = "label7";
            label7.Size = new Size(70, 15);
            label7.TabIndex = 5;
            label7.Text = "Description:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 129);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 4;
            label6.Text = "Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 92);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 3;
            label5.Text = "Category:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 60);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 2;
            label4.Text = "Cost:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 24);
            label3.Name = "label3";
            label3.Size = new Size(21, 15);
            label3.TabIndex = 1;
            label3.Text = "ID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(3, 4);
            label1.Name = "label1";
            label1.Size = new Size(91, 17);
            label1.TabIndex = 0;
            label1.Text = "Selected Item";
            // 
            // ItemsTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SelectedItemPanel);
            Controls.Add(ItemsPanel);
            MinimumSize = new Size(589, 507);
            Name = "ItemsTab";
            Size = new Size(589, 507);
            ItemsPanel.ResumeLayout(false);
            ItemsPanel.PerformLayout();
            SelectedItemPanel.ResumeLayout(false);
            SelectedItemPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel ItemsPanel;
        private Button RemoveItemButton;
        private Button AddItemButton;
        private ListBox ItemsListBox;
        private Label label2;
        private Panel SelectedItemPanel;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private ComboBox CategoryComboBox;
        private TextBox NameTextBox;
        private TextBox InfoTextBox;
        private TextBox CostTextBox;
        private TextBox IdTextBox;
    }
}
