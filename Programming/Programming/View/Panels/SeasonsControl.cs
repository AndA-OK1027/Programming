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
    public partial class SeasonsControl : UserControl
    {
        public SeasonsControl()
        {
            InitializeComponent();
        }

        private void SeasonsControl_Load(object sender, EventArgs e)
        {
            //Изначально задается список всех времен года.
            SeasonHandleComboBox.DataSource = Enum.GetValues(typeof(Season));
        }

        private void SeasonHandleButton_Click(object sender, EventArgs e)
        {
            var selected = SeasonHandleComboBox.SelectedItem;
            switch (selected)
            {
                case Season.Winter:
                    MessageBox.Show("Холодно");
                    break;
                case Season.Spring:
                    this.BackColor = System.Drawing.Color.FromArgb(147, 222, 140);
                    break;
                case Season.Summer:
                    MessageBox.Show("Тепло");
                    break;
                case Season.Fall:
                    this.BackColor = System.Drawing.Color.FromArgb(242, 178, 39);
                    break;
            }
        }
    }
}
