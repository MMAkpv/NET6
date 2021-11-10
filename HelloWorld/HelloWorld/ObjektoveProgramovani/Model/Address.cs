using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjektoveProgramovani.Model
{
    public class Address
    {
        public Address(string city, string street)
        {
            Street = street;
            City = city;
        }

        public Address()
        {

        }

        public string Street { get; set; }
        public string City { get; set; }

    }
}
