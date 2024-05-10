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
    public partial class RectangleCollisionControl : UserControl
    {
        private List<Rectangle> _rectangles = new List<Rectangle>();
        private Rectangle _currentRectangle;

        private List<Panel> _rectanglePanels = new List<Panel>();
        private Panel _currentPanel;

        public RectangleCollisionControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// При нажатии кнопки добавляет прямоугольник в список rectangles и отображает его на канве.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddRectangleButton_Click(object sender, EventArgs e)
        {
            Rectangle rectangle = RectangleFactory.Randomize();
            _rectangles.Add(rectangle);
            CollisionRectanglesListBox.Items.Add($"{rectangle.Id}:(X={rectangle.Center.X}, Y={rectangle.Center.Y}, W={rectangle.Width}, H={rectangle.Height})");
            //CollisionRectanglesListBox.Items.Add(rectangle);
            Panel panel = new Panel();
            panel.BackColor = System.Drawing.Color.FromArgb(100, 100, 255, 127);
            int panelX = rectangle.Center.X - rectangle.Width / 2;
            int panelY = rectangle.Center.Y - rectangle.Height / 2;
            panel.Location = new Point(panelX, panelY);
            panel.Width = rectangle.Width;
            panel.Height = rectangle.Height;
            _rectanglePanels.Add(panel);
            FindCollisions();
            CanvasPanel.Controls.Add(panel);

        }

        /// <summary>
        /// При нажатии кнопки удаляет прямоугольник из списка и с канвы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveRectangleButton_Click(object sender, EventArgs e)
        {
            var index = CollisionRectanglesListBox.SelectedIndex;
            if (index != -1)
            {
                var deleted = _rectangles[index];
                CollisionRectanglesListBox.Items.Remove(CollisionRectanglesListBox.SelectedItem);
                CanvasPanel.Controls.RemoveAt(index);
                _rectangles.Remove((Rectangle)deleted);
                _rectanglePanels.RemoveAt(index);
                FindCollisions();
            }
        }

        /// <summary>
        /// При выборе объекта в ListBox  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CollisionRectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = CollisionRectanglesListBox.SelectedIndex;
            //Выполняются действия, только если выбран объект в списке.
            if (index != -1)
            {
                _currentRectangle = _rectangles[index];
                ChangeRectangleInfo(_currentRectangle);
                _currentPanel = _rectanglePanels[index];
                //Вычисляем координаты отображаемого прямоугольника, использую координаты центра, заданные объектом класса Rectangle.
                int panelX = _currentRectangle.Center.X - _currentRectangle.Width / 2;
                int panelY = _currentRectangle.Center.Y - _currentRectangle.Height / 2;
                //Задаем свойства отображаемой панели.
                _currentPanel.Location = new Point(panelX, panelY);
                _currentPanel.Width = _currentRectangle.Width;
                _currentPanel.Height = _currentRectangle.Height;
                //Поиск пересечений.
                FindCollisions();

            }
            else
            {
                //Если ни одного объекта не выбрано, очищаются текстовые поля.
                ClearRectangleInfo();
            }

        }

        /// <summary>
        /// При изменении текста в поле для координаты X, меняет соответствующее свойство прямоугольника.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CollisionXTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CollisionRectanglesListBox.SelectedIndex != -1)
            {
                try
                {
                    _currentRectangle.Center.X = Convert.ToInt32(CollisionXTextBox.Text);
                    CollisionXTextBox.BackColor = System.Drawing.Color.White;
                }
                catch
                {
                    CollisionXTextBox.BackColor = System.Drawing.Color.LightPink;
                }
            }
        }

        /// <summary>
        /// При изменении текста в поле для координаты Y, меняет соответствующее свойство прямоугольника.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CollisionYTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CollisionRectanglesListBox.SelectedIndex != -1)
            {
                try
                {
                    _currentRectangle.Center.Y = Convert.ToInt32(CollisionYTextBox.Text);
                    CollisionYTextBox.BackColor = System.Drawing.Color.White;
                }
                catch
                {
                    CollisionYTextBox.BackColor = System.Drawing.Color.LightPink;
                }
            }
        }

        /// <summary>
        /// При изменении текста в поле для ширины, меняет соответствующее свойство прямоугольника.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CollisionWidthTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CollisionRectanglesListBox.SelectedIndex != -1)
            {
                try
                {
                    _currentRectangle.Width = Convert.ToInt32(CollisionWidthTextBox.Text);
                    CollisionWidthTextBox.BackColor = System.Drawing.Color.White;
                }
                catch
                {
                    CollisionWidthTextBox.BackColor = System.Drawing.Color.LightPink;
                }
            }
        }

        /// <summary>
        /// При изменении текста в поле для высоты, меняет соответствующее свойство прямоугольника.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CollisionHeightTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CollisionRectanglesListBox.SelectedIndex != -1)
            {
                try
                {
                    _currentRectangle.Height = Convert.ToInt32(CollisionHeightTextBox.Text);
                    CollisionHeightTextBox.BackColor = System.Drawing.Color.White;

                }
                catch
                {
                    CollisionHeightTextBox.BackColor = System.Drawing.Color.LightPink;
                }
            }

        }

        /// <summary>
        /// Находит на канве пересекающиеся прямоугольники и подсвечивает их красным.
        /// </summary>
        private void FindCollisions()
        {
            foreach (Panel panel in _rectanglePanels)
            {
                panel.BackColor = System.Drawing.Color.FromArgb(127, 127, 255, 127);

            }
            for (int i = 0; i < _rectangles.Count; i++)
            {
                for (int j = i + 1; j < _rectangles.Count; j++)
                {
                    if (CollisionManager.IsCollision(_rectangles[i], _rectangles[j]))
                    {
                        _rectanglePanels[i].BackColor = AppColors.WrongIndicator;
                        _rectanglePanels[j].BackColor = AppColors.WrongIndicator;
                    }
                }
            }
        }

        /// <summary>
        /// Очищает все текстовые поля со значениями прямоугольника.
        /// </summary>
        private void ClearRectangleInfo()
        {
            CollisionIDTextBox.Text = String.Empty;
            CollisionXTextBox.Text = String.Empty;
            CollisionYTextBox.Text = String.Empty;
            CollisionWidthTextBox.Text = String.Empty;
            CollisionHeightTextBox.Text = String.Empty;
        }

        /// <summary>
        /// Выводит данные о прямоугольнике, выбранном в списке.
        /// </summary>
        /// <param name="_currentRectangle"></param>
        private void ChangeRectangleInfo(Rectangle _currentRectangle)
        {
            CollisionIDTextBox.Text = _currentRectangle.Id.ToString();
            CollisionXTextBox.Text = _currentRectangle.Center.X.ToString();
            CollisionYTextBox.Text = _currentRectangle.Center.Y.ToString();
            CollisionWidthTextBox.Text = _currentRectangle.Width.ToString();
            CollisionHeightTextBox.Text = _currentRectangle.Height.ToString();
        }

    }
}
