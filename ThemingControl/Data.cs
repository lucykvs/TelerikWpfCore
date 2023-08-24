using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace ThemingControl {
    public class Data {
        ObservableCollection<Contact> contactsList = new ObservableCollection<Contact>();

        protected void GetContactData() {
            contactsList.Add(new Contact()
            {
                FirstName = "Jim",
                LastName = "Rogers"
            });
            contactsList.Add(new Contact()
            {
                FirstName = "Lucy",
                LastName = "Vincent-Smith"
            });
            contactsList.Add(new Contact()
            {
                FirstName = "Raymond",
                LastName = "Wong"
            });
        }

        public ObservableCollection<Contact> GetContacts() {
            contactsList.Clear();
            GetContactData();
            return contactsList;
        }
    }
}
