using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ObjectOrientedPractics
{
    public partial class MainForm : Form
    {

        /// <summary>
        /// Инициализирует элементы главного окна.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            ItemsTab.Items = _store.Items;
            UsersTab.Customers = _store.Customers;
        }

        Store _store = new Store();
        
    }
}

