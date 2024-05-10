
namespace Programming
{
    partial class MoviesControl
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
            this.FindMovieButton = new System.Windows.Forms.Button();
            this.MovieRatingLabel = new System.Windows.Forms.Label();
            this.ReleaseYearLabel = new System.Windows.Forms.Label();
            this.RatingTextBox = new System.Windows.Forms.TextBox();
            this.ReleaseYearTextBox = new System.Windows.Forms.TextBox();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.MovieLengthLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.MovieLengthTextBox = new System.Windows.Forms.TextBox();
            this.GenreTextBox = new System.Windows.Forms.TextBox();
            this.MovieNameTextBox = new System.Windows.Forms.TextBox();
            this.MoviesListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // FindMovieButton
            // 
            this.FindMovieButton.Location = new System.Drawing.Point(233, 95);
            this.FindMovieButton.Name = "FindMovieButton";
            this.FindMovieButton.Size = new System.Drawing.Size(100, 22);
            this.FindMovieButton.TabIndex = 12;
            this.FindMovieButton.Text = "Find";
            this.FindMovieButton.UseVisualStyleBackColor = true;
            this.FindMovieButton.Click += new System.EventHandler(this.FindMovieButton_Click);
            // 
            // MovieRatingLabel
            // 
            this.MovieRatingLabel.AutoSize = true;
            this.MovieRatingLabel.Location = new System.Drawing.Point(230, 3);
            this.MovieRatingLabel.Name = "MovieRatingLabel";
            this.MovieRatingLabel.Size = new System.Drawing.Size(38, 13);
            this.MovieRatingLabel.TabIndex = 11;
            this.MovieRatingLabel.Text = "Rating";
            // 
            // ReleaseYearLabel
            // 
            this.ReleaseYearLabel.AutoSize = true;
            this.ReleaseYearLabel.Location = new System.Drawing.Point(230, 42);
            this.ReleaseYearLabel.Name = "ReleaseYearLabel";
            this.ReleaseYearLabel.Size = new System.Drawing.Size(71, 13);
            this.ReleaseYearLabel.TabIndex = 10;
            this.ReleaseYearLabel.Text = "Release Year";
            // 
            // RatingTextBox
            // 
            this.RatingTextBox.Location = new System.Drawing.Point(233, 19);
            this.RatingTextBox.Name = "RatingTextBox";
            this.RatingTextBox.Size = new System.Drawing.Size(100, 20);
            this.RatingTextBox.TabIndex = 6;
            this.RatingTextBox.TextChanged += new System.EventHandler(this.RatingTextBox_TextChanged);
            // 
            // ReleaseYearTextBox
            // 
            this.ReleaseYearTextBox.Location = new System.Drawing.Point(233, 58);
            this.ReleaseYearTextBox.Name = "ReleaseYearTextBox";
            this.ReleaseYearTextBox.Size = new System.Drawing.Size(100, 20);
            this.ReleaseYearTextBox.TabIndex = 4;
            this.ReleaseYearTextBox.TextChanged += new System.EventHandler(this.ReleaseYearTextBox_TextChanged);
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Location = new System.Drawing.Point(124, 42);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(36, 13);
            this.GenreLabel.TabIndex = 9;
            this.GenreLabel.Text = "Genre";
            // 
            // MovieLengthLabel
            // 
            this.MovieLengthLabel.AutoSize = true;
            this.MovieLengthLabel.Location = new System.Drawing.Point(124, 81);
            this.MovieLengthLabel.Name = "MovieLengthLabel";
            this.MovieLengthLabel.Size = new System.Drawing.Size(40, 13);
            this.MovieLengthLabel.TabIndex = 8;
            this.MovieLengthLabel.Text = "Length";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(124, 3);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 13);
            this.NameLabel.TabIndex = 7;
            this.NameLabel.Text = "Name";
            // 
            // MovieLengthTextBox
            // 
            this.MovieLengthTextBox.Location = new System.Drawing.Point(127, 97);
            this.MovieLengthTextBox.Name = "MovieLengthTextBox";
            this.MovieLengthTextBox.Size = new System.Drawing.Size(100, 20);
            this.MovieLengthTextBox.TabIndex = 5;
            this.MovieLengthTextBox.TextChanged += new System.EventHandler(this.MovieLengthTextBox_TextChanged);
            // 
            // GenreTextBox
            // 
            this.GenreTextBox.Location = new System.Drawing.Point(127, 58);
            this.GenreTextBox.Name = "GenreTextBox";
            this.GenreTextBox.Size = new System.Drawing.Size(100, 20);
            this.GenreTextBox.TabIndex = 3;
            this.GenreTextBox.TextChanged += new System.EventHandler(this.GenreTextBox_TextChanged);
            // 
            // MovieNameTextBox
            // 
            this.MovieNameTextBox.Location = new System.Drawing.Point(127, 19);
            this.MovieNameTextBox.Name = "MovieNameTextBox";
            this.MovieNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.MovieNameTextBox.TabIndex = 2;
            this.MovieNameTextBox.TextChanged += new System.EventHandler(this.MovieNameTextBox_TextChanged);
            // 
            // MoviesListBox
            // 
            this.MoviesListBox.FormattingEnabled = true;
            this.MoviesListBox.Items.AddRange(new object[] {
            "Movie 1",
            "Movie 2",
            "Movie 3",
            "Movie 4",
            "Movie 5"});
            this.MoviesListBox.Location = new System.Drawing.Point(3, 3);
            this.MoviesListBox.Name = "MoviesListBox";
            this.MoviesListBox.Size = new System.Drawing.Size(115, 160);
            this.MoviesListBox.TabIndex = 1;
            this.MoviesListBox.SelectedIndexChanged += new System.EventHandler(this.MoviesListBox_SelectedIndexChanged_1);
            // 
            // MoviesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FindMovieButton);
            this.Controls.Add(this.ReleaseYearLabel);
            this.Controls.Add(this.MovieRatingLabel);
            this.Controls.Add(this.ReleaseYearTextBox);
            this.Controls.Add(this.RatingTextBox);
            this.Controls.Add(this.MoviesListBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.MovieNameTextBox);
            this.Controls.Add(this.GenreLabel);
            this.Controls.Add(this.MovieLengthTextBox);
            this.Controls.Add(this.MovieLengthLabel);
            this.Controls.Add(this.GenreTextBox);
            this.Name = "MoviesControl";
            this.Size = new System.Drawing.Size(346, 168);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button FindMovieButton;
        private System.Windows.Forms.Label MovieRatingLabel;
        private System.Windows.Forms.Label ReleaseYearLabel;
        private System.Windows.Forms.TextBox RatingTextBox;
        private System.Windows.Forms.TextBox ReleaseYearTextBox;
        private System.Windows.Forms.Label GenreLabel;
        private System.Windows.Forms.Label MovieLengthLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox MovieLengthTextBox;
        private System.Windows.Forms.TextBox GenreTextBox;
        private System.Windows.Forms.TextBox MovieNameTextBox;
        private System.Windows.Forms.ListBox MoviesListBox;
    }
}
