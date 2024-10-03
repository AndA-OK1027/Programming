
namespace Programming
{
    partial class SeasonsControl
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
            this.SeasonHandleComboBox = new System.Windows.Forms.ComboBox();
            this.SeasonHandleButton = new System.Windows.Forms.Button();
            this.ChooseSeasonLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SeasonHandleComboBox
            // 
            this.SeasonHandleComboBox.FormattingEnabled = true;
            this.SeasonHandleComboBox.Location = new System.Drawing.Point(6, 25);
            this.SeasonHandleComboBox.Name = "SeasonHandleComboBox";
            this.SeasonHandleComboBox.Size = new System.Drawing.Size(121, 21);
            this.SeasonHandleComboBox.TabIndex = 0;
            // 
            // SeasonHandleButton
            // 
            this.SeasonHandleButton.Location = new System.Drawing.Point(133, 25);
            this.SeasonHandleButton.Name = "SeasonHandleButton";
            this.SeasonHandleButton.Size = new System.Drawing.Size(75, 23);
            this.SeasonHandleButton.TabIndex = 1;
            this.SeasonHandleButton.Text = "Go!";
            this.SeasonHandleButton.UseVisualStyleBackColor = true;
            this.SeasonHandleButton.Click += new System.EventHandler(this.SeasonHandleButton_Click);
            // 
            // ChooseSeasonLabel
            // 
            this.ChooseSeasonLabel.AutoSize = true;
            this.ChooseSeasonLabel.Location = new System.Drawing.Point(3, 9);
            this.ChooseSeasonLabel.Name = "ChooseSeasonLabel";
            this.ChooseSeasonLabel.Size = new System.Drawing.Size(85, 13);
            this.ChooseSeasonLabel.TabIndex = 2;
            this.ChooseSeasonLabel.Text = "Choose Season:";
            // 
            // SeasonsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ChooseSeasonLabel);
            this.Controls.Add(this.SeasonHandleButton);
            this.Controls.Add(this.SeasonHandleComboBox);
            this.Name = "SeasonsControl";
            this.Size = new System.Drawing.Size(225, 78);
            this.Load += new System.EventHandler(this.SeasonsControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SeasonHandleComboBox;
        private System.Windows.Forms.Button SeasonHandleButton;
        private System.Windows.Forms.Label ChooseSeasonLabel;
    }
}
