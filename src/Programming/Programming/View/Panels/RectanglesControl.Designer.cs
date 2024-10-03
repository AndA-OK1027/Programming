
namespace Programming
{
    partial class RectanglesControl
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
            this.IdLabel = new System.Windows.Forms.Label();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.CenterCoordinatesLabel = new System.Windows.Forms.Label();
            this.CenterCoordTextBox = new System.Windows.Forms.TextBox();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.FindRectangleButton = new System.Windows.Forms.Button();
            this.LengthLabel = new System.Windows.Forms.Label();
            this.ColorTextBox = new System.Windows.Forms.TextBox();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.LengthTextBox = new System.Windows.Forms.TextBox();
            this.RectanglesListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(239, 42);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(16, 13);
            this.IdLabel.TabIndex = 11;
            this.IdLabel.Text = "Id";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(242, 58);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.ReadOnly = true;
            this.IdTextBox.Size = new System.Drawing.Size(100, 20);
            this.IdTextBox.TabIndex = 10;
            // 
            // CenterCoordinatesLabel
            // 
            this.CenterCoordinatesLabel.AutoSize = true;
            this.CenterCoordinatesLabel.Location = new System.Drawing.Point(239, 3);
            this.CenterCoordinatesLabel.Name = "CenterCoordinatesLabel";
            this.CenterCoordinatesLabel.Size = new System.Drawing.Size(97, 13);
            this.CenterCoordinatesLabel.TabIndex = 9;
            this.CenterCoordinatesLabel.Text = "Center Coordinates";
            // 
            // CenterCoordTextBox
            // 
            this.CenterCoordTextBox.Location = new System.Drawing.Point(242, 19);
            this.CenterCoordTextBox.Name = "CenterCoordTextBox";
            this.CenterCoordTextBox.ReadOnly = true;
            this.CenterCoordTextBox.Size = new System.Drawing.Size(100, 20);
            this.CenterCoordTextBox.TabIndex = 8;
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Location = new System.Drawing.Point(133, 81);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(31, 13);
            this.ColorLabel.TabIndex = 7;
            this.ColorLabel.Text = "Color";
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Location = new System.Drawing.Point(133, 42);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(35, 13);
            this.WidthLabel.TabIndex = 6;
            this.WidthLabel.Text = "Width";
            // 
            // FindRectangleButton
            // 
            this.FindRectangleButton.Location = new System.Drawing.Point(242, 95);
            this.FindRectangleButton.Name = "FindRectangleButton";
            this.FindRectangleButton.Size = new System.Drawing.Size(100, 22);
            this.FindRectangleButton.TabIndex = 5;
            this.FindRectangleButton.Text = "Find";
            this.FindRectangleButton.UseVisualStyleBackColor = true;
            this.FindRectangleButton.Click += new System.EventHandler(this.FindRectangleButton_Click);
            // 
            // LengthLabel
            // 
            this.LengthLabel.AutoSize = true;
            this.LengthLabel.Location = new System.Drawing.Point(133, 3);
            this.LengthLabel.Name = "LengthLabel";
            this.LengthLabel.Size = new System.Drawing.Size(40, 13);
            this.LengthLabel.TabIndex = 4;
            this.LengthLabel.Text = "Length";
            // 
            // ColorTextBox
            // 
            this.ColorTextBox.Location = new System.Drawing.Point(136, 97);
            this.ColorTextBox.Name = "ColorTextBox";
            this.ColorTextBox.Size = new System.Drawing.Size(100, 20);
            this.ColorTextBox.TabIndex = 3;
            this.ColorTextBox.TextChanged += new System.EventHandler(this.ColorTextBox_TextChanged);
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.Location = new System.Drawing.Point(136, 58);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(100, 20);
            this.WidthTextBox.TabIndex = 2;
            this.WidthTextBox.TextChanged += new System.EventHandler(this.WidthTextBox_TextChanged);
            // 
            // LengthTextBox
            // 
            this.LengthTextBox.Location = new System.Drawing.Point(136, 19);
            this.LengthTextBox.Name = "LengthTextBox";
            this.LengthTextBox.Size = new System.Drawing.Size(100, 20);
            this.LengthTextBox.TabIndex = 1;
            this.LengthTextBox.TextChanged += new System.EventHandler(this.LengthTextBox_TextChanged);
            // 
            // RectanglesListBox
            // 
            this.RectanglesListBox.FormattingEnabled = true;
            this.RectanglesListBox.Items.AddRange(new object[] {
            "Rectangle 1",
            "Rectangle 2",
            "Rectangle 3",
            "Rectangle 4",
            "Rectangle 5"});
            this.RectanglesListBox.Location = new System.Drawing.Point(12, 3);
            this.RectanglesListBox.Name = "RectanglesListBox";
            this.RectanglesListBox.Size = new System.Drawing.Size(115, 160);
            this.RectanglesListBox.TabIndex = 0;
            this.RectanglesListBox.SelectedIndexChanged += new System.EventHandler(this.RectanglesListBox_SelectedIndexChanged);
            // 
            // RectanglesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FindRectangleButton);
            this.Controls.Add(this.ColorLabel);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.WidthLabel);
            this.Controls.Add(this.ColorTextBox);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.RectanglesListBox);
            this.Controls.Add(this.WidthTextBox);
            this.Controls.Add(this.CenterCoordinatesLabel);
            this.Controls.Add(this.LengthTextBox);
            this.Controls.Add(this.CenterCoordTextBox);
            this.Controls.Add(this.LengthLabel);
            this.Name = "RectanglesControl";
            this.Size = new System.Drawing.Size(351, 171);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Label CenterCoordinatesLabel;
        private System.Windows.Forms.TextBox CenterCoordTextBox;
        private System.Windows.Forms.Label ColorLabel;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.Button FindRectangleButton;
        private System.Windows.Forms.Label LengthLabel;
        private System.Windows.Forms.TextBox ColorTextBox;
        private System.Windows.Forms.TextBox WidthTextBox;
        private System.Windows.Forms.TextBox LengthTextBox;
        private System.Windows.Forms.ListBox RectanglesListBox;
    }
}
