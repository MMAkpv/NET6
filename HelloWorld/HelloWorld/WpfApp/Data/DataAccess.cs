using Microsoft.EntityFrameworkCore;
using ObjektoveProgramovani.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp.Data
{
    class DataAccess
    {
        public static ObservableCollection<Person> people = new ObservableCollection<Person>(); //field

        public static void LoadPeopleFromDb()
        {
            using(var db = new PeopleContext())
            {
                var peopleList = db.People
                    .Include(x => x.HomeAddress)
                    .Include(x => x.Cars)
                    .ToList(); //načtu do list peoplelist tabulku People, include říká, aby se vzali i data z odkazovaných tabulek...

                people = new ObservableCollection<Person>(peopleList); // načtený list uložim do observableColl people
            }
        }

        public static void SavePerson(Person personToSave)
        {
            using(var db = new PeopleContext())
            {
                var dbperson = db.People.Find(personToSave.Id); //zjistím si ID té osoby, kterou měním v db

                dbperson.FirstName = personToSave.FirstName;
                dbperson.LastName = personToSave.LastName;

                db.SaveChanges();
            }
        }

        public static void AddPerson(Person person)
        {
            using (var db = new PeopleContext())
            {
                db.People.Add(person); //přidám novou osobu...

                db.SaveChanges();
            }
        }
    }
}
