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

        //konstruktory
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public Person() //prázdný konstruktor, abych mohl zadávat i původní možností
        { }

        public Person(string firstName, string lastName, DateTime dateOfBirth) //konstruktor i s datumem narození
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
        }

        //zastiňuji něco z rodiče, konkrétně mětodu ToString, override je proto, že původní zastíním 
        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }


 

        public int Age()
        {
            DateTime today = DateTime.Today;
            return (int)(today - DateOfBirth).TotalDays /365;
        }
        
    }
}
