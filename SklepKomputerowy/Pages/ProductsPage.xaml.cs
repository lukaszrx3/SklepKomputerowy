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
    /// Interaction logic for ProductsPage.xaml
    /// </summary>
    public partial class ProductsPage : Page
    {
        private SklepKomputerowyDbEntities db;
        public List<Product> Products;

        public ProductsPage()
        {
            InitializeComponent();
            db = new SklepKomputerowyDbEntities();
            Products = new List<Product>();

            foreach (var product in db.Produkty)
            {
                Product p = new Product
                {
                    Code = product.Kod,
                    Description = product.Opis,
                    Name = product.Nazwa,
                    ImgUrl = product.AdresObrazka,
                    Price = product.Cena,
                    WarrantyMonths = 24
                };
                Products.Add(p);
            }
            
            ListViewProducts.ItemsSource = Products;
        }

        private void SearchButton_OnClick(object sender, RoutedEventArgs e)
        {
            ListViewProducts.ItemsSource = Products.Where(x => x.Name.Contains(NameTextBox.Text));
        }


    }
}
