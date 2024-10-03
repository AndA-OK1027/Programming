
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
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.Rectangle = new System.Windows.Forms.TabPage();
            this.RectangleCollisionControl1 = new Programming.RectangleCollisionControl();
            this.Enums = new System.Windows.Forms.TabPage();
            this.seasonsControl1 = new Programming.SeasonsControl();
            this.weekdayParsingControl1 = new Programming.WeekdayParsingControl();
            this.allEnumerationsControl1 = new Programming.AllEnumerationsControl();
            this.Classes = new System.Windows.Forms.TabPage();
            this.rectanglesControl1 = new Programming.RectanglesControl();
            this.moviesControl1 = new Programming.MoviesControl();
            this.MainTabControl.SuspendLayout();
            this.Rectangle.SuspendLayout();
            this.Enums.SuspendLayout();
            this.Classes.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.Rectangle);
            this.MainTabControl.Controls.Add(this.Enums);
            this.MainTabControl.Controls.Add(this.Classes);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.Location = new System.Drawing.Point(0, 0);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(685, 535);
            this.MainTabControl.TabIndex = 0;
            // 
            // Rectangle
            // 
            this.Rectangle.Controls.Add(this.RectangleCollisionControl1);
            this.Rectangle.Location = new System.Drawing.Point(4, 22);
            this.Rectangle.Name = "Rectangle";
            this.Rectangle.Padding = new System.Windows.Forms.Padding(3);
            this.Rectangle.Size = new System.Drawing.Size(677, 509);
            this.Rectangle.TabIndex = 3;
            this.Rectangle.Text = "Rectangles";
            this.Rectangle.UseVisualStyleBackColor = true;
            // 
            // RectangleCollisionControl1
            // 
            this.RectangleCollisionControl1.BackColor = System.Drawing.Color.LavenderBlush;
            this.RectangleCollisionControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RectangleCollisionControl1.Location = new System.Drawing.Point(3, 3);
            this.RectangleCollisionControl1.Name = "RectangleCollisionControl1";
            this.RectangleCollisionControl1.Size = new System.Drawing.Size(671, 503);
            this.RectangleCollisionControl1.TabIndex = 0;
            // 
            // Enums
            // 
            this.Enums.BackColor = System.Drawing.Color.FloralWhite;
            this.Enums.Controls.Add(this.seasonsControl1);
            this.Enums.Controls.Add(this.weekdayParsingControl1);
            this.Enums.Controls.Add(this.allEnumerationsControl1);
            this.Enums.Location = new System.Drawing.Point(4, 22);
            this.Enums.Name = "Enums";
            this.Enums.Size = new System.Drawing.Size(677, 509);
            this.Enums.TabIndex = 0;
            this.Enums.Text = "Enums";
            // 
            // seasonsControl1
            // 
            this.seasonsControl1.Location = new System.Drawing.Point(273, 258);
            this.seasonsControl1.Name = "seasonsControl1";
            this.seasonsControl1.Size = new System.Drawing.Size(225, 78);
            this.seasonsControl1.TabIndex = 3;
            this.seasonsControl1.ButtonClicked += new System.EventHandler(this.seasonsControl1_ButtonClicked);
            // 
            // weekdayParsingControl1
            // 
            this.weekdayParsingControl1.Location = new System.Drawing.Point(8, 258);
            this.weekdayParsingControl1.Name = "weekdayParsingControl1";
            this.weekdayParsingControl1.Size = new System.Drawing.Size(259, 124);
            this.weekdayParsingControl1.TabIndex = 2;
            // 
            // allEnumerationsControl1
            // 
            this.allEnumerationsControl1.Location = new System.Drawing.Point(8, 3);
            this.allEnumerationsControl1.Name = "allEnumerationsControl1";
            this.allEnumerationsControl1.Size = new System.Drawing.Size(661, 162);
            this.allEnumerationsControl1.TabIndex = 0;
            // 
            // Classes
            // 
            this.Classes.BackColor = System.Drawing.Color.PapayaWhip;
            this.Classes.Controls.Add(this.rectanglesControl1);
            this.Classes.Controls.Add(this.moviesControl1);
            this.Classes.Location = new System.Drawing.Point(4, 22);
            this.Classes.Name = "Classes";
            this.Classes.Padding = new System.Windows.Forms.Padding(3);
            this.Classes.Size = new System.Drawing.Size(677, 509);
            this.Classes.TabIndex = 1;
            this.Classes.Text = "Classes";
            // 
            // rectanglesControl1
            // 
            this.rectanglesControl1.Location = new System.Drawing.Point(3, 6);
            this.rectanglesControl1.Name = "rectanglesControl1";
            this.rectanglesControl1.Size = new System.Drawing.Size(351, 171);
            this.rectanglesControl1.TabIndex = 1;
            // 
            // moviesControl1
            // 
            this.moviesControl1.Location = new System.Drawing.Point(13, 209);
            this.moviesControl1.Name = "moviesControl1";
            this.moviesControl1.Size = new System.Drawing.Size(346, 168);
            this.moviesControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 535);
            this.Controls.Add(this.MainTabControl);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MainForm";
            this.MainTabControl.ResumeLayout(false);
            this.Rectangle.ResumeLayout(false);
            this.Enums.ResumeLayout(false);
            this.Classes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage Enums;
        private System.Windows.Forms.TabPage Classes;
        private System.Windows.Forms.TabPage Rectangle;
        private RectangleCollisionControl RectangleCollisionControl1;
        private WeekdayParsingControl weekdayParsingControl1;
        private AllEnumerationsControl allEnumerationsControl1;
        private RectanglesControl rectanglesControl1;
        private MoviesControl moviesControl1;
        private SeasonsControl seasonsControl1;
    }
}

