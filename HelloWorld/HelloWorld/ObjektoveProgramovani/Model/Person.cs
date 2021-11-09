﻿using System;
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
        public Address HomeAddress { get; set; } //= new Address(); //abych nemusel v každém konstruktoru, jako to mám nyní



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
