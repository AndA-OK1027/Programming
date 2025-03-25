using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Windows;
using System.Collections.ObjectModel;

namespace View.Model.Services
{
    /// <summary>
    /// Класс для сериализации объектов класса Contact.
    /// </summary>
    public class ContactSerializer
    {
        /// <summary>
        /// Путь к файлу сохранения
        /// </summary>
        private readonly string _path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Contacts", "Contacts.json");

        /// <summary>
        /// Сохраняет в json-файл данные о контактах.
        /// </summary>
        /// <param name="contacts"> список объектов, которые необходимо сохранить</param>
        public void Save(ObservableCollection<Contact> contacts)
        {
            try
            {
                string json = JsonConvert.SerializeObject(contacts);
                File.WriteAllText(_path, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сериализации контактов: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        /// <summary>
        /// Загружает данные из файла.
        /// </summary>
        /// <returns> объекты полученные из файла</returns>
        public ObservableCollection<Contact> Load() 
        {
            try
            {
                if (File.Exists(_path))
                {
                    string json = File.ReadAllText(_path);
                    return JsonConvert.DeserializeObject<ObservableCollection<Contact>>(json);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при десериализации контактов: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);

                return new ObservableCollection<Contact>();
            }

            return new ObservableCollection<Contact>();
        }

        /// <summary>
        /// Конструктор класса, в котором создается файл.
        /// </summary>
        public ContactSerializer() 
        {
            if (!Directory.Exists(Path.GetDirectoryName(_path)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(_path));
            }
        }
    }
}
