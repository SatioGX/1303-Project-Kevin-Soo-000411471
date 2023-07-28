using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1303_Project
{
    public class Company : Contact
    {
        public List<Individual> Contacts { get; set; }
    }
}
