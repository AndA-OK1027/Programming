using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using View.Model.Services;

namespace View.ViewModel
{
    /// <summary>
    /// Класс для команды сохранения.
    /// </summary>
    public class RelayCommand : ICommand
    {
        /// <summary>
        /// Делегат действия команды.
        /// </summary>
        private Action<object> _execute;
        /// <summary>
        /// Делегат возможности выполнения команды.
        /// </summary>
        private Predicate<object> _canExecute;

        /// <summary>
        /// Обработчик события изменения возможности выполнения команды.
        /// </summary>
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        /// <summary>
        /// Определяет может ли выполниться команда.
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns> true, если может выполниться иначе false </returns>
        public bool CanExecute(object parameter)
        {
            return _canExecute == null || _canExecute(parameter);
        }

        /// <summary>
        /// Действие команды.
        /// </summary>
        /// <param name="parameter"></param>
        public void Execute(object parameter)
        {
            _execute(parameter);
        }

        /// <summary>
        /// Конструктор команды.
        /// </summary>
        /// <param name="execute"></param>
        /// <param name="canExecute"></param>
        public RelayCommand(Action<object> execute, Predicate<object> canExecute = null)
        {
            _execute = execute ?? throw new ArgumentNullException(nameof(execute));
            _canExecute = canExecute;
        }
    }
}
