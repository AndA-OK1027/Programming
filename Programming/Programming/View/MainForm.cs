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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// При нажатии кнопки в пользовательском элементе управления меняет цвет главного окна при определенных условиях.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void seasonsControl1_ButtonClicked(object sender, EventArgs e)
        {
            if (seasonsControl1.isSpring) { Enums.BackColor = System.Drawing.Color.FromArgb(147, 222, 140); }
            if (seasonsControl1.isFall) { Enums.BackColor = System.Drawing.Color.FromArgb(242, 178, 39); }
        }
    }
}
