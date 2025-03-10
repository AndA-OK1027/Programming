using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

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
        /// Сохраняет в json-файл данные о контакте.
        /// </summary>
        /// <param name="contact"> объект, который необходимо сохранить</param>
        public void Save(Contact contact)
        {
            string json = JsonConvert.SerializeObject(contact);

            File.WriteAllText(_path, json);
        }

        /// <summary>
        /// Загружает данные из файла.
        /// </summary>
        /// <returns> объект полученный из файла</returns>
        public Contact Load() 
        { 
            if (File.Exists(_path)) 
            {
                string json = File.ReadAllText(_path);

                return JsonConvert.DeserializeObject<Contact>(json);
            }

            return new Contact();
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
