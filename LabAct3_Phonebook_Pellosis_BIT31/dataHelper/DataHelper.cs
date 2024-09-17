using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace dataHelper
{ 
    public class DataHelper
    {
        public class Contact
        {
            public string PhoneNumber { get; set;  }
            public string Name { get; set;  }

            public Contact(string phoneNumber, string name)
            {
                PhoneNumber = phoneNumber;
                Name = name;
            }
        }

        public class Phonebook
        {
            public ArrayList phonebook = new ArrayList();

            // add a contact
            public bool AddContact(string phoneNumber, string name)
            {
                foreach (Contact contact in phonebook)
                {
                    if (contact.PhoneNumber == phoneNumber)
                    {
                        return false;
                    }
                }

                phonebook.Add(new Contact(phoneNumber, name));
                return true;
            }

            public Contact searchPhoneNum(string phoneNumber)
            {
                foreach (Contact contact in phonebook)
                {
                    if (contact.PhoneNumber == phoneNumber)
                    {
                        return contact;
                    }
                }
                return null;
            }

            public Contact searchName(string name)
            {
                foreach (Contact contact in phonebook)
                {
                    if (contact.Name.Trim().Equals(name.Trim(), StringComparison.OrdinalIgnoreCase))
                    {
                        return contact;
                    }
                }
                return null;
            }

            public ArrayList GetAllContacts()
            {
                return phonebook;
            }

            public bool EditContact(string phoneNumber,string newName)
            {
                Contact contact = searchPhoneNum(phoneNumber);
                if (contact != null)
                {
                    contact.Name = newName;
                    return true;
                }
                return false;   
            }

            public bool DeleteContact(string phoneNumber)
            {
                Contact contact = searchPhoneNum(phoneNumber);
                if (contact != null)
                {
                    phonebook.Remove(contact);
                    return true;
                }
                return false;
            }
        }
    }
}
