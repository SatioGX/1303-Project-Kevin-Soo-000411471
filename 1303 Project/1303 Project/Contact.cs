using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _1303_Project
{
    public class Contact
    {
        public string Name { get; set; }
        public Address Address { get; set; }
        public List<Phone> Phones { get; set; }
        public List<Email> Emails { get; set; }
    }
}
