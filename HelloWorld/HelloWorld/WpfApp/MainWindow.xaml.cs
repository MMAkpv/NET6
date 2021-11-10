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

        private void btnHello_Click(object sender, RoutedEventArgs e)
        {
            txbInfo.Text = "Ahoj " + txtBox.Text;
        }

        private void txtBox_GotFocus(object sender, RoutedEventArgs e)
        {
            txtBox.Text = string.Empty;
        }

        private void btnPersonDetail_Click(object sender, RoutedEventArgs e)
        {
            Person p = new Person();
            p.FirstName = "Alice";
            p.LastName = "Smith";
            p.DateOfBirth = new DateTime(1981, 8, 11);



            PersonDetail pdWindow = new PersonDetail(p);
            pdWindow.Show();
        }
    }
}
