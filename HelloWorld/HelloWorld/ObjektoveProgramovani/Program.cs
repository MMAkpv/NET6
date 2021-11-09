using ObjektoveProgramovani.Model;
using System;

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

            Car myCar = new Car("stříbrná", "XX 666", 28754);
            Console.WriteLine(myCar);

            Console.ReadLine();
        }
    }
}
