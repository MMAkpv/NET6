using ObjektoveProgramovani.Data;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp.Data;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        

        private void btnPersonDetail_Click(object sender, RoutedEventArgs e)
        {
            //pokročili jsme dál, schoval jsem...
            //Person p = new Person();
            //p.FirstName = "Alice";
            //p.LastName = "Smith";
            //p.DateOfBirth = new DateTime(1981, 8, 11);

            Person p = (Person)grdPeople.SelectedItem; //musel jsem to přetypovat na person, aby vědělo co to je za objekt, načtu označený řádek z gridu


            
            PersonDetail pdWindow = new PersonDetail(p, this, false); //this je že posílám toto okno, resp. odkaz na něj
            pdWindow.Show(); //pdWindow.ShowDialog() //otevření jako dialogové okno, nepůjde jich otevřít víc a dokud ho neukončím, nemůžu se vrátit
        }

        //metoda na jedno použití, aby se db naplnila daty z toho našeho původního texťáku
        private void LoadInitialDataset()
        {
            using (var db = new PeopleContext())
            {
                var dir = @"C:\Users\PC\source\repos\CNET1\HelloWorld\HelloWorld\ObjektoveProgramovani\Data\";
                var filePath = System.IO.Path.Combine(dir, "people.txt");
                var people = PersonData.LoadPeople(filePath);

                db.People.AddRange(people); //přidáno do db kontextu, tedy paměti počítač
                db.SaveChanges(); //uložení do DB



            }
        }

        private void wMain_Loaded(object sender, RoutedEventArgs e)
        {
            //LoadInitialDataset(); //volal jsem ji jen jednou pro naplnění db
            //var dir = @"C:\Users\PC\source\repos\CNET1\HelloWorld\HelloWorld\ObjektoveProgramovani\Data\";
            //var filePath = System.IO.Path.Combine(dir, "people.txt");
            //var people = PersonData.LoadPeople(filePath);

            DataAccess.LoadPeopleFromDb();
            grdPeople.ItemsSource = DataAccess.people;


            //aby se mi zobrazila dobře adresa, která je objektem, tak jsem udělal override ToString na třídě adresa :)

            //grdPeople.ItemsSource = people;

        }

        private void grdPeople_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            btnPersonDetail.IsEnabled = true;
        }

        private void btnAddNewPerson_Click(object sender, RoutedEventArgs e)
        {
            PersonDetail pdWindow = new PersonDetail(null, this, true); //this je že posílám toto okno, resp. odkaz na něj
            pdWindow.Show();
        }

        private void txtInput_KeyUp(object sender, KeyEventArgs e)
        {
            var search = txtInput.Text.ToLower();

            if (!string.IsNullOrEmpty(search))
            {
                grdPeople.ItemsSource = DataAccess.people.Where(x => x.FirstName.ToLower().Contains(search) || x.LastName.ToLower().Contains(search));
            }
            else
            {
                grdPeople.ItemsSource = DataAccess.people;
            }
        }

        private void btnCancelSearch_Click(object sender, RoutedEventArgs e)
        {
            txtInput.Text = string.Empty;
            grdPeople.ItemsSource = DataAccess.people;
        }

        private void txtInput_GotFocus(object sender, RoutedEventArgs e)
        {
            txtInput.Text = string.Empty;
        }

        private void grdPeople_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            if (e.PropertyName == "Cars")
            {
                e.Cancel = true;
            }
        }
    }
}
