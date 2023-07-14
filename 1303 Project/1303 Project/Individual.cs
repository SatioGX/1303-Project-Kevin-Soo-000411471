using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1303_Project
{
    public class Individual : Contact
    {
        public Company Company { get; set; }
    }

    // Model for a phone number
    public class PhoneNumber
    {
        public string Number { get; set; }
        public string Title { get; set; }
    }

    // Model for an email address
    public class EmailAddress
    {
        public string Address { get; set; }
        public string Title { get; set; }
    }
}
