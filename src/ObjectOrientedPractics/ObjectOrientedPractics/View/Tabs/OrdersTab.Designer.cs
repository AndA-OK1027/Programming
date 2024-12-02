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
            OrdersAddressControl = new Controls.AddressControl();
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
            ((System.ComponentModel.ISupportInitialize)OrdersDataGridView).BeginInit();
            SuspendLayout();
            // 
            // OrdersAddressControl
            // 
            OrdersAddressControl.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            OrdersAddressControl.Enabled = false;
            OrdersAddressControl.Location = new Point(348, 178);
            OrdersAddressControl.Name = "OrdersAddressControl";
            OrdersAddressControl.Size = new Size(471, 163);
            OrdersAddressControl.TabIndex = 41;
            // 
            // IdTextBox
            // 
            IdTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            IdTextBox.Location = new Point(434, 56);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.ReadOnly = true;
            IdTextBox.Size = new Size(179, 23);
            IdTextBox.TabIndex = 40;
            // 
            // DateTextBox
            // 
            DateTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DateTextBox.Location = new Point(434, 85);
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
            StatusComboBox.Location = new Point(434, 114);
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
            OrdersDataGridView.Size = new Size(339, 572);
            OrdersDataGridView.TabIndex = 37;
            OrdersDataGridView.SelectionChanged += OrdersDataGridView_SelectionChanged;
            // 
            // OrderItemsListBox
            // 
            OrderItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            OrderItemsListBox.FormattingEnabled = true;
            OrderItemsListBox.ItemHeight = 15;
            OrderItemsListBox.Location = new Point(354, 381);
            OrderItemsListBox.Name = "OrderItemsListBox";
            OrderItemsListBox.Size = new Size(348, 139);
            OrderItemsListBox.TabIndex = 36;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.Location = new Point(354, 344);
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
            label7.Location = new Point(358, 523);
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
            AmountLabel.Location = new Point(360, 553);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(43, 30);
            AmountLabel.TabIndex = 33;
            AmountLabel.Text = "0.0";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(354, 117);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 32;
            label5.Text = "Status:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(354, 88);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 31;
            label4.Text = "Created:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(354, 61);
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
            label2.Location = new Point(348, 25);
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
            // OrdersTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(OrdersAddressControl);
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
            MinimumSize = new Size(600, 500);
            Name = "OrdersTab";
            Size = new Size(822, 616);
            Load += OrdersTab_Load;
            ((System.ComponentModel.ISupportInitialize)OrdersDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Controls.AddressControl OrdersAddressControl;
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
    }
}
