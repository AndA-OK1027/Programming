
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
            this.Enums = new System.Windows.Forms.TabPage();
            this.SeasonGroupBox = new System.Windows.Forms.GroupBox();
            this.SeasonHandleComboBox = new System.Windows.Forms.ComboBox();
            this.SeasonHandleButton = new System.Windows.Forms.Button();
            this.SeasonChooseLabel = new System.Windows.Forms.Label();
            this.WeekdayGroupBox = new System.Windows.Forms.GroupBox();
            this.ParsingTextBox = new System.Windows.Forms.TextBox();
            this.WeekdayOutputLabel = new System.Windows.Forms.Label();
            this.TypeinWeekadayLabel = new System.Windows.Forms.Label();
            this.ParseButton = new System.Windows.Forms.Button();
            this.EnumerationsGroupBox = new System.Windows.Forms.GroupBox();
            this.IntValueTextBox = new System.Windows.Forms.TextBox();
            this.IntValueLabel = new System.Windows.Forms.Label();
            this.ChooseLabel = new System.Windows.Forms.Label();
            this.ChooseEnumsLabel = new System.Windows.Forms.Label();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.EnumLabel = new System.Windows.Forms.Label();
            this.Classes = new System.Windows.Forms.TabPage();
            this.MovieGroupBox = new System.Windows.Forms.GroupBox();
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
            this.RectanglesGroupBox = new System.Windows.Forms.GroupBox();
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
            this.Rectangles = new System.Windows.Forms.TabPage();
            this.CollisionXTextBox = new System.Windows.Forms.TextBox();
            this.CollisionHeightTextBox = new System.Windows.Forms.TextBox();
            this.CollisionYTextBox = new System.Windows.Forms.TextBox();
            this.CollisionWidthTextBox = new System.Windows.Forms.TextBox();
            this.CollisionIDTextBox = new System.Windows.Forms.TextBox();
            this.RIdLabel = new System.Windows.Forms.Label();
            this.WLabel = new System.Windows.Forms.Label();
            this.XCooedLabel = new System.Windows.Forms.Label();
            this.HLabel = new System.Windows.Forms.Label();
            this.YCoordLabel = new System.Windows.Forms.Label();
            this.SelectedRectangleLabel = new System.Windows.Forms.Label();
            this.RemoveRectangleButton = new System.Windows.Forms.Button();
            this.AddRectangleButton = new System.Windows.Forms.Button();
            this.RectanglesListBoxLabel = new System.Windows.Forms.Label();
            this.CollisionRectanglesListBox = new System.Windows.Forms.ListBox();
            this.CanvasPanel = new System.Windows.Forms.Panel();
            this.MainTabControl.SuspendLayout();
            this.Enums.SuspendLayout();
            this.SeasonGroupBox.SuspendLayout();
            this.WeekdayGroupBox.SuspendLayout();
            this.EnumerationsGroupBox.SuspendLayout();
            this.Classes.SuspendLayout();
            this.MovieGroupBox.SuspendLayout();
            this.RectanglesGroupBox.SuspendLayout();
            this.Rectangles.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.Enums);
            this.MainTabControl.Controls.Add(this.Classes);
            this.MainTabControl.Controls.Add(this.Rectangles);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.Location = new System.Drawing.Point(0, 0);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(685, 535);
            this.MainTabControl.TabIndex = 0;
            // 
            // Enums
            // 
            this.Enums.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Enums.Controls.Add(this.SeasonGroupBox);
            this.Enums.Controls.Add(this.WeekdayGroupBox);
            this.Enums.Controls.Add(this.EnumerationsGroupBox);
            this.Enums.Controls.Add(this.EnumLabel);
            this.Enums.Location = new System.Drawing.Point(4, 22);
            this.Enums.Name = "Enums";
            this.Enums.Size = new System.Drawing.Size(677, 509);
            this.Enums.TabIndex = 0;
            this.Enums.Text = "Enums";
            // 
            // SeasonGroupBox
            // 
            this.SeasonGroupBox.Controls.Add(this.SeasonHandleComboBox);
            this.SeasonGroupBox.Controls.Add(this.SeasonHandleButton);
            this.SeasonGroupBox.Controls.Add(this.SeasonChooseLabel);
            this.SeasonGroupBox.Location = new System.Drawing.Point(365, 225);
            this.SeasonGroupBox.Name = "SeasonGroupBox";
            this.SeasonGroupBox.Size = new System.Drawing.Size(302, 214);
            this.SeasonGroupBox.TabIndex = 13;
            this.SeasonGroupBox.TabStop = false;
            this.SeasonGroupBox.Text = "Season Handle";
            // 
            // SeasonHandleComboBox
            // 
            this.SeasonHandleComboBox.FormattingEnabled = true;
            this.SeasonHandleComboBox.Location = new System.Drawing.Point(11, 42);
            this.SeasonHandleComboBox.Name = "SeasonHandleComboBox";
            this.SeasonHandleComboBox.Size = new System.Drawing.Size(134, 21);
            this.SeasonHandleComboBox.TabIndex = 12;
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
            // WeekdayGroupBox
            // 
            this.WeekdayGroupBox.Controls.Add(this.ParsingTextBox);
            this.WeekdayGroupBox.Controls.Add(this.WeekdayOutputLabel);
            this.WeekdayGroupBox.Controls.Add(this.TypeinWeekadayLabel);
            this.WeekdayGroupBox.Controls.Add(this.ParseButton);
            this.WeekdayGroupBox.Location = new System.Drawing.Point(24, 225);
            this.WeekdayGroupBox.Name = "WeekdayGroupBox";
            this.WeekdayGroupBox.Size = new System.Drawing.Size(302, 214);
            this.WeekdayGroupBox.TabIndex = 12;
            this.WeekdayGroupBox.TabStop = false;
            this.WeekdayGroupBox.Text = "Weekday Parsing";
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
            // EnumerationsGroupBox
            // 
            this.EnumerationsGroupBox.Controls.Add(this.IntValueTextBox);
            this.EnumerationsGroupBox.Controls.Add(this.IntValueLabel);
            this.EnumerationsGroupBox.Controls.Add(this.ChooseLabel);
            this.EnumerationsGroupBox.Controls.Add(this.ChooseEnumsLabel);
            this.EnumerationsGroupBox.Controls.Add(this.EnumsListBox);
            this.EnumerationsGroupBox.Controls.Add(this.ValuesListBox);
            this.EnumerationsGroupBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EnumerationsGroupBox.Location = new System.Drawing.Point(24, 19);
            this.EnumerationsGroupBox.Name = "EnumerationsGroupBox";
            this.EnumerationsGroupBox.Size = new System.Drawing.Size(643, 200);
            this.EnumerationsGroupBox.TabIndex = 11;
            this.EnumerationsGroupBox.TabStop = false;
            this.EnumerationsGroupBox.Text = "Enumerations";
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
            // Classes
            // 
            this.Classes.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.Classes.Controls.Add(this.MovieGroupBox);
            this.Classes.Controls.Add(this.RectanglesGroupBox);
            this.Classes.Location = new System.Drawing.Point(4, 22);
            this.Classes.Name = "Classes";
            this.Classes.Padding = new System.Windows.Forms.Padding(3);
            this.Classes.Size = new System.Drawing.Size(677, 509);
            this.Classes.TabIndex = 1;
            this.Classes.Text = "Classes";
            // 
            // MovieGroupBox
            // 
            this.MovieGroupBox.Controls.Add(this.FindMovieButton);
            this.MovieGroupBox.Controls.Add(this.MovieRatingLabel);
            this.MovieGroupBox.Controls.Add(this.ReleaseYearLabel);
            this.MovieGroupBox.Controls.Add(this.RatingTextBox);
            this.MovieGroupBox.Controls.Add(this.ReleaseYearTextBox);
            this.MovieGroupBox.Controls.Add(this.GenreLabel);
            this.MovieGroupBox.Controls.Add(this.MovieLengthLabel);
            this.MovieGroupBox.Controls.Add(this.NameLabel);
            this.MovieGroupBox.Controls.Add(this.MovieLengthTextBox);
            this.MovieGroupBox.Controls.Add(this.GenreTextBox);
            this.MovieGroupBox.Controls.Add(this.MovieNameTextBox);
            this.MovieGroupBox.Controls.Add(this.MoviesListBox);
            this.MovieGroupBox.Location = new System.Drawing.Point(8, 222);
            this.MovieGroupBox.Name = "MovieGroupBox";
            this.MovieGroupBox.Size = new System.Drawing.Size(384, 200);
            this.MovieGroupBox.TabIndex = 1;
            this.MovieGroupBox.TabStop = false;
            this.MovieGroupBox.Text = "Movies";
            // 
            // FindMovieButton
            // 
            this.FindMovieButton.Location = new System.Drawing.Point(150, 157);
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
            this.MovieRatingLabel.Location = new System.Drawing.Point(258, 14);
            this.MovieRatingLabel.Name = "MovieRatingLabel";
            this.MovieRatingLabel.Size = new System.Drawing.Size(38, 13);
            this.MovieRatingLabel.TabIndex = 11;
            this.MovieRatingLabel.Text = "Rating";
            // 
            // ReleaseYearLabel
            // 
            this.ReleaseYearLabel.AutoSize = true;
            this.ReleaseYearLabel.Location = new System.Drawing.Point(258, 53);
            this.ReleaseYearLabel.Name = "ReleaseYearLabel";
            this.ReleaseYearLabel.Size = new System.Drawing.Size(71, 13);
            this.ReleaseYearLabel.TabIndex = 10;
            this.ReleaseYearLabel.Text = "Release Year";
            // 
            // RatingTextBox
            // 
            this.RatingTextBox.Location = new System.Drawing.Point(261, 30);
            this.RatingTextBox.Name = "RatingTextBox";
            this.RatingTextBox.Size = new System.Drawing.Size(100, 20);
            this.RatingTextBox.TabIndex = 6;
            this.RatingTextBox.TextChanged += new System.EventHandler(this.RatingTextBox_TextChanged);
            // 
            // ReleaseYearTextBox
            // 
            this.ReleaseYearTextBox.Location = new System.Drawing.Point(261, 69);
            this.ReleaseYearTextBox.Name = "ReleaseYearTextBox";
            this.ReleaseYearTextBox.Size = new System.Drawing.Size(100, 20);
            this.ReleaseYearTextBox.TabIndex = 4;
            this.ReleaseYearTextBox.TextChanged += new System.EventHandler(this.ReleaseYearTextBox_TextChanged);
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Location = new System.Drawing.Point(147, 53);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(36, 13);
            this.GenreLabel.TabIndex = 9;
            this.GenreLabel.Text = "Genre";
            // 
            // MovieLengthLabel
            // 
            this.MovieLengthLabel.AutoSize = true;
            this.MovieLengthLabel.Location = new System.Drawing.Point(147, 92);
            this.MovieLengthLabel.Name = "MovieLengthLabel";
            this.MovieLengthLabel.Size = new System.Drawing.Size(40, 13);
            this.MovieLengthLabel.TabIndex = 8;
            this.MovieLengthLabel.Text = "Length";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(147, 14);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 13);
            this.NameLabel.TabIndex = 7;
            this.NameLabel.Text = "Name";
            // 
            // MovieLengthTextBox
            // 
            this.MovieLengthTextBox.Location = new System.Drawing.Point(150, 108);
            this.MovieLengthTextBox.Name = "MovieLengthTextBox";
            this.MovieLengthTextBox.Size = new System.Drawing.Size(100, 20);
            this.MovieLengthTextBox.TabIndex = 5;
            this.MovieLengthTextBox.TextChanged += new System.EventHandler(this.MovieLengthTextBox_TextChanged);
            // 
            // GenreTextBox
            // 
            this.GenreTextBox.Location = new System.Drawing.Point(150, 69);
            this.GenreTextBox.Name = "GenreTextBox";
            this.GenreTextBox.Size = new System.Drawing.Size(100, 20);
            this.GenreTextBox.TabIndex = 3;
            this.GenreTextBox.TextChanged += new System.EventHandler(this.GenreTextBox_TextChanged);
            // 
            // MovieNameTextBox
            // 
            this.MovieNameTextBox.Location = new System.Drawing.Point(150, 30);
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
            this.MoviesListBox.Location = new System.Drawing.Point(6, 19);
            this.MoviesListBox.Name = "MoviesListBox";
            this.MoviesListBox.Size = new System.Drawing.Size(115, 160);
            this.MoviesListBox.TabIndex = 1;
            this.MoviesListBox.SelectedIndexChanged += new System.EventHandler(this.MoviesListBox_SelectedIndexChanged_1);
            // 
            // RectanglesGroupBox
            // 
            this.RectanglesGroupBox.Controls.Add(this.IdLabel);
            this.RectanglesGroupBox.Controls.Add(this.IdTextBox);
            this.RectanglesGroupBox.Controls.Add(this.CenterCoordinatesLabel);
            this.RectanglesGroupBox.Controls.Add(this.CenterCoordTextBox);
            this.RectanglesGroupBox.Controls.Add(this.ColorLabel);
            this.RectanglesGroupBox.Controls.Add(this.WidthLabel);
            this.RectanglesGroupBox.Controls.Add(this.FindRectangleButton);
            this.RectanglesGroupBox.Controls.Add(this.LengthLabel);
            this.RectanglesGroupBox.Controls.Add(this.ColorTextBox);
            this.RectanglesGroupBox.Controls.Add(this.WidthTextBox);
            this.RectanglesGroupBox.Controls.Add(this.LengthTextBox);
            this.RectanglesGroupBox.Controls.Add(this.RectanglesListBox);
            this.RectanglesGroupBox.Location = new System.Drawing.Point(8, 16);
            this.RectanglesGroupBox.Name = "RectanglesGroupBox";
            this.RectanglesGroupBox.Size = new System.Drawing.Size(384, 200);
            this.RectanglesGroupBox.TabIndex = 0;
            this.RectanglesGroupBox.TabStop = false;
            this.RectanglesGroupBox.Text = "Rectangles";
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(261, 58);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(16, 13);
            this.IdLabel.TabIndex = 11;
            this.IdLabel.Text = "Id";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(261, 74);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.ReadOnly = true;
            this.IdTextBox.Size = new System.Drawing.Size(100, 20);
            this.IdTextBox.TabIndex = 10;
            // 
            // CenterCoordinatesLabel
            // 
            this.CenterCoordinatesLabel.AutoSize = true;
            this.CenterCoordinatesLabel.Location = new System.Drawing.Point(258, 19);
            this.CenterCoordinatesLabel.Name = "CenterCoordinatesLabel";
            this.CenterCoordinatesLabel.Size = new System.Drawing.Size(97, 13);
            this.CenterCoordinatesLabel.TabIndex = 9;
            this.CenterCoordinatesLabel.Text = "Center Coordinates";
            // 
            // CenterCoordTextBox
            // 
            this.CenterCoordTextBox.Location = new System.Drawing.Point(261, 35);
            this.CenterCoordTextBox.Name = "CenterCoordTextBox";
            this.CenterCoordTextBox.ReadOnly = true;
            this.CenterCoordTextBox.Size = new System.Drawing.Size(100, 20);
            this.CenterCoordTextBox.TabIndex = 8;
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Location = new System.Drawing.Point(152, 97);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(31, 13);
            this.ColorLabel.TabIndex = 7;
            this.ColorLabel.Text = "Color";
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Location = new System.Drawing.Point(152, 58);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(35, 13);
            this.WidthLabel.TabIndex = 6;
            this.WidthLabel.Text = "Width";
            // 
            // FindRectangleButton
            // 
            this.FindRectangleButton.Location = new System.Drawing.Point(155, 157);
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
            this.LengthLabel.Location = new System.Drawing.Point(152, 19);
            this.LengthLabel.Name = "LengthLabel";
            this.LengthLabel.Size = new System.Drawing.Size(40, 13);
            this.LengthLabel.TabIndex = 4;
            this.LengthLabel.Text = "Length";
            // 
            // ColorTextBox
            // 
            this.ColorTextBox.Location = new System.Drawing.Point(155, 113);
            this.ColorTextBox.Name = "ColorTextBox";
            this.ColorTextBox.Size = new System.Drawing.Size(100, 20);
            this.ColorTextBox.TabIndex = 3;
            this.ColorTextBox.TextChanged += new System.EventHandler(this.ColorTextBox_TextChanged);
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.Location = new System.Drawing.Point(155, 74);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(100, 20);
            this.WidthTextBox.TabIndex = 2;
            this.WidthTextBox.TextChanged += new System.EventHandler(this.WidthTextBox_TextChanged);
            // 
            // LengthTextBox
            // 
            this.LengthTextBox.Location = new System.Drawing.Point(155, 35);
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
            this.RectanglesListBox.Location = new System.Drawing.Point(6, 19);
            this.RectanglesListBox.Name = "RectanglesListBox";
            this.RectanglesListBox.Size = new System.Drawing.Size(115, 160);
            this.RectanglesListBox.TabIndex = 0;
            this.RectanglesListBox.SelectedIndexChanged += new System.EventHandler(this.RectanglesListBox_SelectedIndexChanged);
            // 
            // Rectangles
            // 
            this.Rectangles.BackColor = System.Drawing.Color.MistyRose;
            this.Rectangles.Controls.Add(this.CollisionXTextBox);
            this.Rectangles.Controls.Add(this.CollisionHeightTextBox);
            this.Rectangles.Controls.Add(this.CollisionYTextBox);
            this.Rectangles.Controls.Add(this.CollisionWidthTextBox);
            this.Rectangles.Controls.Add(this.CollisionIDTextBox);
            this.Rectangles.Controls.Add(this.RIdLabel);
            this.Rectangles.Controls.Add(this.WLabel);
            this.Rectangles.Controls.Add(this.XCooedLabel);
            this.Rectangles.Controls.Add(this.HLabel);
            this.Rectangles.Controls.Add(this.YCoordLabel);
            this.Rectangles.Controls.Add(this.SelectedRectangleLabel);
            this.Rectangles.Controls.Add(this.RemoveRectangleButton);
            this.Rectangles.Controls.Add(this.AddRectangleButton);
            this.Rectangles.Controls.Add(this.RectanglesListBoxLabel);
            this.Rectangles.Controls.Add(this.CollisionRectanglesListBox);
            this.Rectangles.Controls.Add(this.CanvasPanel);
            this.Rectangles.Location = new System.Drawing.Point(4, 22);
            this.Rectangles.Name = "Rectangles";
            this.Rectangles.Padding = new System.Windows.Forms.Padding(3);
            this.Rectangles.Size = new System.Drawing.Size(677, 509);
            this.Rectangles.TabIndex = 2;
            this.Rectangles.Text = "Rectangles";
            // 
            // CollisionXTextBox
            // 
            this.CollisionXTextBox.Location = new System.Drawing.Point(56, 271);
            this.CollisionXTextBox.Name = "CollisionXTextBox";
            this.CollisionXTextBox.Size = new System.Drawing.Size(100, 20);
            this.CollisionXTextBox.TabIndex = 15;
            this.CollisionXTextBox.TextChanged += new System.EventHandler(this.CollisionXTextBox_TextChanged);
            // 
            // CollisionHeightTextBox
            // 
            this.CollisionHeightTextBox.Location = new System.Drawing.Point(56, 352);
            this.CollisionHeightTextBox.Name = "CollisionHeightTextBox";
            this.CollisionHeightTextBox.Size = new System.Drawing.Size(100, 20);
            this.CollisionHeightTextBox.TabIndex = 14;
            this.CollisionHeightTextBox.TextChanged += new System.EventHandler(this.CollisionHeightTextBox_TextChanged);
            // 
            // CollisionYTextBox
            // 
            this.CollisionYTextBox.Location = new System.Drawing.Point(56, 297);
            this.CollisionYTextBox.Name = "CollisionYTextBox";
            this.CollisionYTextBox.Size = new System.Drawing.Size(100, 20);
            this.CollisionYTextBox.TabIndex = 13;
            this.CollisionYTextBox.TextChanged += new System.EventHandler(this.CollisionYTextBox_TextChanged);
            // 
            // CollisionWidthTextBox
            // 
            this.CollisionWidthTextBox.Location = new System.Drawing.Point(56, 323);
            this.CollisionWidthTextBox.Name = "CollisionWidthTextBox";
            this.CollisionWidthTextBox.Size = new System.Drawing.Size(100, 20);
            this.CollisionWidthTextBox.TabIndex = 12;
            this.CollisionWidthTextBox.TextChanged += new System.EventHandler(this.CollisionWidthTextBox_TextChanged);
            // 
            // CollisionIDTextBox
            // 
            this.CollisionIDTextBox.Location = new System.Drawing.Point(56, 241);
            this.CollisionIDTextBox.Name = "CollisionIDTextBox";
            this.CollisionIDTextBox.ReadOnly = true;
            this.CollisionIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.CollisionIDTextBox.TabIndex = 11;
            // 
            // RIdLabel
            // 
            this.RIdLabel.AutoSize = true;
            this.RIdLabel.Location = new System.Drawing.Point(31, 248);
            this.RIdLabel.Name = "RIdLabel";
            this.RIdLabel.Size = new System.Drawing.Size(19, 13);
            this.RIdLabel.TabIndex = 10;
            this.RIdLabel.Text = "Id:";
            // 
            // WLabel
            // 
            this.WLabel.AutoSize = true;
            this.WLabel.Location = new System.Drawing.Point(12, 330);
            this.WLabel.Name = "WLabel";
            this.WLabel.Size = new System.Drawing.Size(38, 13);
            this.WLabel.TabIndex = 9;
            this.WLabel.Text = "Width:";
            // 
            // XCooedLabel
            // 
            this.XCooedLabel.AutoSize = true;
            this.XCooedLabel.Location = new System.Drawing.Point(33, 271);
            this.XCooedLabel.Name = "XCooedLabel";
            this.XCooedLabel.Size = new System.Drawing.Size(17, 13);
            this.XCooedLabel.TabIndex = 8;
            this.XCooedLabel.Text = "X:";
            // 
            // HLabel
            // 
            this.HLabel.AutoSize = true;
            this.HLabel.Location = new System.Drawing.Point(9, 355);
            this.HLabel.Name = "HLabel";
            this.HLabel.Size = new System.Drawing.Size(41, 13);
            this.HLabel.TabIndex = 7;
            this.HLabel.Text = "Height:";
            // 
            // YCoordLabel
            // 
            this.YCoordLabel.AutoSize = true;
            this.YCoordLabel.Location = new System.Drawing.Point(33, 300);
            this.YCoordLabel.Name = "YCoordLabel";
            this.YCoordLabel.Size = new System.Drawing.Size(17, 13);
            this.YCoordLabel.TabIndex = 6;
            this.YCoordLabel.Text = "Y:";
            // 
            // SelectedRectangleLabel
            // 
            this.SelectedRectangleLabel.AutoSize = true;
            this.SelectedRectangleLabel.Location = new System.Drawing.Point(6, 225);
            this.SelectedRectangleLabel.Name = "SelectedRectangleLabel";
            this.SelectedRectangleLabel.Size = new System.Drawing.Size(99, 13);
            this.SelectedRectangleLabel.TabIndex = 5;
            this.SelectedRectangleLabel.Text = "Selected rectangle:";
            // 
            // RemoveRectangleButton
            // 
            this.RemoveRectangleButton.FlatAppearance.BorderSize = 0;
            this.RemoveRectangleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveRectangleButton.Location = new System.Drawing.Point(189, 188);
            this.RemoveRectangleButton.Name = "RemoveRectangleButton";
            this.RemoveRectangleButton.Size = new System.Drawing.Size(55, 34);
            this.RemoveRectangleButton.TabIndex = 4;
            this.RemoveRectangleButton.Text = "Remove";
            this.RemoveRectangleButton.UseVisualStyleBackColor = true;
            this.RemoveRectangleButton.Click += new System.EventHandler(this.RemoveRectangleButton_Click);
            // 
            // AddRectangleButton
            // 
            this.AddRectangleButton.FlatAppearance.BorderSize = 0;
            this.AddRectangleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddRectangleButton.Location = new System.Drawing.Point(89, 188);
            this.AddRectangleButton.Name = "AddRectangleButton";
            this.AddRectangleButton.Size = new System.Drawing.Size(39, 34);
            this.AddRectangleButton.TabIndex = 3;
            this.AddRectangleButton.Text = "Add";
            this.AddRectangleButton.UseVisualStyleBackColor = true;
            this.AddRectangleButton.Click += new System.EventHandler(this.AddRectangleButton_Click);
            // 
            // RectanglesListBoxLabel
            // 
            this.RectanglesListBoxLabel.AutoSize = true;
            this.RectanglesListBoxLabel.Location = new System.Drawing.Point(8, 8);
            this.RectanglesListBoxLabel.Name = "RectanglesListBoxLabel";
            this.RectanglesListBoxLabel.Size = new System.Drawing.Size(64, 13);
            this.RectanglesListBoxLabel.TabIndex = 2;
            this.RectanglesListBoxLabel.Text = "Rectangles:";
            // 
            // CollisionRectanglesListBox
            // 
            this.CollisionRectanglesListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CollisionRectanglesListBox.FormattingEnabled = true;
            this.CollisionRectanglesListBox.Location = new System.Drawing.Point(11, 24);
            this.CollisionRectanglesListBox.Name = "CollisionRectanglesListBox";
            this.CollisionRectanglesListBox.Size = new System.Drawing.Size(313, 158);
            this.CollisionRectanglesListBox.TabIndex = 1;
            this.CollisionRectanglesListBox.SelectedIndexChanged += new System.EventHandler(this.CollisionRectanglesListBox_SelectedIndexChanged);
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
            this.CanvasPanel.Location = new System.Drawing.Point(330, 5);
            this.CanvasPanel.MaximumSize = new System.Drawing.Size(600, 800);
            this.CanvasPanel.Name = "CanvasPanel";
            this.CanvasPanel.Size = new System.Drawing.Size(344, 498);
            this.CanvasPanel.TabIndex = 0;
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
            this.Enums.ResumeLayout(false);
            this.Enums.PerformLayout();
            this.SeasonGroupBox.ResumeLayout(false);
            this.SeasonGroupBox.PerformLayout();
            this.WeekdayGroupBox.ResumeLayout(false);
            this.WeekdayGroupBox.PerformLayout();
            this.EnumerationsGroupBox.ResumeLayout(false);
            this.EnumerationsGroupBox.PerformLayout();
            this.Classes.ResumeLayout(false);
            this.MovieGroupBox.ResumeLayout(false);
            this.MovieGroupBox.PerformLayout();
            this.RectanglesGroupBox.ResumeLayout(false);
            this.RectanglesGroupBox.PerformLayout();
            this.Rectangles.ResumeLayout(false);
            this.Rectangles.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTabControl;
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
        private System.Windows.Forms.GroupBox EnumerationsGroupBox;
        private System.Windows.Forms.GroupBox SeasonGroupBox;
        private System.Windows.Forms.GroupBox WeekdayGroupBox;
        private System.Windows.Forms.ComboBox SeasonHandleComboBox;
        private System.Windows.Forms.TabPage Classes;
        private System.Windows.Forms.GroupBox MovieGroupBox;
        private System.Windows.Forms.ListBox MoviesListBox;
        private System.Windows.Forms.GroupBox RectanglesGroupBox;
        private System.Windows.Forms.Label ColorLabel;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.Button FindRectangleButton;
        private System.Windows.Forms.Label LengthLabel;
        private System.Windows.Forms.TextBox ColorTextBox;
        private System.Windows.Forms.TextBox WidthTextBox;
        private System.Windows.Forms.TextBox LengthTextBox;
        private System.Windows.Forms.ListBox RectanglesListBox;
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
        private System.Windows.Forms.Label CenterCoordinatesLabel;
        private System.Windows.Forms.TextBox CenterCoordTextBox;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.TabPage Rectangles;
        private System.Windows.Forms.Button RemoveRectangleButton;
        private System.Windows.Forms.Button AddRectangleButton;
        private System.Windows.Forms.Label RectanglesListBoxLabel;
        private System.Windows.Forms.ListBox CollisionRectanglesListBox;
        private System.Windows.Forms.Panel CanvasPanel;
        private System.Windows.Forms.TextBox CollisionXTextBox;
        private System.Windows.Forms.TextBox CollisionHeightTextBox;
        private System.Windows.Forms.TextBox CollisionYTextBox;
        private System.Windows.Forms.TextBox CollisionWidthTextBox;
        private System.Windows.Forms.TextBox CollisionIDTextBox;
        private System.Windows.Forms.Label RIdLabel;
        private System.Windows.Forms.Label WLabel;
        private System.Windows.Forms.Label XCooedLabel;
        private System.Windows.Forms.Label HLabel;
        private System.Windows.Forms.Label YCoordLabel;
        private System.Windows.Forms.Label SelectedRectangleLabel;
    }
}

