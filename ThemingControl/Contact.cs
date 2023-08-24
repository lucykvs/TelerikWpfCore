using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThemingControl {
    public class Contact : INotifyPropertyChanged {

        public event PropertyChangedEventHandler PropertyChanged;
        private string _firstName;
        private string _lastName;

        public string FirstName {
            get
            {
                return this._firstName;
            }
            set
            {
                if (this._firstName != value)
                {
                    this._firstName = value;
                    this.OnPropertyChanged(nameof(FirstName));
                }
            }
        }

        public string LastName {
            get
            {
                return this._lastName;
            }
            set
            {
                if (this._lastName != value)
                {
                    this._lastName = value;
                    this.OnPropertyChanged(nameof(LastName));
                }
            }
        }

        protected virtual void OnPropertyChanged(PropertyChangedEventArgs args) {
            PropertyChangedEventHandler handler = this.PropertyChanged;
            if (handler != null)
            {
                handler(this, args);
            }
        }

        private void OnPropertyChanged(string propertyName) {
            this.OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
        }
    }
}
