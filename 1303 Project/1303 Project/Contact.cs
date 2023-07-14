using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace _1303_Project
{
    public abstract class Contact
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public List<PhoneNumber> PhoneNumbers { get; set; }
        public List<EmailAddress> EmailAddresses { get; set; }

        public Contact()
        {
            PhoneNumbers = new List<PhoneNumber>();
            EmailAddresses = new List<EmailAddress>();
        }
    }
}
