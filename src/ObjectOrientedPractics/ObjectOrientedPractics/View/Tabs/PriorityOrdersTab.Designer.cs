namespace ObjectOrientedPractics.View.Tabs
{
    partial class PriorityOrdersTab
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
            Address address1 = new Address();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            AddItemButton = new Button();
            RemoveItemButton = new Button();
            ClearOrder = new Button();
            IdTextBox = new TextBox();
            AmountTextBox = new TextBox();
            DateTextBox = new TextBox();
            StatusComboBox = new ComboBox();
            DeliveryTimeComboBox = new ComboBox();
            addressControl = new Controls.AddressControl();
            OrderItemsListBox = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(98, 17);
            label1.TabIndex = 0;
            label1.Text = "Selected Order";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(302, 9);
            label2.Name = "label2";
            label2.Size = new Size(107, 17);
            label2.TabIndex = 1;
            label2.Text = "Priority Options";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 40);
            label3.Name = "label3";
            label3.Size = new Size(21, 15);
            label3.TabIndex = 2;
            label3.Text = "ID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 69);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 3;
            label4.Text = "Created:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 98);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 4;
            label5.Text = "Status:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.Location = new Point(3, 308);
            label6.Name = "label6";
            label6.Size = new Size(81, 17);
            label6.TabIndex = 5;
            label6.Text = "Order Items";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(302, 40);
            label7.Name = "label7";
            label7.Size = new Size(81, 15);
            label7.TabIndex = 6;
            label7.Text = "Delivery Time:";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label8.Location = new Point(499, 481);
            label8.Name = "label8";
            label8.Size = new Size(62, 17);
            label8.TabIndex = 7;
            label8.Text = "Amount:";
            // 
            // AddItemButton
            // 
            AddItemButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddItemButton.Location = new Point(9, 556);
            AddItemButton.Name = "AddItemButton";
            AddItemButton.Size = new Size(87, 36);
            AddItemButton.TabIndex = 8;
            AddItemButton.Text = "Add Item";
            AddItemButton.UseVisualStyleBackColor = true;
            AddItemButton.Click += AddItemButton_Click;
            // 
            // RemoveItemButton
            // 
            RemoveItemButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            RemoveItemButton.Location = new Point(102, 556);
            RemoveItemButton.Name = "RemoveItemButton";
            RemoveItemButton.Size = new Size(87, 36);
            RemoveItemButton.TabIndex = 9;
            RemoveItemButton.Text = "Remove Item";
            RemoveItemButton.UseVisualStyleBackColor = true;
            RemoveItemButton.Click += RemoveItemButton_Click;
            // 
            // ClearOrder
            // 
            ClearOrder.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ClearOrder.Location = new Point(544, 560);
            ClearOrder.Name = "ClearOrder";
            ClearOrder.Size = new Size(87, 36);
            ClearOrder.TabIndex = 10;
            ClearOrder.Text = "Clear Order";
            ClearOrder.UseVisualStyleBackColor = true;
            ClearOrder.Click += ClearOrder_Click;
            // 
            // IdTextBox
            // 
            IdTextBox.Enabled = false;
            IdTextBox.Location = new Point(60, 37);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.Size = new Size(132, 23);
            IdTextBox.TabIndex = 11;
            // 
            // AmountTextBox
            // 
            AmountTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AmountTextBox.Location = new Point(499, 501);
            AmountTextBox.Name = "AmountTextBox";
            AmountTextBox.Size = new Size(132, 23);
            AmountTextBox.TabIndex = 12;
            // 
            // DateTextBox
            // 
            DateTextBox.Enabled = false;
            DateTextBox.Location = new Point(60, 66);
            DateTextBox.Name = "DateTextBox";
            DateTextBox.Size = new Size(132, 23);
            DateTextBox.TabIndex = 13;
            // 
            // StatusComboBox
            // 
            StatusComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            StatusComboBox.FormattingEnabled = true;
            StatusComboBox.Location = new Point(60, 95);
            StatusComboBox.Name = "StatusComboBox";
            StatusComboBox.Size = new Size(132, 23);
            StatusComboBox.TabIndex = 14;
            StatusComboBox.SelectedIndexChanged += StatusComboBox_SelectedIndexChanged;
            // 
            // DeliveryTimeComboBox
            // 
            DeliveryTimeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            DeliveryTimeComboBox.FormattingEnabled = true;
            DeliveryTimeComboBox.Location = new Point(389, 37);
            DeliveryTimeComboBox.Name = "DeliveryTimeComboBox";
            DeliveryTimeComboBox.Size = new Size(132, 23);
            DeliveryTimeComboBox.TabIndex = 15;
            DeliveryTimeComboBox.SelectedIndexChanged += DeliveryTimeComboBox_SelectedIndexChanged;
            // 
            // addressControl
            // 
            address1.Apartment = "101";
            address1.Building = "40";
            address1.City = "Tomsk";
            address1.Country = "Russia";
            address1.Index = 634000;
            address1.Street = "Lenina";
            addressControl.Address = address1;
            addressControl.Enabled = false;
            addressControl.Location = new Point(3, 137);
            addressControl.Name = "addressControl";
            addressControl.Size = new Size(631, 168);
            addressControl.TabIndex = 16;
            // 
            // OrderItemsListBox
            // 
            OrderItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            OrderItemsListBox.FormattingEnabled = true;
            OrderItemsListBox.ItemHeight = 15;
            OrderItemsListBox.Location = new Point(3, 328);
            OrderItemsListBox.Name = "OrderItemsListBox";
            OrderItemsListBox.Size = new Size(628, 139);
            OrderItemsListBox.TabIndex = 17;
            // 
            // PriorityOrdersTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(OrderItemsListBox);
            Controls.Add(addressControl);
            Controls.Add(DeliveryTimeComboBox);
            Controls.Add(StatusComboBox);
            Controls.Add(DateTextBox);
            Controls.Add(AmountTextBox);
            Controls.Add(IdTextBox);
            Controls.Add(ClearOrder);
            Controls.Add(RemoveItemButton);
            Controls.Add(AddItemButton);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "PriorityOrdersTab";
            Size = new Size(634, 599);
            Load += PriorityOrdersTab_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button AddItemButton;
        private Button RemoveItemButton;
        private Button ClearOrder;
        private TextBox IdTextBox;
        private TextBox AmountTextBox;
        private TextBox DateTextBox;
        private ComboBox StatusComboBox;
        private ComboBox DeliveryTimeComboBox;
        private Controls.AddressControl addressControl;
        private ListBox OrderItemsListBox;
    }
}
