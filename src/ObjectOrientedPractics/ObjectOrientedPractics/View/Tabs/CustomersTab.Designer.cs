namespace ObjectOrientedPractics.View.Tabs
{
    partial class CustomersTab
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
            Address address2 = new Address();
            AddCustomerButton = new Button();
            RemoveCustomerButton = new Button();
            CustomersListBox = new ListBox();
            CustomersPanel = new Panel();
            label1 = new Label();
            SelectedCustomerPanel = new Panel();
            PriorityCheckBox = new CheckBox();
            CustomerFullNameTextBox = new TextBox();
            label4 = new Label();
            CustomerIdTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            DeliveryAddressPanel = new Panel();
            CustomerAddressControl = new Controls.AddressControl();
            CustomersDiscountsPanel = new Panel();
            CustomersDiscountsListBox = new ListBox();
            RemoveDiscountButton = new Button();
            label5 = new Label();
            AddDiscountButton = new Button();
            CustomersPanel.SuspendLayout();
            SelectedCustomerPanel.SuspendLayout();
            DeliveryAddressPanel.SuspendLayout();
            CustomersDiscountsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // AddCustomerButton
            // 
            AddCustomerButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddCustomerButton.Location = new Point(3, 432);
            AddCustomerButton.Name = "AddCustomerButton";
            AddCustomerButton.Size = new Size(94, 37);
            AddCustomerButton.TabIndex = 0;
            AddCustomerButton.Text = "Add";
            AddCustomerButton.UseVisualStyleBackColor = true;
            AddCustomerButton.Click += AddCustomerButton_Click;
            // 
            // RemoveCustomerButton
            // 
            RemoveCustomerButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            RemoveCustomerButton.Location = new Point(103, 432);
            RemoveCustomerButton.Name = "RemoveCustomerButton";
            RemoveCustomerButton.Size = new Size(94, 37);
            RemoveCustomerButton.TabIndex = 2;
            RemoveCustomerButton.Text = "Remove";
            RemoveCustomerButton.UseVisualStyleBackColor = true;
            RemoveCustomerButton.Click += RemoveCustomerButton_Click;
            // 
            // CustomersListBox
            // 
            CustomersListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            CustomersListBox.FormattingEnabled = true;
            CustomersListBox.ItemHeight = 15;
            CustomersListBox.Location = new Point(3, 25);
            CustomersListBox.Name = "CustomersListBox";
            CustomersListBox.Size = new Size(279, 394);
            CustomersListBox.TabIndex = 3;
            CustomersListBox.SelectedIndexChanged += CustomersListBox_SelectedIndexChanged;
            // 
            // CustomersPanel
            // 
            CustomersPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            CustomersPanel.Controls.Add(label1);
            CustomersPanel.Controls.Add(CustomersListBox);
            CustomersPanel.Controls.Add(RemoveCustomerButton);
            CustomersPanel.Controls.Add(AddCustomerButton);
            CustomersPanel.Location = new Point(3, 3);
            CustomersPanel.Name = "CustomersPanel";
            CustomersPanel.RightToLeft = RightToLeft.No;
            CustomersPanel.Size = new Size(286, 472);
            CustomersPanel.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(3, 5);
            label1.Name = "label1";
            label1.Size = new Size(73, 17);
            label1.TabIndex = 4;
            label1.Text = "Customers";
            // 
            // SelectedCustomerPanel
            // 
            SelectedCustomerPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SelectedCustomerPanel.Controls.Add(PriorityCheckBox);
            SelectedCustomerPanel.Controls.Add(CustomerFullNameTextBox);
            SelectedCustomerPanel.Controls.Add(label4);
            SelectedCustomerPanel.Controls.Add(CustomerIdTextBox);
            SelectedCustomerPanel.Controls.Add(label2);
            SelectedCustomerPanel.Controls.Add(label3);
            SelectedCustomerPanel.Location = new Point(292, 3);
            SelectedCustomerPanel.Name = "SelectedCustomerPanel";
            SelectedCustomerPanel.Size = new Size(547, 85);
            SelectedCustomerPanel.TabIndex = 5;
            // 
            // PriorityCheckBox
            // 
            PriorityCheckBox.AutoSize = true;
            PriorityCheckBox.Location = new Point(274, 21);
            PriorityCheckBox.Name = "PriorityCheckBox";
            PriorityCheckBox.Size = new Size(75, 19);
            PriorityCheckBox.TabIndex = 8;
            PriorityCheckBox.Text = "Is Priority";
            PriorityCheckBox.UseVisualStyleBackColor = true;
            PriorityCheckBox.CheckedChanged += PriorityCheckBox_CheckedChanged;
            // 
            // CustomerFullNameTextBox
            // 
            CustomerFullNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CustomerFullNameTextBox.Location = new Point(77, 51);
            CustomerFullNameTextBox.Name = "CustomerFullNameTextBox";
            CustomerFullNameTextBox.Size = new Size(467, 23);
            CustomerFullNameTextBox.TabIndex = 7;
            CustomerFullNameTextBox.TextChanged += CustomerFullNameTextBox_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 54);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 7;
            label4.Text = "Full Name:";
            // 
            // CustomerIdTextBox
            // 
            CustomerIdTextBox.Location = new Point(77, 22);
            CustomerIdTextBox.Name = "CustomerIdTextBox";
            CustomerIdTextBox.ReadOnly = true;
            CustomerIdTextBox.Size = new Size(191, 23);
            CustomerIdTextBox.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(3, 5);
            label2.Name = "label2";
            label2.Size = new Size(122, 17);
            label2.TabIndex = 6;
            label2.Text = "Selected Customer";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 25);
            label3.Name = "label3";
            label3.Size = new Size(21, 15);
            label3.TabIndex = 6;
            label3.Text = "ID:";
            // 
            // DeliveryAddressPanel
            // 
            DeliveryAddressPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DeliveryAddressPanel.Controls.Add(CustomerAddressControl);
            DeliveryAddressPanel.Location = new Point(291, 94);
            DeliveryAddressPanel.Name = "DeliveryAddressPanel";
            DeliveryAddressPanel.Size = new Size(548, 200);
            DeliveryAddressPanel.TabIndex = 7;
            // 
            // CustomerAddressControl
            // 
            address2.Apartment = "";
            address2.Building = "";
            address2.City = "";
            address2.Country = "";
            address2.Index = 100000;
            address2.Street = "";
            CustomerAddressControl.Address = address2;
            CustomerAddressControl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CustomerAddressControl.Location = new Point(1, 3);
            CustomerAddressControl.Name = "CustomerAddressControl";
            CustomerAddressControl.Size = new Size(544, 194);
            CustomerAddressControl.TabIndex = 7;
            // 
            // CustomersDiscountsPanel
            // 
            CustomersDiscountsPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CustomersDiscountsPanel.Controls.Add(CustomersDiscountsListBox);
            CustomersDiscountsPanel.Controls.Add(RemoveDiscountButton);
            CustomersDiscountsPanel.Controls.Add(label5);
            CustomersDiscountsPanel.Controls.Add(AddDiscountButton);
            CustomersDiscountsPanel.Location = new Point(291, 300);
            CustomersDiscountsPanel.Name = "CustomersDiscountsPanel";
            CustomersDiscountsPanel.Size = new Size(548, 175);
            CustomersDiscountsPanel.TabIndex = 12;
            // 
            // CustomersDiscountsListBox
            // 
            CustomersDiscountsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CustomersDiscountsListBox.FormattingEnabled = true;
            CustomersDiscountsListBox.ItemHeight = 15;
            CustomersDiscountsListBox.Location = new Point(6, 28);
            CustomersDiscountsListBox.Name = "CustomersDiscountsListBox";
            CustomersDiscountsListBox.Size = new Size(294, 94);
            CustomersDiscountsListBox.TabIndex = 15;
            // 
            // RemoveDiscountButton
            // 
            RemoveDiscountButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            RemoveDiscountButton.Location = new Point(306, 81);
            RemoveDiscountButton.Name = "RemoveDiscountButton";
            RemoveDiscountButton.Size = new Size(89, 41);
            RemoveDiscountButton.TabIndex = 14;
            RemoveDiscountButton.Text = "Remove";
            RemoveDiscountButton.UseVisualStyleBackColor = true;
            RemoveDiscountButton.Click += RemoveDiscountButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(6, 8);
            label5.Name = "label5";
            label5.Size = new Size(69, 17);
            label5.TabIndex = 12;
            label5.Text = "Discounts";
            // 
            // AddDiscountButton
            // 
            AddDiscountButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AddDiscountButton.Location = new Point(306, 28);
            AddDiscountButton.Name = "AddDiscountButton";
            AddDiscountButton.Size = new Size(89, 41);
            AddDiscountButton.TabIndex = 13;
            AddDiscountButton.Text = "Add";
            AddDiscountButton.UseVisualStyleBackColor = true;
            AddDiscountButton.Click += AddDiscountButton_Click;
            // 
            // CustomersTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(CustomersDiscountsPanel);
            Controls.Add(DeliveryAddressPanel);
            Controls.Add(SelectedCustomerPanel);
            Controls.Add(CustomersPanel);
            Name = "CustomersTab";
            Size = new Size(842, 478);
            Load += CustomersTab_Load;
            CustomersPanel.ResumeLayout(false);
            CustomersPanel.PerformLayout();
            SelectedCustomerPanel.ResumeLayout(false);
            SelectedCustomerPanel.PerformLayout();
            DeliveryAddressPanel.ResumeLayout(false);
            CustomersDiscountsPanel.ResumeLayout(false);
            CustomersDiscountsPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button AddCustomerButton;
        private Button RemoveCustomerButton;
        private ListBox CustomersListBox;
        private Panel CustomersPanel;
        private Label label1;
        private Panel SelectedCustomerPanel;
        private TextBox CustomerFullNameTextBox;
        private Label label4;
        private TextBox CustomerIdTextBox;
        private Label label2;
        private Label label3;
        private Panel DeliveryAddressPanel;
        private Controls.AddressControl CustomerAddressControl;
        private CheckBox PriorityCheckBox;
        private Panel CustomersDiscountsPanel;
        private ListBox CustomersDiscountsListBox;
        private Button RemoveDiscountButton;
        private Label label5;
        private Button AddDiscountButton;
    }
}
