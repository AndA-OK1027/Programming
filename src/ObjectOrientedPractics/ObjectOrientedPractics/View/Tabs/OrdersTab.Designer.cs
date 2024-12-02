namespace ObjectOrientedPractics.View.Tabs
{
    partial class OrdersTab
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
            addressControl1 = new Controls.AddressControl();
            IdTextBox = new TextBox();
            DateTextBox = new TextBox();
            StatusComboBox = new ComboBox();
            OrdersDataGridView = new DataGridView();
            OrderItemsListBox = new ListBox();
            label6 = new Label();
            label7 = new Label();
            AmountLabel = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label8 = new Label();
            label9 = new Label();
            PriorityOptionsPanel = new Panel();
            DeliveryTimeComboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)OrdersDataGridView).BeginInit();
            PriorityOptionsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // addressControl1
            // 
            address1.Apartment = "101";
            address1.Building = "40";
            address1.City = "Tomsk";
            address1.Country = "Russia";
            address1.Index = 634000;
            address1.Street = "Lenina";
            addressControl1.Address = address1;
            addressControl1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            addressControl1.Enabled = false;
            addressControl1.Location = new Point(405, 158);
            addressControl1.Name = "addressControl1";
            addressControl1.Size = new Size(609, 163);
            addressControl1.TabIndex = 41;
            // 
            // IdTextBox
            // 
            IdTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            IdTextBox.Location = new Point(491, 36);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.ReadOnly = true;
            IdTextBox.Size = new Size(179, 23);
            IdTextBox.TabIndex = 40;
            // 
            // DateTextBox
            // 
            DateTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DateTextBox.Location = new Point(491, 65);
            DateTextBox.Name = "DateTextBox";
            DateTextBox.ReadOnly = true;
            DateTextBox.Size = new Size(179, 23);
            DateTextBox.TabIndex = 39;
            // 
            // StatusComboBox
            // 
            StatusComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            StatusComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            StatusComboBox.FormattingEnabled = true;
            StatusComboBox.Location = new Point(491, 94);
            StatusComboBox.Name = "StatusComboBox";
            StatusComboBox.Size = new Size(179, 23);
            StatusComboBox.TabIndex = 38;
            StatusComboBox.SelectedIndexChanged += StatusComboBox_SelectedIndexChanged;
            // 
            // OrdersDataGridView
            // 
            OrdersDataGridView.AllowUserToAddRows = false;
            OrdersDataGridView.AllowUserToDeleteRows = false;
            OrdersDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            OrdersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrdersDataGridView.Location = new Point(3, 25);
            OrdersDataGridView.MultiSelect = false;
            OrdersDataGridView.Name = "OrdersDataGridView";
            OrdersDataGridView.ReadOnly = true;
            OrdersDataGridView.Size = new Size(390, 592);
            OrdersDataGridView.TabIndex = 37;
            OrdersDataGridView.SelectionChanged += OrdersDataGridView_SelectionChanged;
            // 
            // OrderItemsListBox
            // 
            OrderItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            OrderItemsListBox.FormattingEnabled = true;
            OrderItemsListBox.ItemHeight = 15;
            OrderItemsListBox.Location = new Point(407, 371);
            OrderItemsListBox.Name = "OrderItemsListBox";
            OrderItemsListBox.Size = new Size(628, 154);
            OrderItemsListBox.TabIndex = 36;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.Location = new Point(407, 334);
            label6.Name = "label6";
            label6.Size = new Size(81, 17);
            label6.TabIndex = 35;
            label6.Text = "Order Items";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label7.Location = new Point(407, 540);
            label7.Name = "label7";
            label7.Size = new Size(62, 17);
            label7.TabIndex = 34;
            label7.Text = "Amount:";
            // 
            // AmountLabel
            // 
            AmountLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AmountLabel.AutoSize = true;
            AmountLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            AmountLabel.Location = new Point(409, 570);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(43, 30);
            AmountLabel.TabIndex = 33;
            AmountLabel.Text = "0.0";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(411, 97);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 32;
            label5.Text = "Status:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(411, 68);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 31;
            label4.Text = "Created:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(411, 41);
            label3.Name = "label3";
            label3.Size = new Size(21, 15);
            label3.TabIndex = 30;
            label3.Text = "ID:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(405, 5);
            label2.Name = "label2";
            label2.Size = new Size(98, 17);
            label2.TabIndex = 29;
            label2.Text = "Selected Order";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(6, 5);
            label1.Name = "label1";
            label1.Size = new Size(49, 17);
            label1.TabIndex = 28;
            label1.Text = "Orders";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label8.Location = new Point(3, 5);
            label8.Name = "label8";
            label8.Size = new Size(107, 17);
            label8.TabIndex = 42;
            label8.Text = "Priority Options";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Location = new Point(3, 41);
            label9.Name = "label9";
            label9.Size = new Size(81, 15);
            label9.TabIndex = 43;
            label9.Text = "Delivery Time:";
            // 
            // PriorityOptionsPanel
            // 
            PriorityOptionsPanel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PriorityOptionsPanel.Controls.Add(DeliveryTimeComboBox);
            PriorityOptionsPanel.Controls.Add(label8);
            PriorityOptionsPanel.Controls.Add(label9);
            PriorityOptionsPanel.Location = new Point(676, 3);
            PriorityOptionsPanel.Name = "PriorityOptionsPanel";
            PriorityOptionsPanel.Size = new Size(237, 117);
            PriorityOptionsPanel.TabIndex = 44;
            // 
            // DeliveryTimeComboBox
            // 
            DeliveryTimeComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DeliveryTimeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            DeliveryTimeComboBox.FormattingEnabled = true;
            DeliveryTimeComboBox.Location = new Point(90, 36);
            DeliveryTimeComboBox.Name = "DeliveryTimeComboBox";
            DeliveryTimeComboBox.Size = new Size(126, 23);
            DeliveryTimeComboBox.TabIndex = 45;
            DeliveryTimeComboBox.SelectedIndexChanged += DeliveryTimeComboBox_SelectedIndexChanged;
            // 
            // OrdersTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(PriorityOptionsPanel);
            Controls.Add(addressControl1);
            Controls.Add(IdTextBox);
            Controls.Add(DateTextBox);
            Controls.Add(StatusComboBox);
            Controls.Add(OrdersDataGridView);
            Controls.Add(OrderItemsListBox);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(AmountLabel);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "OrdersTab";
            Size = new Size(1038, 636);
            Load += OrdersTab_Load;
            ((System.ComponentModel.ISupportInitialize)OrdersDataGridView).EndInit();
            PriorityOptionsPanel.ResumeLayout(false);
            PriorityOptionsPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Controls.AddressControl addressControl1;
        private TextBox IdTextBox;
        private TextBox DateTextBox;
        private ComboBox StatusComboBox;
        private DataGridView OrdersDataGridView;
        private ListBox OrderItemsListBox;
        private Label label6;
        private Label label7;
        private Label AmountLabel;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label8;
        private Label label9;
        private Panel PriorityOptionsPanel;
        private ComboBox DeliveryTimeComboBox;
    }
}
