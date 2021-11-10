using ObjektoveProgramovani.Data;
using ObjektoveProgramovani.Model;
using System;
using System.Collections.Generic;

namespace ObjektoveProgramovani
{
    class Program
    {
        static void Main(string[] args)
        {

            //využití třídy Person
            #region Reseni
            /*
            Person p1 = new Person();

            p1.FirstName = "John";
            p1.LastName = "Doe";
            p1.DateOfBirth = new DateTime(1964, 8, 5); //DateTime.Parse("9.1.1986");



            Person p2 = new Person();
            p2.FirstName = "Mirek";
            p2.LastName = "Malaga";
            p2.DateOfBirth = new DateTime(1986, 1, 9);

            Console.WriteLine($"{p1.FirstName} {p1.LastName}, narozený {p1.DateOfBirth.ToShortDateString()}");

            Console.WriteLine(p1.Age() > p2.Age() ? p1.FirstName : p2.FirstName); //vypíšu nejstarší osobu
            */
            #endregion

            //využití třídy Car
            #region Reseni
            /*
            Car skoda = new Car();

            skoda.Color = "Red";
            skoda.PlateNumber = "XX 1234";
            skoda.TotalKm = 60_000.5;

            skoda.AddTripKm(47);

            Console.WriteLine($"Mám auto barvy {skoda.Color}, značka {skoda.PlateNumber}, se {skoda.TotalKm} kilometry.");

            skoda.ResetTotalKm();

            Console.WriteLine($"Mám auto barvy {skoda.Color}, značka {skoda.PlateNumber}, se {skoda.TotalKm} kilometry.");
            */
            #endregion

            //využití třídy Inovice
            #region Reseni
            /*
            Invoice invoice = new Invoice();

            invoice.ItemInvoice = "šroub";
            invoice.Customer = "Společnost s. r. o.";
            invoice.Price = 9999;

            Console.WriteLine($"dodán {invoice.ItemInvoice} firmě {invoice.Payer} za {invoice.Price}");
            */
            #endregion

            //využití třídy Person s konstruktorem
            #region Reseni
            /*
            Person p = new Person("Zdeněk", "Ulrych");

            Console.WriteLine($"{p.FirstName} {p.LastName}");

            Person pp = new Person("Mirek", "Malaga", new DateTime(1986, 1, 9));
            Console.WriteLine($"{pp.FirstName} {pp.LastName}, narozený {pp.DateOfBirth.ToShortDateString()}");

            Console.WriteLine(pp); //využívám přetížení na ToString
            */
            #endregion

            //využití třídy Car s konstruktorem
            #region Reseni

            //Car myCar = new Car("stříbrná", "XX 666", 28754);
            //Console.WriteLine(myCar);

            //var MyCar2 = new Car("modrá", "XY 123", 12548);
            //Console.WriteLine(MyCar2);

            #endregion

            //využití třídy Person s další třídou Address
            #region Reseni
            /*
            var p = new Person("Mirek", "Malaga", new DateTime(1986, 9, 1));
            Console.WriteLine(p);

            //p.HomeAddress = new Address("Plzeň", "Tachovská"); //musím "inicializovat" objekt adresy pro proměnnou p.
            p.HomeAddress = new Address( "Plzeň", "Tachovská");
            //p.HomeAddress.City = "Plzeň";
            //p.HomeAddress.Street = "Tachovská";

            Console.WriteLine($"{p.HomeAddress.Street}, {p.HomeAddress.City}");
            */
            #endregion

            //uložení objektů do souboru, oddělovat středníkem, soubor firstname;lastname;dob;city;street
            #region Reseni
            /*
            var p = new Person("Petr", "Hořejší", new DateTime(1982, 8, 4));
            p.HomeAddress.City = "Plzeň";
            p.HomeAddress.Street = "Lidice";

            //abych měl 10 záznamů pro načítání
            for (int i = 0; i < 10; i++)
            {
                PersonData.SavePerson(p);
            }
            */
            #endregion

            //načtení dat do kolekce - těch z předchozího cvičení

            /*
            var people = PersonData.LoadPeople();

            Console.WriteLine($"načteno {people.Count} lidí");

            //vypsání pouze křestních jmen, uděláno složitě abych si něco zkusil... jinak by šlo použít join nad kolekcí naplněné jmény...
            foreach (var item in people)
            {
                Console.Write($"{item.FirstName}{((people.IndexOf(item) == (people.Count -1)) ? (null) : ", ")}");
            }
            */

            // úkol - třída Point2D, po zadání x,y spočte plochu od [0,0], nestaticky s pěknou textovou reprezentací

            Point2D bod1 = new Point2D(10, 5);
            Point2D bod2 = new Point2D(3, 6);
            Console.WriteLine(bod1);
            Console.WriteLine(bod2);


            Console.ReadLine();
        }
    }
}
