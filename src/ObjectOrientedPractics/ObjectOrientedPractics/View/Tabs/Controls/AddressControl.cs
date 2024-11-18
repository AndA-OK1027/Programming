using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics
{
    /// <summary>
    /// Отвечает за работу с классом адреса
    /// </summary>
    public partial class AddressControl : UserControl
    {
        /// <summary>
        /// Инициализирует компоненты элемента управления
        /// </summary>
        public AddressControl()
        {
            InitializeComponent();
            _address = new Address();
        }

        private Address _address;
        
        /// <summary>
        /// Задает и возвращает новый объект типа Address
        /// </summary>
        public Address Address
        {
            get 
            {
                return new Address(Convert.ToInt32(IndexTextBox.Text), CountryTextBox.Text, CityTextBox.Text, StreetTextBox.Text, BuildingTextBox.Text, ApartmentTextBox.Text); 
                
            }
            set
            {
                _address = value ?? new Address();
            }
        }

        /// <summary>
        /// Отображает данные о выбранном объекте в текстовых полях.
        /// </summary>
        /// <param name="address">адрес</param>
        public void DisplayAddress(Address address)
        {
            IndexTextBox.Text = address.Index.ToString();
            CountryTextBox.Text = address.Country;
            CityTextBox.Text = address.City;
            StreetTextBox.Text = address.Street;
            BuildingTextBox.Text = address.Building;
            ApartmentTextBox.Text = address.Apartment;
        }

        /// <summary>
        /// Событие при изменения текста в поле почтового индекса
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IndexTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.Index = Convert.ToInt32(IndexTextBox.Text);
                IndexTextBox.BackColor = Color.White;
            }
            catch
            {
                IndexTextBox.BackColor = Color.LightPink;
            }
        }

        /// <summary>
        /// Событие при изменения текста в поле страны
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CountryTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.Country = CountryTextBox.Text;
                CountryTextBox.BackColor = Color.White;
            }
            catch
            {
                CountryTextBox.BackColor = Color.LightPink;
            }
        }

        /// <summary>
        /// Событие при изменения текста в поле города
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.City = CityTextBox.Text;
                CityTextBox.BackColor = Color.White;
            }
            catch
            {
                CityTextBox.BackColor = Color.LightPink;
            }
        }

        /// <summary>
        /// Событие при изменения текста в поле улицы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StreetTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.Street = StreetTextBox.Text;
                StreetTextBox.BackColor = Color.White;
            }
            catch
            {
                StreetTextBox.BackColor = Color.LightPink;
            }
        }

        /// <summary>
        /// Событие при изменения текста в поле номера здания
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BuildingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.Building = BuildingTextBox.Text;
                BuildingTextBox.BackColor = Color.White;
            }
            catch
            {
                BuildingTextBox.BackColor = Color.LightPink;
            }
        }

        /// <summary>
        /// Событие при изменения текста в поле номера квартиры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ApartmentTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.Apartment = ApartmentTextBox.Text;
                ApartmentTextBox.BackColor = Color.White;
            }
            catch
            {
                ApartmentTextBox.BackColor = Color.LightPink;
            }
        }
    }
}
