using ObjektoveProgramovani.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjektoveProgramovani.Data
{
    public class PersonData
    {
        public const string personDataFile = "people.txt"; //field, podobné property, ale dělat jen pro třídu, tedy to co neposkytuju ven... fieldy tedy jen pro moje např. výpočty. Mohl by to být i klidně property. Je statická, bude se to týkat všech instancí. Const - konstanta, aby nikdo nezmněnil.

        //metoda pro uložení (připojení - appending) jedné osoby do souboru
        public static void SavePerson(Person person)
        {
            string line = $"{person.FirstName};{person.LastName};{person.DateOfBirth};{person.HomeAddress.City};{person.HomeAddress.Street}";
            line += Environment.NewLine;

            File.AppendAllText(personDataFile, line);
        }

        public static List<Person> LoadPeople(string file = "people.txt")
        {
            List<Person> people = new List<Person>();

            var lines = File.ReadAllLines(file);

            foreach (var line in lines)
            {
                var items = line.Split(";");
                
                Person p = new Person();

                p.FirstName = items[0];
                p.LastName = items[1];
                p.DateOfBirth = DateTime.Parse(items[2]);
                p.HomeAddress.City = items[3];
                p.HomeAddress.Street = items[4];

                people.Add(p);
            }

            return people;        }
    }
}
