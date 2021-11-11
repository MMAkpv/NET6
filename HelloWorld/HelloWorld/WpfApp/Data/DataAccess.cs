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
                var peopleList = db.People.ToList(); //načtu do list peoplelist tabulku People

                people = new ObservableCollection<Person>(peopleList); // načtený list uložim do observableColl people
            }
        }
    }
}
