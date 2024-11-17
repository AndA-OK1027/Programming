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
    public partial class AddressControl : UserControl
    {
        public AddressControl()
        {
            InitializeComponent();
        }

        private Address _address = new Address();
        public Address CurrentAddress = new Address();

        public Address Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = new Address(Convert.ToInt32(IndexTextBox.Text), CountryTextBox.Text, CityTextBox.Text,
                     StreetTextBox.Text, BuildingTextBox.Text, ApartmentTextBox.Text); ;
            }
        }

        public void DisplayAddress(Address address) 
        {
            if (_address == null) 
            {
                return;
            }
            else 
            {
                IndexTextBox.Text = address.Index.ToString();
                CountryTextBox.Text = address.Country;
                CityTextBox.Text = address.City;
                StreetTextBox.Text = address.Street;
                BuildingTextBox.Text = address.Building;
                ApartmentTextBox.Text = address.Apartment;
            }
        }

        private void IndexTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CurrentAddress.Index = Convert.ToInt32(IndexTextBox.Text);
                IndexTextBox.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                IndexTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void CountryTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CurrentAddress.Country = CountryTextBox.Text;
                CountryTextBox.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                CountryTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void StreetTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CurrentAddress.Street = StreetTextBox.Text;
                StreetTextBox.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                StreetTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void BuildingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CurrentAddress.Building = BuildingTextBox.Text;
                BuildingTextBox.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                BuildingTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CurrentAddress.City = CityTextBox.Text;
                CityTextBox.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                CityTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void ApartmentTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CurrentAddress.Apartment = ApartmentTextBox.Text;
                ApartmentTextBox.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                ApartmentTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

    }
}
