using ObjektoveProgramovani.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfApp.Data;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for PersonDetail.xaml
    /// </summary>
    public partial class PersonDetail : Window
    {

        Person person; //field
        MainWindow mainWindow;
        bool isNewPerson = false;

        public PersonDetail(Person _person, MainWindow _mainWindow, bool _isNewPerson) //konstruktor, doplním osobu, _person je parametr, mainwindow předávám abych mohl aktualizovat grid
        {
            InitializeComponent();

            mainWindow = _mainWindow;
            isNewPerson = _isNewPerson;
            person = _person;

            if (isNewPerson)
            {
                person = new Person();
            }
            else
            {
                person = _person;
            }

            txtFirstName.Text = person.FirstName;
            txtLastName.Text = person.LastName;
            txtDateOfBirth.Text = person.DateOfBirth.ToShortDateString();
        }

        private void btnUloz_Click(object sender, RoutedEventArgs e) //uložení osoby, která je načtená při inicializaci okna konstruktorem PersonDetail a udržovaná ve field person
        {
            person.FirstName = txtFirstName.Text;
            person.LastName = txtLastName.Text;


            if (isNewPerson)
            {
                DataAccess.AddPerson(person); //uložim do db novou osobu
            }
            else
            {
                DataAccess.SavePerson(person); //uložim do db upravenou osobu
            }
        
           

            Data.DataAccess.LoadPeopleFromDb(); //načtu nově databazi, resp. tabulky
            mainWindow.grdPeople.ItemsSource = DataAccess.people; //aktualizuju grid nově načtenými daty

            Close(); //zavření okna
        }
    }
}
