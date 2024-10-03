using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming
{
    /// <summary>
    /// Хранит информацию об элементе управления, осуществляющим действия с прямоугольниками.
    /// </summary>
    public partial class RectanglesControl : UserControl
    {
        /// <summary>
        /// Инициализирует компоненты элемента управления.
        /// </summary>
        public RectanglesControl()
        {
            InitializeComponent();

            Random rand = new Random();
            Point2D center = new Point2D(rand.Next(1, 255), rand.Next(1, 255));
            //Массив прямоугольников заполняется случайной длиной и шириной
            for (int i = 0; i < 5; i++)
            {
                Rectangle rectangle = new Rectangle(rand.Next(2, 100), rand.Next(2, 100), "color", center);
                rectangles[i] = rectangle;
            }
        }
        
        private Rectangle[] rectangles = new Rectangle[5];
        private Rectangle currentRectangle;

        /// <summary>
        /// Возвращает индекс прямоугольника с наибольшей шириной.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private int FindRectangleWithMaxWidth(Rectangle[] rectangles)
        {
            int indexMax = 0;
            for (int i = 0; i < rectangles.Length; i++)
            {
                if (rectangles[i].Width > rectangles[indexMax].Width)
                {
                    indexMax = i;
                }
            }
            return indexMax;
        }

        /// <summary>
        /// Кнопка, находящая прямоугольник с максимальной шириной.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FindRectangleButton_Click(object sender, EventArgs e)
        {
            RectanglesListBox.SelectedIndex = FindRectangleWithMaxWidth(rectangles);
        }

        /// <summary>
        /// При смене индекса появляются значения выбранного объекта класса
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = RectanglesListBox.SelectedIndex;

            if (index != -1)
            {
                currentRectangle = rectangles[index];

                LengthTextBox.Text = currentRectangle.Height.ToString();

                WidthTextBox.Text = currentRectangle.Width.ToString();

                ColorTextBox.Text = currentRectangle.Color;

                CenterCoordTextBox.Text = "(" + currentRectangle.Center.X.ToString() + " ; " + currentRectangle.Center.Y.ToString() + ")";

                IdTextBox.Text = currentRectangle.Id.ToString();
            }

        }
        /// <summary>
        /// При смене текста в поле длины меняет значение в текущем прямоугольнике, при неправильном вводе меняет цвет поля ввода на красный
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LengthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                currentRectangle.Height = Convert.ToInt32(LengthTextBox.Text);
                LengthTextBox.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                LengthTextBox.BackColor = System.Drawing.Color.LightPink;
            }

        }

        /// <summary>
        /// При смене текста в поле ширины меняет значение в текущем прямоугольнике, при неправильном вводе меняет цвет поля ввода на красный
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                currentRectangle.Width = Convert.ToInt32(WidthTextBox.Text);
                WidthTextBox.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                WidthTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        /// <summary>
        /// При смене текста в поле цвета меняет значение в текущем прямоугольнике
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {
            currentRectangle.Color = ColorTextBox.Text;
        }
    }
}
