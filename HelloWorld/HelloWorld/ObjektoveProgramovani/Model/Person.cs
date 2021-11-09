using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjektoveProgramovani.Model
{
    class Person
    {
        public string FirstName { get; set; } //property, tedy vlastnost
        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public int Age()
        {
            DateTime today = DateTime.Today;
            return (int)(today - DateOfBirth).TotalDays /365;
        }
        
    }
}
