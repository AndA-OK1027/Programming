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
            label4.Location = new Point(667, 268);
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
            AmountLabel.Location = new Point(667, 285);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(43, 30);
            AmountLabel.TabIndex = 4;
            AmountLabel.Text = "0.0";
            // 
            // AddToCartButton
            // 
            AddToCartButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddToCartButton.Location = new Point(3, 376);
            AddToCartButton.Name = "AddToCartButton";
            AddToCartButton.Size = new Size(107, 38);
            AddToCartButton.TabIndex = 5;
            AddToCartButton.Text = "Add To Cart";
            AddToCartButton.UseVisualStyleBackColor = true;
            AddToCartButton.Click += AddToCartButton_Click;
            // 
            // CreateOrderButton
            // 
            CreateOrderButton.Location = new Point(300, 376);
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
            RemoveItemButton.Location = new Point(545, 376);
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
            ClearCartButton.Location = new Point(658, 376);
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
            ItemsListBox.Size = new Size(278, 334);
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
            // CartsTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
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
            Size = new Size(771, 417);
            Load += CartsTab_Load;
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
    }
}
