
namespace Programming
{
    partial class WeekdayParsingControl
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
            this.ParsingTextBox = new System.Windows.Forms.TextBox();
            this.WeekdayOutputLabel = new System.Windows.Forms.Label();
            this.TypeinWeekadayLabel = new System.Windows.Forms.Label();
            this.ParseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ParsingTextBox
            // 
            this.ParsingTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ParsingTextBox.Location = new System.Drawing.Point(6, 25);
            this.ParsingTextBox.Name = "ParsingTextBox";
            this.ParsingTextBox.Size = new System.Drawing.Size(162, 20);
            this.ParsingTextBox.TabIndex = 0;
            // 
            // WeekdayOutputLabel
            // 
            this.WeekdayOutputLabel.AutoSize = true;
            this.WeekdayOutputLabel.Location = new System.Drawing.Point(3, 48);
            this.WeekdayOutputLabel.Name = "WeekdayOutputLabel";
            this.WeekdayOutputLabel.Size = new System.Drawing.Size(22, 13);
            this.WeekdayOutputLabel.TabIndex = 11;
            this.WeekdayOutputLabel.Text = ". . .";
            this.WeekdayOutputLabel.Visible = false;
            // 
            // TypeinWeekadayLabel
            // 
            this.TypeinWeekadayLabel.AutoSize = true;
            this.TypeinWeekadayLabel.Location = new System.Drawing.Point(3, 9);
            this.TypeinWeekadayLabel.Name = "TypeinWeekadayLabel";
            this.TypeinWeekadayLabel.Size = new System.Drawing.Size(115, 13);
            this.TypeinWeekadayLabel.TabIndex = 9;
            this.TypeinWeekadayLabel.Text = "Type value for parsing:";
            // 
            // ParseButton
            // 
            this.ParseButton.Location = new System.Drawing.Point(174, 25);
            this.ParseButton.Name = "ParseButton";
            this.ParseButton.Size = new System.Drawing.Size(75, 22);
            this.ParseButton.TabIndex = 10;
            this.ParseButton.Text = "Parse";
            this.ParseButton.UseVisualStyleBackColor = true;
            this.ParseButton.Click += new System.EventHandler(this.ParseButton_Click);
            // 
            // WeekdayParsingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.WeekdayOutputLabel);
            this.Controls.Add(this.ParsingTextBox);
            this.Controls.Add(this.ParseButton);
            this.Controls.Add(this.TypeinWeekadayLabel);
            this.Name = "WeekdayParsingControl";
            this.Size = new System.Drawing.Size(259, 124);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox ParsingTextBox;
        private System.Windows.Forms.Label WeekdayOutputLabel;
        private System.Windows.Forms.Label TypeinWeekadayLabel;
        private System.Windows.Forms.Button ParseButton;
    }
}
