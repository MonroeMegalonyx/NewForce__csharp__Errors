using System;
using System.Collections.Generic;

namespace csharp_errors
{
    public class AddressBook
    {
        /*
          Dictionary with email as the 'string' Key and contact as the 'Contact' Value
        */
        private Dictionary<string, Contact> _contactList {get; set;} = new Dictionary<string, Contact>();
        
        /*
          Methods
        */
        public void AddContact(Contact fooContact)
        {
            _contactList.Add(fooContact.Email, fooContact);
        }

        public Contact GetByEmail(string fooEmail)
        {
            return _contactList[$"{fooEmail}"];
        }
    }
}