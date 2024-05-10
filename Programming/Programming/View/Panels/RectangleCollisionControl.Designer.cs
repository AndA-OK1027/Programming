
namespace Programming
{
    partial class RectangleCollisionControl
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
            this.CanvasPanel = new System.Windows.Forms.Panel();
            this.CollisionRectanglesListBox = new System.Windows.Forms.ListBox();
            this.RectanglesListBoxLabel = new System.Windows.Forms.Label();
            this.AddRectangleButton = new System.Windows.Forms.Button();
            this.RemoveRectangleButton = new System.Windows.Forms.Button();
            this.SelectedRectangleLabel = new System.Windows.Forms.Label();
            this.CollisionIDTextBox = new System.Windows.Forms.TextBox();
            this.CollisionXTextBox = new System.Windows.Forms.TextBox();
            this.CollisionYTextBox = new System.Windows.Forms.TextBox();
            this.CollisionWidthTextBox = new System.Windows.Forms.TextBox();
            this.CollisionHeightTextBox = new System.Windows.Forms.TextBox();
            this.RIdLabel = new System.Windows.Forms.Label();
            this.XCooedLabel = new System.Windows.Forms.Label();
            this.YCoordLabel = new System.Windows.Forms.Label();
            this.WLabel = new System.Windows.Forms.Label();
            this.HLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CanvasPanel
            // 
            this.CanvasPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CanvasPanel.AutoScroll = true;
            this.CanvasPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CanvasPanel.BackColor = System.Drawing.Color.Snow;
            this.CanvasPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CanvasPanel.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.CanvasPanel.Location = new System.Drawing.Point(330, 8);
            this.CanvasPanel.MaximumSize = new System.Drawing.Size(600, 800);
            this.CanvasPanel.Name = "CanvasPanel";
            this.CanvasPanel.Size = new System.Drawing.Size(344, 498);
            this.CanvasPanel.TabIndex = 1;
            // 
            // CollisionRectanglesListBox
            // 
            this.CollisionRectanglesListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CollisionRectanglesListBox.FormattingEnabled = true;
            this.CollisionRectanglesListBox.Location = new System.Drawing.Point(11, 24);
            this.CollisionRectanglesListBox.Name = "CollisionRectanglesListBox";
            this.CollisionRectanglesListBox.Size = new System.Drawing.Size(313, 158);
            this.CollisionRectanglesListBox.TabIndex = 2;
            this.CollisionRectanglesListBox.SelectedIndexChanged += new System.EventHandler(this.CollisionRectanglesListBox_SelectedIndexChanged);
            // 
            // RectanglesListBoxLabel
            // 
            this.RectanglesListBoxLabel.AutoSize = true;
            this.RectanglesListBoxLabel.Location = new System.Drawing.Point(11, 8);
            this.RectanglesListBoxLabel.Name = "RectanglesListBoxLabel";
            this.RectanglesListBoxLabel.Size = new System.Drawing.Size(64, 13);
            this.RectanglesListBoxLabel.TabIndex = 3;
            this.RectanglesListBoxLabel.Text = "Rectangles:";
            // 
            // AddRectangleButton
            // 
            this.AddRectangleButton.FlatAppearance.BorderSize = 0;
            this.AddRectangleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddRectangleButton.Location = new System.Drawing.Point(99, 188);
            this.AddRectangleButton.Name = "AddRectangleButton";
            this.AddRectangleButton.Size = new System.Drawing.Size(39, 34);
            this.AddRectangleButton.TabIndex = 4;
            this.AddRectangleButton.Text = "Add";
            this.AddRectangleButton.UseVisualStyleBackColor = true;
            this.AddRectangleButton.Click += new System.EventHandler(this.AddRectangleButton_Click);
            // 
            // RemoveRectangleButton
            // 
            this.RemoveRectangleButton.FlatAppearance.BorderSize = 0;
            this.RemoveRectangleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveRectangleButton.Location = new System.Drawing.Point(178, 188);
            this.RemoveRectangleButton.Name = "RemoveRectangleButton";
            this.RemoveRectangleButton.Size = new System.Drawing.Size(55, 34);
            this.RemoveRectangleButton.TabIndex = 5;
            this.RemoveRectangleButton.Text = "Remove";
            this.RemoveRectangleButton.UseVisualStyleBackColor = true;
            this.RemoveRectangleButton.Click += new System.EventHandler(this.RemoveRectangleButton_Click);
            // 
            // SelectedRectangleLabel
            // 
            this.SelectedRectangleLabel.AutoSize = true;
            this.SelectedRectangleLabel.Location = new System.Drawing.Point(11, 225);
            this.SelectedRectangleLabel.Name = "SelectedRectangleLabel";
            this.SelectedRectangleLabel.Size = new System.Drawing.Size(99, 13);
            this.SelectedRectangleLabel.TabIndex = 6;
            this.SelectedRectangleLabel.Text = "Selected rectangle:";
            // 
            // CollisionIDTextBox
            // 
            this.CollisionIDTextBox.Location = new System.Drawing.Point(50, 253);
            this.CollisionIDTextBox.Name = "CollisionIDTextBox";
            this.CollisionIDTextBox.ReadOnly = true;
            this.CollisionIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.CollisionIDTextBox.TabIndex = 12;
            // 
            // CollisionXTextBox
            // 
            this.CollisionXTextBox.Location = new System.Drawing.Point(50, 279);
            this.CollisionXTextBox.Name = "CollisionXTextBox";
            this.CollisionXTextBox.Size = new System.Drawing.Size(100, 20);
            this.CollisionXTextBox.TabIndex = 16;
            this.CollisionXTextBox.TextChanged += new System.EventHandler(this.CollisionXTextBox_TextChanged);
            // 
            // CollisionYTextBox
            // 
            this.CollisionYTextBox.Location = new System.Drawing.Point(50, 305);
            this.CollisionYTextBox.Name = "CollisionYTextBox";
            this.CollisionYTextBox.Size = new System.Drawing.Size(100, 20);
            this.CollisionYTextBox.TabIndex = 17;
            this.CollisionYTextBox.TextChanged += new System.EventHandler(this.CollisionYTextBox_TextChanged);
            // 
            // CollisionWidthTextBox
            // 
            this.CollisionWidthTextBox.Location = new System.Drawing.Point(50, 331);
            this.CollisionWidthTextBox.Name = "CollisionWidthTextBox";
            this.CollisionWidthTextBox.Size = new System.Drawing.Size(100, 20);
            this.CollisionWidthTextBox.TabIndex = 18;
            this.CollisionWidthTextBox.TextChanged += new System.EventHandler(this.CollisionWidthTextBox_TextChanged);
            // 
            // CollisionHeightTextBox
            // 
            this.CollisionHeightTextBox.Location = new System.Drawing.Point(50, 357);
            this.CollisionHeightTextBox.Name = "CollisionHeightTextBox";
            this.CollisionHeightTextBox.Size = new System.Drawing.Size(100, 20);
            this.CollisionHeightTextBox.TabIndex = 19;
            this.CollisionHeightTextBox.TextChanged += new System.EventHandler(this.CollisionHeightTextBox_TextChanged);
            // 
            // RIdLabel
            // 
            this.RIdLabel.AutoSize = true;
            this.RIdLabel.Location = new System.Drawing.Point(27, 256);
            this.RIdLabel.Name = "RIdLabel";
            this.RIdLabel.Size = new System.Drawing.Size(19, 13);
            this.RIdLabel.TabIndex = 20;
            this.RIdLabel.Text = "Id:";
            // 
            // XCooedLabel
            // 
            this.XCooedLabel.AutoSize = true;
            this.XCooedLabel.Location = new System.Drawing.Point(27, 282);
            this.XCooedLabel.Name = "XCooedLabel";
            this.XCooedLabel.Size = new System.Drawing.Size(17, 13);
            this.XCooedLabel.TabIndex = 21;
            this.XCooedLabel.Text = "X:";
            // 
            // YCoordLabel
            // 
            this.YCoordLabel.AutoSize = true;
            this.YCoordLabel.Location = new System.Drawing.Point(27, 308);
            this.YCoordLabel.Name = "YCoordLabel";
            this.YCoordLabel.Size = new System.Drawing.Size(17, 13);
            this.YCoordLabel.TabIndex = 22;
            this.YCoordLabel.Text = "Y:";
            // 
            // WLabel
            // 
            this.WLabel.AutoSize = true;
            this.WLabel.Location = new System.Drawing.Point(11, 334);
            this.WLabel.Name = "WLabel";
            this.WLabel.Size = new System.Drawing.Size(38, 13);
            this.WLabel.TabIndex = 23;
            this.WLabel.Text = "Width:";
            // 
            // HLabel
            // 
            this.HLabel.AutoSize = true;
            this.HLabel.Location = new System.Drawing.Point(8, 360);
            this.HLabel.Name = "HLabel";
            this.HLabel.Size = new System.Drawing.Size(41, 13);
            this.HLabel.TabIndex = 24;
            this.HLabel.Text = "Height:";
            // 
            // RectangleCollisionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.Controls.Add(this.HLabel);
            this.Controls.Add(this.WLabel);
            this.Controls.Add(this.YCoordLabel);
            this.Controls.Add(this.XCooedLabel);
            this.Controls.Add(this.RIdLabel);
            this.Controls.Add(this.CollisionHeightTextBox);
            this.Controls.Add(this.CollisionWidthTextBox);
            this.Controls.Add(this.CollisionYTextBox);
            this.Controls.Add(this.CollisionXTextBox);
            this.Controls.Add(this.CollisionIDTextBox);
            this.Controls.Add(this.SelectedRectangleLabel);
            this.Controls.Add(this.RemoveRectangleButton);
            this.Controls.Add(this.AddRectangleButton);
            this.Controls.Add(this.RectanglesListBoxLabel);
            this.Controls.Add(this.CollisionRectanglesListBox);
            this.Controls.Add(this.CanvasPanel);
            this.Name = "RectangleCollisionControl";
            this.Size = new System.Drawing.Size(677, 509);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel CanvasPanel;
        private System.Windows.Forms.ListBox CollisionRectanglesListBox;
        private System.Windows.Forms.Label RectanglesListBoxLabel;
        private System.Windows.Forms.Button AddRectangleButton;
        private System.Windows.Forms.Button RemoveRectangleButton;
        private System.Windows.Forms.Label SelectedRectangleLabel;
        private System.Windows.Forms.TextBox CollisionIDTextBox;
        private System.Windows.Forms.TextBox CollisionXTextBox;
        private System.Windows.Forms.TextBox CollisionYTextBox;
        private System.Windows.Forms.TextBox CollisionWidthTextBox;
        private System.Windows.Forms.TextBox CollisionHeightTextBox;
        private System.Windows.Forms.Label RIdLabel;
        private System.Windows.Forms.Label XCooedLabel;
        private System.Windows.Forms.Label YCoordLabel;
        private System.Windows.Forms.Label WLabel;
        private System.Windows.Forms.Label HLabel;
    }
}
