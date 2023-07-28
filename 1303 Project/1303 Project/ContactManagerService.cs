using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1303_Project
{
    public class ContactManagerService
    {
        private InterfaceStorage<Contact> contactStorage;

        public ContactManagerService(InterfaceStorage<Contact> storage)
        {
            contactStorage = storage;
        }

    }

    public class ContactManagerDataService
    {
        private InterfaceStorage<Contact> contactStorage;

        public ContactManagerDataService(InterfaceStorage<Contact> storage)
        {
            contactStorage = storage;
        }

    }

}
