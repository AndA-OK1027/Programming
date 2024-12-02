namespace ObjectOrientedPractics.View.Controls
{
    /// <summary>
    /// Отвечает за работу с классом адреса
    /// </summary>
    public partial class AddressControl : UserControl
    {
        /// <summary>
        /// Хранит данные о корректности данных.
        /// </summary>
        private bool _isAddressDataValid = true;

        /// <summary>
        /// Адрес покупателя.
        /// </summary>
        private Address _address = new();

        /// <summary>
        /// Возвращает и задает адрес объекта. В gettere возвращает <see cref="CheckIfAddressDataValid"/>. Через setter задает Textboxes.
        /// </summary>
        public Address Address
        {
            get
            {
                CheckIfAddressDataValid();
                return _address;
            }
            set
            {
                _address = value;
                ShowAddressInfo();
            }
        }

        /// <summary>
        /// Инициализирует компоненты класса.
        /// </summary>
        public AddressControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Вносит данные в <see cref="IndexTextBox"/> данные.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IndexTextBox_TextChanged(object sender, EventArgs e)
        {
            IndexTextBox.BackColor = Color.White;
            _isAddressDataValid = true;

            if (String.IsNullOrEmpty(IndexTextBox.Text))
            {
                _isAddressDataValid = false;
                IndexTextBox.BackColor = Color.LightPink;
                return;
            }
            try
            {
                _address.Index = int.Parse(IndexTextBox.Text);
            }
            catch (Exception ex)
            {
                _isAddressDataValid = false;
                IndexTextBox.BackColor = Color.LightPink;
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            CheckIfAddressDataValid();
        }

        /// <summary>
        /// Вносит данные в <see cref="CountryTextBox"/> данные.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CountryTextBox_TextChanged(object sender, EventArgs e)
        {
            CountryTextBox.BackColor = Color.White;
            _isAddressDataValid = true;

            if (String.IsNullOrEmpty(CountryTextBox.Text))
            {
                _isAddressDataValid = false;
                CountryTextBox.BackColor = Color.LightPink;
                return;
            }
            try
            {
                _address.Country = CountryTextBox.Text;
            }
            catch (Exception ex)
            {
                _isAddressDataValid = false;
                CountryTextBox.BackColor = Color.LightPink;
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CheckIfAddressDataValid();
        }

        /// <summary>
        /// Вносит данные в <see cref="CityTextBox"/> данные.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            CityTextBox.BackColor = Color.White;
            _isAddressDataValid = true;

            if (String.IsNullOrEmpty(CityTextBox.Text))
            {
                _isAddressDataValid = false;
                CityTextBox.BackColor = Color.LightPink;
                return;
            }
            try
            {
                _address.City = CityTextBox.Text;
            }
            catch (Exception ex)
            {
                _isAddressDataValid = false;
                CityTextBox.BackColor = Color.LightPink;
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CheckIfAddressDataValid();
        }

        /// <summary>
        /// Вносит данные в <see cref="StreetTextBox"/> данные.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StreetTextBox_TextChanged(object sender, EventArgs e)
        {
            StreetTextBox.BackColor = Color.White;
            _isAddressDataValid = true;

            if (String.IsNullOrEmpty(StreetTextBox.Text))
            {
                _isAddressDataValid = false;
                StreetTextBox.BackColor = Color.LightPink;
                return;
            }
            try
            {
                _address.Street = StreetTextBox.Text;
            }
            catch (Exception ex)
            {
                _isAddressDataValid = false;
                StreetTextBox.BackColor = Color.LightPink;
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CheckIfAddressDataValid();
        }

        /// <summary>
        /// Вносит данные в <see cref="BuildingTextBox"/> данные.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BuildingTextBox_TextChanged(object sender, EventArgs e)
        {
            BuildingTextBox.BackColor = Color.White;
            _isAddressDataValid = true;

            if (String.IsNullOrEmpty(BuildingTextBox.Text))
            {
                _isAddressDataValid = false;
                BuildingTextBox.BackColor = Color.LightPink;
                return;
            }
            try
            {
                _address.Building = BuildingTextBox.Text;
            }
            catch (Exception ex)
            {
                _isAddressDataValid = false;
                BuildingTextBox.BackColor = Color.LightPink;
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CheckIfAddressDataValid();
        }

        /// <summary>
        /// Вносит данные в <see cref="ApartmentTextBox"/> данные.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ApartmentTextBox_TextChanged(object sender, EventArgs e)
        {
            ApartmentTextBox.BackColor = Color.White;
            _isAddressDataValid = true;

            if (String.IsNullOrEmpty(ApartmentTextBox.Text))
            {
                _isAddressDataValid = false;
                ApartmentTextBox.BackColor = Color.LightPink;
                return;
            }
            try
            {
                _address.Apartment = ApartmentTextBox.Text;
            }
            catch (Exception ex)
            {
                _isAddressDataValid = false;
                ApartmentTextBox.BackColor = Color.LightPink;
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CheckIfAddressDataValid();
        }

        /// <summary>
        /// Возвращает истинность валидности данных.
        /// </summary>
        /// <returns>True если данные корректны, иначе false.</returns>
        public bool CheckIfAddressDataValid()
        {
            return _isAddressDataValid;
        }

        /// <summary>
        /// Записывает в Textboxes данные из полей адреса.
        /// </summary>
        private void ShowAddressInfo()
        {
            IndexTextBox.Text = _address.Index.ToString();
            ApartmentTextBox.Text = _address.Apartment.ToString();
            BuildingTextBox.Text = _address.Building.ToString();
            StreetTextBox.Text = _address.Street.ToString();
            CountryTextBox.Text = _address.Country.ToString();
            CityTextBox.Text = _address.City.ToString();
        }
    }
}
