namespace ObjectOrientedPractics.View.Controls
{
    partial class AddressControl
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
            AddressPanel = new Panel();
            ApartmentTextBox = new TextBox();
            BuildingTextBox = new TextBox();
            CityTextBox = new TextBox();
            StreetTextBox = new TextBox();
            CountryTextBox = new TextBox();
            IndexTextBox = new TextBox();
            CityLabel = new Label();
            StreetLabel = new Label();
            ApartmentLabel = new Label();
            BuildingLabel = new Label();
            CountryLabel = new Label();
            IndexLabel = new Label();
            MainLabel = new Label();
            AddressPanel.SuspendLayout();
            SuspendLayout();
            // 
            // AddressPanel
            // 
            AddressPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AddressPanel.Controls.Add(ApartmentTextBox);
            AddressPanel.Controls.Add(BuildingTextBox);
            AddressPanel.Controls.Add(CityTextBox);
            AddressPanel.Controls.Add(StreetTextBox);
            AddressPanel.Controls.Add(CountryTextBox);
            AddressPanel.Controls.Add(IndexTextBox);
            AddressPanel.Controls.Add(CityLabel);
            AddressPanel.Controls.Add(StreetLabel);
            AddressPanel.Controls.Add(ApartmentLabel);
            AddressPanel.Controls.Add(BuildingLabel);
            AddressPanel.Controls.Add(CountryLabel);
            AddressPanel.Controls.Add(IndexLabel);
            AddressPanel.Controls.Add(MainLabel);
            AddressPanel.Location = new Point(3, 3);
            AddressPanel.Name = "AddressPanel";
            AddressPanel.Size = new Size(526, 163);
            AddressPanel.TabIndex = 0;
            // 
            // ApartmentTextBox
            // 
            ApartmentTextBox.Anchor = AnchorStyles.Right;
            ApartmentTextBox.Location = new Point(346, 62);
            ApartmentTextBox.Name = "ApartmentTextBox";
            ApartmentTextBox.Size = new Size(164, 23);
            ApartmentTextBox.TabIndex = 12;
            ApartmentTextBox.TextChanged += ApartmentTextBox_TextChanged;
            // 
            // BuildingTextBox
            // 
            BuildingTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            BuildingTextBox.Location = new Point(63, 120);
            BuildingTextBox.Name = "BuildingTextBox";
            BuildingTextBox.Size = new Size(174, 23);
            BuildingTextBox.TabIndex = 11;
            BuildingTextBox.TextChanged += BuildingTextBox_TextChanged;
            // 
            // CityTextBox
            // 
            CityTextBox.Anchor = AnchorStyles.Right;
            CityTextBox.Location = new Point(346, 33);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.Size = new Size(165, 23);
            CityTextBox.TabIndex = 10;
            CityTextBox.TextChanged += CityTextBox_TextChanged;
            // 
            // StreetTextBox
            // 
            StreetTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            StreetTextBox.Location = new Point(63, 91);
            StreetTextBox.Name = "StreetTextBox";
            StreetTextBox.Size = new Size(174, 23);
            StreetTextBox.TabIndex = 9;
            StreetTextBox.TextChanged += StreetTextBox_TextChanged;
            // 
            // CountryTextBox
            // 
            CountryTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            CountryTextBox.Location = new Point(63, 62);
            CountryTextBox.Name = "CountryTextBox";
            CountryTextBox.Size = new Size(174, 23);
            CountryTextBox.TabIndex = 8;
            CountryTextBox.TextChanged += CountryTextBox_TextChanged;
            // 
            // IndexTextBox
            // 
            IndexTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            IndexTextBox.Location = new Point(63, 33);
            IndexTextBox.Name = "IndexTextBox";
            IndexTextBox.Size = new Size(174, 23);
            IndexTextBox.TabIndex = 7;
            IndexTextBox.TextChanged += IndexTextBox_TextChanged;
            // 
            // CityLabel
            // 
            CityLabel.Anchor = AnchorStyles.Right;
            CityLabel.AutoSize = true;
            CityLabel.Location = new Point(309, 33);
            CityLabel.Name = "CityLabel";
            CityLabel.Size = new Size(31, 15);
            CityLabel.TabIndex = 6;
            CityLabel.Text = "City:";
            // 
            // StreetLabel
            // 
            StreetLabel.AutoSize = true;
            StreetLabel.Location = new Point(17, 94);
            StreetLabel.Name = "StreetLabel";
            StreetLabel.Size = new Size(40, 15);
            StreetLabel.TabIndex = 5;
            StreetLabel.Text = "Street:";
            // 
            // ApartmentLabel
            // 
            ApartmentLabel.Anchor = AnchorStyles.Right;
            ApartmentLabel.AutoSize = true;
            ApartmentLabel.Location = new Point(273, 65);
            ApartmentLabel.Name = "ApartmentLabel";
            ApartmentLabel.Size = new Size(67, 15);
            ApartmentLabel.TabIndex = 4;
            ApartmentLabel.Text = "Apartment:";
            // 
            // BuildingLabel
            // 
            BuildingLabel.AutoSize = true;
            BuildingLabel.Location = new Point(3, 123);
            BuildingLabel.Name = "BuildingLabel";
            BuildingLabel.Size = new Size(54, 15);
            BuildingLabel.TabIndex = 3;
            BuildingLabel.Text = "Building:";
            // 
            // CountryLabel
            // 
            CountryLabel.AutoSize = true;
            CountryLabel.Location = new Point(4, 65);
            CountryLabel.Name = "CountryLabel";
            CountryLabel.Size = new Size(53, 15);
            CountryLabel.TabIndex = 2;
            CountryLabel.Text = "Country:";
            // 
            // IndexLabel
            // 
            IndexLabel.AutoSize = true;
            IndexLabel.Location = new Point(17, 36);
            IndexLabel.Name = "IndexLabel";
            IndexLabel.Size = new Size(39, 15);
            IndexLabel.TabIndex = 1;
            IndexLabel.Text = "Index:";
            // 
            // MainLabel
            // 
            MainLabel.AutoSize = true;
            MainLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            MainLabel.Location = new Point(17, 13);
            MainLabel.Name = "MainLabel";
            MainLabel.Size = new Size(113, 17);
            MainLabel.TabIndex = 0;
            MainLabel.Text = "Delivery Address";
            // 
            // AddressControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(AddressPanel);
            Name = "AddressControl";
            Size = new Size(532, 168);
            AddressPanel.ResumeLayout(false);
            AddressPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel AddressPanel;
        private Label IndexLabel;
        private Label MainLabel;
        private TextBox ApartmentTextBox;
        private TextBox BuildingTextBox;
        private TextBox CityTextBox;
        private TextBox StreetTextBox;
        private TextBox CountryTextBox;
        private TextBox IndexTextBox;
        private Label CityLabel;
        private Label StreetLabel;
        private Label ApartmentLabel;
        private Label BuildingLabel;
        private Label CountryLabel;
    }
}
