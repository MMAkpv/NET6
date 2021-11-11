using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjektoveProgramovani.Model
{
    public class Person
    {
        public int Id { get; set; }

        [MaxLength(200)] //omezení jména na určitý počet znaků
        public string FirstName { get; set; } //property, tedy vlastnost
        
        [MaxLength(200)]
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Address HomeAddress { get; set; } //= new Address(); //abych nemusel v každém konstruktoru, jako to mám nyní
        public List<Car> Cars { get; set; } = new List<Car>();

        [NotMapped] //propety CarsCount ignoruj při tvorbě databáze, nedělej z toho sloupeček...
        public int CarsCount { get { return Cars.Count(); } } //vrací pouze počet Cars v listu


        //konstruktory
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            HomeAddress = new Address();
        }

        public Person() //prázdný konstruktor, abych mohl zadávat i původní možností
        { 
            HomeAddress = new Address();
        }

        public Person(string firstName, string lastName, DateTime dateOfBirth) //konstruktor i s datumem narození
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            HomeAddress = new Address();
        }

        //zastiňuji něco z rodiče, konkrétně mětodu ToString, override je proto, že původní zastíním 
        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }


 
        //metody
        public int Age()
        {
            DateTime today = DateTime.Today;
            return (int)(today - DateOfBirth).TotalDays /365;
        }
        
    }
}
