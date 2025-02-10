namespace ObjectOrientedPractics.View.Tabs
{
    partial class CartsTab
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            AmountLabel = new Label();
            AddToCartButton = new Button();
            CreateOrderButton = new Button();
            RemoveItemButton = new Button();
            ClearCartButton = new Button();
            ItemsListBox = new ListBox();
            CartListBox = new ListBox();
            CustomerComboBox = new ComboBox();
            label8 = new Label();
            TotalPriceLabel = new Label();
            DiscountPanel = new Panel();
            DiscountsCheckedListBox = new CheckedListBox();
            DiscountAmountLabel = new Label();
            label5 = new Label();
            label6 = new Label();
            DiscountPanel.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(3, 16);
            label1.Name = "label1";
            label1.Size = new Size(42, 17);
            label1.TabIndex = 0;
            label1.Text = "Items";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(300, 36);
            label2.Name = "label2";
            label2.Size = new Size(72, 17);
            label2.TabIndex = 1;
            label2.Text = "Customer:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(300, 82);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 2;
            label3.Text = "Cart:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(705, 243);
            label4.Name = "label4";
            label4.Size = new Size(62, 17);
            label4.TabIndex = 3;
            label4.Text = "Amount:";
            // 
            // AmountLabel
            // 
            AmountLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AmountLabel.AutoSize = true;
            AmountLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            AmountLabel.Location = new Point(705, 260);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(43, 30);
            AmountLabel.TabIndex = 4;
            AmountLabel.Text = "0.0";
            // 
            // AddToCartButton
            // 
            AddToCartButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddToCartButton.Location = new Point(3, 496);
            AddToCartButton.Name = "AddToCartButton";
            AddToCartButton.Size = new Size(107, 38);
            AddToCartButton.TabIndex = 5;
            AddToCartButton.Text = "Add To Cart";
            AddToCartButton.UseVisualStyleBackColor = true;
            AddToCartButton.Click += AddToCartButton_Click;
            // 
            // CreateOrderButton
            // 
            CreateOrderButton.Location = new Point(300, 293);
            CreateOrderButton.Name = "CreateOrderButton";
            CreateOrderButton.Size = new Size(107, 38);
            CreateOrderButton.TabIndex = 6;
            CreateOrderButton.Text = "Create Order";
            CreateOrderButton.UseVisualStyleBackColor = true;
            CreateOrderButton.Click += CreateOrderButton_Click;
            // 
            // RemoveItemButton
            // 
            RemoveItemButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            RemoveItemButton.Location = new Point(413, 293);
            RemoveItemButton.Name = "RemoveItemButton";
            RemoveItemButton.Size = new Size(107, 38);
            RemoveItemButton.TabIndex = 7;
            RemoveItemButton.Text = "Remove Item";
            RemoveItemButton.UseVisualStyleBackColor = true;
            RemoveItemButton.Click += RemoveItemButton_Click;
            // 
            // ClearCartButton
            // 
            ClearCartButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ClearCartButton.Location = new Point(660, 293);
            ClearCartButton.Name = "ClearCartButton";
            ClearCartButton.Size = new Size(107, 38);
            ClearCartButton.TabIndex = 8;
            ClearCartButton.Text = "Clear Cart";
            ClearCartButton.UseVisualStyleBackColor = true;
            ClearCartButton.Click += ClearCartButton_Click;
            // 
            // ItemsListBox
            // 
            ItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.ItemHeight = 15;
            ItemsListBox.Location = new Point(3, 36);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(278, 439);
            ItemsListBox.TabIndex = 9;
            // 
            // CartListBox
            // 
            CartListBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CartListBox.FormattingEnabled = true;
            CartListBox.ItemHeight = 15;
            CartListBox.Location = new Point(300, 100);
            CartListBox.Name = "CartListBox";
            CartListBox.Size = new Size(468, 139);
            CartListBox.TabIndex = 10;
            // 
            // CustomerComboBox
            // 
            CustomerComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CustomerComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CustomerComboBox.FormattingEnabled = true;
            CustomerComboBox.Location = new Point(378, 36);
            CustomerComboBox.Name = "CustomerComboBox";
            CustomerComboBox.Size = new Size(129, 23);
            CustomerComboBox.TabIndex = 11;
            CustomerComboBox.SelectedIndexChanged += CustomerComboBox_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label8.Location = new Point(705, 479);
            label8.Name = "label8";
            label8.Size = new Size(43, 17);
            label8.TabIndex = 15;
            label8.Text = "Total:";
            // 
            // TotalPriceLabel
            // 
            TotalPriceLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            TotalPriceLabel.AutoSize = true;
            TotalPriceLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            TotalPriceLabel.Location = new Point(705, 496);
            TotalPriceLabel.Name = "TotalPriceLabel";
            TotalPriceLabel.Size = new Size(43, 30);
            TotalPriceLabel.TabIndex = 16;
            TotalPriceLabel.Text = "0.0";
            // 
            // DiscountPanel
            // 
            DiscountPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DiscountPanel.Controls.Add(DiscountsCheckedListBox);
            DiscountPanel.Controls.Add(DiscountAmountLabel);
            DiscountPanel.Controls.Add(label5);
            DiscountPanel.Controls.Add(label6);
            DiscountPanel.Location = new Point(289, 338);
            DiscountPanel.Name = "DiscountPanel";
            DiscountPanel.Size = new Size(480, 138);
            DiscountPanel.TabIndex = 18;
            // 
            // DiscountsCheckedListBox
            // 
            DiscountsCheckedListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DiscountsCheckedListBox.BorderStyle = BorderStyle.None;
            DiscountsCheckedListBox.FormattingEnabled = true;
            DiscountsCheckedListBox.Location = new Point(12, 26);
            DiscountsCheckedListBox.Name = "DiscountsCheckedListBox";
            DiscountsCheckedListBox.Size = new Size(219, 90);
            DiscountsCheckedListBox.TabIndex = 22;
            DiscountsCheckedListBox.MouseUp += DiscountsCheckedListBox_MouseUp;
            // 
            // DiscountAmountLabel
            // 
            DiscountAmountLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DiscountAmountLabel.AutoSize = true;
            DiscountAmountLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            DiscountAmountLabel.Location = new Point(388, 26);
            DiscountAmountLabel.Name = "DiscountAmountLabel";
            DiscountAmountLabel.Size = new Size(43, 30);
            DiscountAmountLabel.TabIndex = 21;
            DiscountAmountLabel.Text = "0.0";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(310, 6);
            label5.Name = "label5";
            label5.Size = new Size(121, 17);
            label5.TabIndex = 19;
            label5.Text = "Discount Amount:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.Location = new Point(12, 6);
            label6.Name = "label6";
            label6.Size = new Size(73, 17);
            label6.TabIndex = 20;
            label6.Text = "Discounts:";
            // 
            // CartsTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(DiscountPanel);
            Controls.Add(TotalPriceLabel);
            Controls.Add(label8);
            Controls.Add(CustomerComboBox);
            Controls.Add(CartListBox);
            Controls.Add(ItemsListBox);
            Controls.Add(ClearCartButton);
            Controls.Add(RemoveItemButton);
            Controls.Add(CreateOrderButton);
            Controls.Add(AddToCartButton);
            Controls.Add(AmountLabel);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MinimumSize = new Size(771, 417);
            Name = "CartsTab";
            Size = new Size(771, 537);
            Load += CartsTab_Load;
            DiscountPanel.ResumeLayout(false);
            DiscountPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label AmountLabel;
        private Button AddToCartButton;
        private Button CreateOrderButton;
        private Button RemoveItemButton;
        private Button ClearCartButton;
        private ListBox ItemsListBox;
        private ListBox CartListBox;
        private ComboBox CustomerComboBox;
        private Label label8;
        private Label TotalPriceLabel;
        private Panel DiscountPanel;
        private CheckedListBox DiscountsCheckedListBox;
        private Label DiscountAmountLabel;
        private Label label5;
        private Label label6;
    }
}
