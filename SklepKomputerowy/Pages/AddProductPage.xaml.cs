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
using SklepKomputerowy.ViewModels;

namespace SklepKomputerowy.Pages
{
    /// <summary>
    /// Interaction logic for AddProductPage.xaml
    /// </summary>
    public partial class AddProductPage : Page
    {
        private SklepKomputerowyDbEntities db;

        public AddProductPage()
        {
            InitializeComponent();
            db = new SklepKomputerowyDbEntities();
        }

        private void AddProductButton_OnClick(object sender, RoutedEventArgs e)
        {

            Produkty p = new Produkty
            {
                Kod = "asd",
                AdresObrazka = UrlTextBox.Text,
                Opis = DescTextBox.Text,
                Cena = Convert.ToDecimal(PriceTextBox.Text),
                Nazwa = NameTextBox.Text
            };

            db.Produkty.Add(p);
            db.SaveChanges();
        }
    }
}
