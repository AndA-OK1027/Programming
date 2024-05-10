
namespace Programming
{
    partial class AllEnumerationsControl
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
            this.IntValueTextBox = new System.Windows.Forms.TextBox();
            this.IntValueLabel = new System.Windows.Forms.Label();
            this.ChooseLabel = new System.Windows.Forms.Label();
            this.ChooseEnumsLabel = new System.Windows.Forms.Label();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // IntValueTextBox
            // 
            this.IntValueTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IntValueTextBox.Location = new System.Drawing.Point(303, 44);
            this.IntValueTextBox.Name = "IntValueTextBox";
            this.IntValueTextBox.ReadOnly = true;
            this.IntValueTextBox.Size = new System.Drawing.Size(134, 20);
            this.IntValueTextBox.TabIndex = 2;
            // 
            // IntValueLabel
            // 
            this.IntValueLabel.AutoSize = true;
            this.IntValueLabel.Location = new System.Drawing.Point(300, 28);
            this.IntValueLabel.Name = "IntValueLabel";
            this.IntValueLabel.Size = new System.Drawing.Size(126, 13);
            this.IntValueLabel.TabIndex = 3;
            this.IntValueLabel.Text = "Int Value (Starting from 0)";
            // 
            // ChooseLabel
            // 
            this.ChooseLabel.AutoSize = true;
            this.ChooseLabel.Location = new System.Drawing.Point(158, 12);
            this.ChooseLabel.Name = "ChooseLabel";
            this.ChooseLabel.Size = new System.Drawing.Size(76, 13);
            this.ChooseLabel.TabIndex = 4;
            this.ChooseLabel.Text = "Choose Value:";
            // 
            // ChooseEnumsLabel
            // 
            this.ChooseEnumsLabel.AutoSize = true;
            this.ChooseEnumsLabel.Location = new System.Drawing.Point(3, 12);
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
            this.EnumsListBox.Location = new System.Drawing.Point(6, 28);
            this.EnumsListBox.Name = "EnumsListBox";
            this.EnumsListBox.ScrollAlwaysVisible = true;
            this.EnumsListBox.Size = new System.Drawing.Size(133, 108);
            this.EnumsListBox.TabIndex = 0;
            this.EnumsListBox.SelectedIndexChanged += new System.EventHandler(this.EnumsListBox_SelectedIndexChanged);
            // 
            // ValuesListBox
            // 
            this.ValuesListBox.FormattingEnabled = true;
            this.ValuesListBox.Location = new System.Drawing.Point(161, 28);
            this.ValuesListBox.Name = "ValuesListBox";
            this.ValuesListBox.ScrollAlwaysVisible = true;
            this.ValuesListBox.Size = new System.Drawing.Size(133, 108);
            this.ValuesListBox.TabIndex = 1;
            this.ValuesListBox.SelectedIndexChanged += new System.EventHandler(this.ValuesListBox_SelectedIndexChanged);
            // 
            // AllEnumerationsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ChooseEnumsLabel);
            this.Controls.Add(this.ChooseLabel);
            this.Controls.Add(this.EnumsListBox);
            this.Controls.Add(this.IntValueLabel);
            this.Controls.Add(this.IntValueTextBox);
            this.Controls.Add(this.ValuesListBox);
            this.Name = "AllEnumerationsControl";
            this.Size = new System.Drawing.Size(450, 156);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox IntValueTextBox;
        private System.Windows.Forms.Label IntValueLabel;
        private System.Windows.Forms.Label ChooseLabel;
        private System.Windows.Forms.Label ChooseEnumsLabel;
        private System.Windows.Forms.ListBox EnumsListBox;
        private System.Windows.Forms.ListBox ValuesListBox;
    }
}
