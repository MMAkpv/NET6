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

            Car skoda = new Car();

            skoda.Color = "Red";
            skoda.PlateNumber = "XX 1234";
            skoda.TotalKm = 60_000.5;

            skoda.AddTripKm(47);

            Console.WriteLine($"Mám auto barvy {skoda.Color}, značka {skoda.PlateNumber}, se {skoda.TotalKm} kilometry.");

            skoda.ResetTotalKm();

            Console.WriteLine($"Mám auto barvy {skoda.Color}, značka {skoda.PlateNumber}, se {skoda.TotalKm} kilometry.");

            Console.ReadLine();
        }
    }
}
