
namespace Programming
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Enums = new System.Windows.Forms.TabPage();
            this.SeasonHGrBox = new System.Windows.Forms.GroupBox();
            this.SeasonHandleButton = new System.Windows.Forms.Button();
            this.SeasonChooseLabel = new System.Windows.Forms.Label();
            this.WeekDPGrBox = new System.Windows.Forms.GroupBox();
            this.ParsingTextBox = new System.Windows.Forms.TextBox();
            this.WeekdayOutputLabel = new System.Windows.Forms.Label();
            this.TypeinWeekadayLabel = new System.Windows.Forms.Label();
            this.ParseButton = new System.Windows.Forms.Button();
            this.EnumerationsGrBox = new System.Windows.Forms.GroupBox();
            this.IntValueTextBox = new System.Windows.Forms.TextBox();
            this.IntValueLabel = new System.Windows.Forms.Label();
            this.ChooseLabel = new System.Windows.Forms.Label();
            this.ChooseEnumsLabel = new System.Windows.Forms.Label();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.EnumLabel = new System.Windows.Forms.Label();
            this.SeasonsHandleComboBox = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.Enums.SuspendLayout();
            this.SeasonHGrBox.SuspendLayout();
            this.WeekDPGrBox.SuspendLayout();
            this.EnumerationsGrBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Enums);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(703, 481);
            this.tabControl1.TabIndex = 0;
            // 
            // Enums
            // 
            this.Enums.BackColor = System.Drawing.Color.RosyBrown;
            this.Enums.Controls.Add(this.SeasonHGrBox);
            this.Enums.Controls.Add(this.WeekDPGrBox);
            this.Enums.Controls.Add(this.EnumerationsGrBox);
            this.Enums.Controls.Add(this.EnumLabel);
            this.Enums.Location = new System.Drawing.Point(4, 22);
            this.Enums.Name = "Enums";
            this.Enums.Size = new System.Drawing.Size(695, 455);
            this.Enums.TabIndex = 0;
            this.Enums.Text = "Enums";
            // 
            // SeasonHGrBox
            // 
            this.SeasonHGrBox.Controls.Add(this.SeasonsHandleComboBox);
            this.SeasonHGrBox.Controls.Add(this.SeasonHandleButton);
            this.SeasonHGrBox.Controls.Add(this.SeasonChooseLabel);
            this.SeasonHGrBox.Location = new System.Drawing.Point(365, 225);
            this.SeasonHGrBox.Name = "SeasonHGrBox";
            this.SeasonHGrBox.Size = new System.Drawing.Size(302, 214);
            this.SeasonHGrBox.TabIndex = 13;
            this.SeasonHGrBox.TabStop = false;
            this.SeasonHGrBox.Text = "Season Handle";
            // 
            // SeasonHandleButton
            // 
            this.SeasonHandleButton.Location = new System.Drawing.Point(149, 42);
            this.SeasonHandleButton.Name = "SeasonHandleButton";
            this.SeasonHandleButton.Size = new System.Drawing.Size(75, 20);
            this.SeasonHandleButton.TabIndex = 10;
            this.SeasonHandleButton.Text = "Go!";
            this.SeasonHandleButton.UseVisualStyleBackColor = true;
            this.SeasonHandleButton.Click += new System.EventHandler(this.SeasonHandleButton_Click);
            // 
            // SeasonChooseLabel
            // 
            this.SeasonChooseLabel.AutoSize = true;
            this.SeasonChooseLabel.Location = new System.Drawing.Point(6, 28);
            this.SeasonChooseLabel.Name = "SeasonChooseLabel";
            this.SeasonChooseLabel.Size = new System.Drawing.Size(85, 13);
            this.SeasonChooseLabel.TabIndex = 9;
            this.SeasonChooseLabel.Text = "Choose Season:";
            // 
            // WeekDPGrBox
            // 
            this.WeekDPGrBox.Controls.Add(this.ParsingTextBox);
            this.WeekDPGrBox.Controls.Add(this.WeekdayOutputLabel);
            this.WeekDPGrBox.Controls.Add(this.TypeinWeekadayLabel);
            this.WeekDPGrBox.Controls.Add(this.ParseButton);
            this.WeekDPGrBox.Location = new System.Drawing.Point(24, 225);
            this.WeekDPGrBox.Name = "WeekDPGrBox";
            this.WeekDPGrBox.Size = new System.Drawing.Size(302, 214);
            this.WeekDPGrBox.TabIndex = 12;
            this.WeekDPGrBox.TabStop = false;
            this.WeekDPGrBox.Text = "Weekday Parsing";
            // 
            // ParsingTextBox
            // 
            this.ParsingTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ParsingTextBox.Location = new System.Drawing.Point(15, 44);
            this.ParsingTextBox.Name = "ParsingTextBox";
            this.ParsingTextBox.Size = new System.Drawing.Size(162, 20);
            this.ParsingTextBox.TabIndex = 0;
            // 
            // WeekdayOutputLabel
            // 
            this.WeekdayOutputLabel.AutoSize = true;
            this.WeekdayOutputLabel.Location = new System.Drawing.Point(12, 77);
            this.WeekdayOutputLabel.Name = "WeekdayOutputLabel";
            this.WeekdayOutputLabel.Size = new System.Drawing.Size(22, 13);
            this.WeekdayOutputLabel.TabIndex = 11;
            this.WeekdayOutputLabel.Text = ". . .";
            this.WeekdayOutputLabel.Visible = false;
            // 
            // TypeinWeekadayLabel
            // 
            this.TypeinWeekadayLabel.AutoSize = true;
            this.TypeinWeekadayLabel.Location = new System.Drawing.Point(12, 28);
            this.TypeinWeekadayLabel.Name = "TypeinWeekadayLabel";
            this.TypeinWeekadayLabel.Size = new System.Drawing.Size(115, 13);
            this.TypeinWeekadayLabel.TabIndex = 9;
            this.TypeinWeekadayLabel.Text = "Type value for parsing:";
            // 
            // ParseButton
            // 
            this.ParseButton.Location = new System.Drawing.Point(183, 42);
            this.ParseButton.Name = "ParseButton";
            this.ParseButton.Size = new System.Drawing.Size(75, 22);
            this.ParseButton.TabIndex = 10;
            this.ParseButton.Text = "Parse";
            this.ParseButton.UseVisualStyleBackColor = true;
            this.ParseButton.Click += new System.EventHandler(this.ParseButton_Click);
            // 
            // EnumerationsGrBox
            // 
            this.EnumerationsGrBox.Controls.Add(this.IntValueTextBox);
            this.EnumerationsGrBox.Controls.Add(this.IntValueLabel);
            this.EnumerationsGrBox.Controls.Add(this.ChooseLabel);
            this.EnumerationsGrBox.Controls.Add(this.ChooseEnumsLabel);
            this.EnumerationsGrBox.Controls.Add(this.EnumsListBox);
            this.EnumerationsGrBox.Controls.Add(this.ValuesListBox);
            this.EnumerationsGrBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EnumerationsGrBox.Location = new System.Drawing.Point(24, 19);
            this.EnumerationsGrBox.Name = "EnumerationsGrBox";
            this.EnumerationsGrBox.Size = new System.Drawing.Size(643, 200);
            this.EnumerationsGrBox.TabIndex = 11;
            this.EnumerationsGrBox.TabStop = false;
            this.EnumerationsGrBox.Text = "Enumerations";
            // 
            // IntValueTextBox
            // 
            this.IntValueTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IntValueTextBox.Location = new System.Drawing.Point(350, 47);
            this.IntValueTextBox.Name = "IntValueTextBox";
            this.IntValueTextBox.ReadOnly = true;
            this.IntValueTextBox.Size = new System.Drawing.Size(134, 20);
            this.IntValueTextBox.TabIndex = 2;
            // 
            // IntValueLabel
            // 
            this.IntValueLabel.AutoSize = true;
            this.IntValueLabel.Location = new System.Drawing.Point(347, 31);
            this.IntValueLabel.Name = "IntValueLabel";
            this.IntValueLabel.Size = new System.Drawing.Size(126, 13);
            this.IntValueLabel.TabIndex = 3;
            this.IntValueLabel.Text = "Int Value (Starting from 0)";
            // 
            // ChooseLabel
            // 
            this.ChooseLabel.AutoSize = true;
            this.ChooseLabel.Location = new System.Drawing.Point(182, 31);
            this.ChooseLabel.Name = "ChooseLabel";
            this.ChooseLabel.Size = new System.Drawing.Size(76, 13);
            this.ChooseLabel.TabIndex = 4;
            this.ChooseLabel.Text = "Choose Value:";
            // 
            // ChooseEnumsLabel
            // 
            this.ChooseEnumsLabel.AutoSize = true;
            this.ChooseEnumsLabel.Location = new System.Drawing.Point(12, 31);
            this.ChooseEnumsLabel.Name = "ChooseEnumsLabel";
            this.ChooseEnumsLabel.Size = new System.Drawing.Size(107, 13);
            this.ChooseEnumsLabel.TabIndex = 6;
            this.ChooseEnumsLabel.Text = "Choose enumeration:";
            // 
            // EnumsListBox
            // 
            this.EnumsListBox.FormattingEnabled = true;
            this.EnumsListBox.Items.AddRange(new object[] {
            "Color",
            "EducationForm",
            "Genre",
            "Manufacturers",
            "Season",
            "Weekday"});
            this.EnumsListBox.Location = new System.Drawing.Point(15, 47);
            this.EnumsListBox.Name = "EnumsListBox";
            this.EnumsListBox.ScrollAlwaysVisible = true;
            this.EnumsListBox.Size = new System.Drawing.Size(133, 108);
            this.EnumsListBox.TabIndex = 0;
            this.EnumsListBox.SelectedIndexChanged += new System.EventHandler(this.EnumsListBox_SelectedIndexChanged);
            // 
            // ValuesListBox
            // 
            this.ValuesListBox.FormattingEnabled = true;
            this.ValuesListBox.Location = new System.Drawing.Point(183, 47);
            this.ValuesListBox.Name = "ValuesListBox";
            this.ValuesListBox.ScrollAlwaysVisible = true;
            this.ValuesListBox.Size = new System.Drawing.Size(133, 108);
            this.ValuesListBox.TabIndex = 1;
            this.ValuesListBox.SelectedIndexChanged += new System.EventHandler(this.ValuesListBox_SelectedIndexChanged);
            // 
            // EnumLabel
            // 
            this.EnumLabel.AutoSize = true;
            this.EnumLabel.Location = new System.Drawing.Point(21, 10);
            this.EnumLabel.Name = "EnumLabel";
            this.EnumLabel.Size = new System.Drawing.Size(0, 13);
            this.EnumLabel.TabIndex = 5;
            // 
            // SeasonsHandleComboBox
            // 
            this.SeasonsHandleComboBox.FormattingEnabled = true;
            this.SeasonsHandleComboBox.Location = new System.Drawing.Point(9, 42);
            this.SeasonsHandleComboBox.Name = "SeasonsHandleComboBox";
            this.SeasonsHandleComboBox.Size = new System.Drawing.Size(134, 21);
            this.SeasonsHandleComboBox.TabIndex = 12;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 481);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.Enums.ResumeLayout(false);
            this.Enums.PerformLayout();
            this.SeasonHGrBox.ResumeLayout(false);
            this.SeasonHGrBox.PerformLayout();
            this.WeekDPGrBox.ResumeLayout(false);
            this.WeekDPGrBox.PerformLayout();
            this.EnumerationsGrBox.ResumeLayout(false);
            this.EnumerationsGrBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Enums;
        private System.Windows.Forms.TextBox IntValueTextBox;
        private System.Windows.Forms.ListBox ValuesListBox;
        private System.Windows.Forms.ListBox EnumsListBox;
        private System.Windows.Forms.Label WeekdayOutputLabel;
        private System.Windows.Forms.Button ParseButton;
        private System.Windows.Forms.Label TypeinWeekadayLabel;
        private System.Windows.Forms.TextBox ParsingTextBox;
        private System.Windows.Forms.Label ChooseEnumsLabel;
        private System.Windows.Forms.Label EnumLabel;
        private System.Windows.Forms.Label ChooseLabel;
        private System.Windows.Forms.Label IntValueLabel;
        private System.Windows.Forms.Button SeasonHandleButton;
        private System.Windows.Forms.Label SeasonChooseLabel;
        private System.Windows.Forms.GroupBox EnumerationsGrBox;
        private System.Windows.Forms.GroupBox SeasonHGrBox;
        private System.Windows.Forms.GroupBox WeekDPGrBox;
        private System.Windows.Forms.ComboBox SeasonsHandleComboBox;
    }
}

