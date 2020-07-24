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
    /// Logika dla ProductsPage.xaml
    /// </summary>
    public partial class ProductsPage : Page
    {
        /// <summary>
        /// Obiekt polaczenia z baza danych
        /// </summary>
        private SklepKomputerowyDbEntities db;

        /// <summary>
        /// Lista produktow, uzupelnia sie podczas inicjalizacji widoku
        /// </summary>
        public List<Product> Products;

        /// <summary>
        /// Cena od sluzaca do filtrowania
        /// </summary>
        private decimal priceFrom = 0;


        /// <summary>
        /// Cena do sluzaca do filtrowania
        /// </summary>
        private decimal priceTo = decimal.MaxValue;

        /// <summary>
        /// Konstruktor strony Produktow, z bazy danych pobiera dostepne produkty
        /// </summary>
        public ProductsPage()
        {
            InitializeComponent();
            db = new SklepKomputerowyDbEntities();
            Products = new List<Product>();
            
            // Uzupelnianie listy produktow z bazy danych
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

        /// <summary>
        /// Event obslugujacy przycisk sluzacy do szukania
        /// </summary>
        private void SearchButton_OnClick(object sender, RoutedEventArgs e)
        {
            decimal.TryParse(PriceFromTextBox.Text, out priceFrom);
            string productNameContains = NameTextBox.Text;
            string productCodeContains = CodeTextBox.Text;

            if(!decimal.TryParse(PriceToTextBox.Text, out priceTo))
                priceTo = Decimal.MaxValue;

            // Filtrowanie
            IEnumerable<Product> productsFiltered;
            
            productsFiltered = Products.Where(x => x.Price > priceFrom && x.Price < priceTo);

            // Jesli productName zostal podany przez usera to zawez filtrowanie
            if (!string.IsNullOrEmpty(productNameContains))
                productsFiltered = productsFiltered.Where(x => x.Name.Contains(productNameContains));
            // Jesli productCode zostal podany przez usera to zawez filtrowanie
            if (!string.IsNullOrEmpty(productCodeContains))
                productsFiltered = productsFiltered.Where(x => x.Name.Contains(productNameContains));

            ListViewProducts.ItemsSource = productsFiltered;
        }


    }
}
