using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThemingControl {
    // this code inspired by Microsoft article retrieved from:
    // https://social.technet.microsoft.com/wiki/contents/articles/18199.event-handling-in-an-mvvm-wpf-application.aspx
    public class DelegateCommand<T> : System.Windows.Input.ICommand where T : class? {
        //=============================================
        // FIELDS
        //=============================================
        private readonly Predicate<T> _canExecute;
        private readonly Action<T> _execute;


        //=============================================
        // CONSTRUCTORS
        //=============================================
        public DelegateCommand(Action<T> execute) : this(execute, null) { }

        public DelegateCommand(Action<T> execute, Predicate<T> canExecute) {
            _canExecute = canExecute;
            _execute = execute;
        }


        //=============================================
        // PROPERTIES
        //=============================================
        public event EventHandler CanExecuteChanged;


        //=============================================
        // METHODS
        //=============================================
        public bool CanExecute(object parameter) {
            if (this._canExecute == null) { return true; }

            return _canExecute((T)parameter);
        }

        public void Execute(object parameter) {
            _execute((T)parameter);
        }

        public void RaiseCanExecuteChanged() {
            if (CanExecuteChanged != null)
            {
                CanExecuteChanged(this, EventArgs.Empty);
            }
        }
    }
}
