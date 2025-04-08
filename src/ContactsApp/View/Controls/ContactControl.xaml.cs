using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using View.Model;

namespace View.Controls
{
    /// <summary>
    /// Элемент управления, осуществляющий ввод в текстовых полях.
    /// </summary>
    public partial class ContactControl : UserControl
    {
        /// <summary>
        /// Обработка события при возникновении ошибке в поле ввода.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBox_Error(object sender, ValidationErrorEventArgs e)
        {
            MessageBox.Show(e.Error.ErrorContent.ToString());
        }

        /// <summary>
        /// Обработка события при вводе текста.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PhoneNumber_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            var textBox = sender as TextBox;
            var newText = textBox.Text.Insert(textBox.CaretIndex, e.Text);
            if (!Contact.PhoneNumberRegex.IsMatch(newText))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Обработка события при вставке текста из буфера обмена.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PhoneNumber_Pasting(object sender, DataObjectPastingEventArgs e)
        {
            if (!e.DataObject.GetDataPresent(typeof(string)))
            {
                e.CancelCommand();
                return;
            }

            var text = (string)e.DataObject.GetData(typeof(string));
            if (!Contact.PhoneNumberRegex.IsMatch(text))
            {
                e.CancelCommand();
            }
        }

        /// <summary>
        /// Инициализирует компоненты.
        /// </summary>
        public ContactControl()
        {
            InitializeComponent();
        }
    }
}
