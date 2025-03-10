using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using View.Model.Services;

namespace View.ViewModel
{
    /// <summary>
    /// Класс для команды загрузки.
    /// </summary>
    public class LoadCommand : ICommand
    {
        private ContactSerializer _serializer;

        private MainVM _mainVM;

        public event EventHandler? CanExecuteChanged;

        /// <summary>
        /// Определяет может ли выполниться команда.
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns> true, если может выполниться иначе false </returns>
        public bool CanExecute(object? parameter)
        {
            return true;
        }

        /// <summary>
        /// Метод при вызове команды.
        /// </summary>
        /// <param name="parameter"></param>
        public void Execute(object? parameter)
        {
            _mainVM.Contact = _serializer.Load();
        }

        /// <summary>
        /// Команда загрузки.
        /// </summary>
        /// <param name="serializer"></param>
        /// <param name="mainVM"></param>
        public LoadCommand(ContactSerializer serializer, MainVM mainVM)
        {
            _serializer = serializer;
            _mainVM = mainVM;
        }
    }
}
