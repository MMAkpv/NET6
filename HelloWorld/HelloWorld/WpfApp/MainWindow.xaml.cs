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


            
            PersonDetail pdWindow = new PersonDetail(p);
            pdWindow.Show(); //pdWindow.ShowDialog() //otevření jako dialogové okno, nepůjde jich otevřít víc a dokud ho neukončím, nemůžu se vrátit
        }

        private void wMain_Loaded(object sender, RoutedEventArgs e)
        {
            var dir = @"C:\Users\PC\source\repos\CNET1\HelloWorld\HelloWorld\ObjektoveProgramovani\Data\";
            var filePath = System.IO.Path.Combine(dir, "people.txt");
            var people = PersonData.LoadPeople(filePath);

            //aby se mi zobrazila dobře adresa, která je objektem, tak jsem udělal override ToString na adrese :)

            grdPeople.ItemsSource = people;

        }
    }
}
