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

            Products = new List<Product>
            {
                new Product
                {
                    Code = "ROC1",
                    Name = "Razer Ornata Chroma",
                    Description = "Piękne podświetlenie RGB, wysoki skok klawiszy idealna gamingowa klawiatura, kabel USB solidny w oplocie. Polecam po ponad roku testów.",
                    Price = 299,
                    WarrantyMonths = 24,
                    ImgUrl = "https://f01.esfr.pl/foto/6/14256563153/ca6518eb7506475bd2b34888e7358a8a/razer-ornata-chroma,14256563153_7.jpg",
                    ExtraParametersDictionary = new Dictionary<string, string>
                    {
                        {"Podswietlana", "tak" },
                        {"Zasilanie", "USB" },
                        {"Rodzaj", "Przewodowa" }

                    }

                },
                new Product
                {
                    Code = "ROC2",
                    Name = "22222222Razer Ornata Chroma2",
                    Description = "2222Piękne podświetlenie RGB, wysoki skok klawiszy idealna gamingowa klawiatura, kabel USB solidny w oplocie. Polecam po ponad roku testów.",
                    Price = 299,
                    WarrantyMonths = 24,
                    ImgUrl = "https://f01.esfr.pl/foto/6/14256563153/7023bf5940d84b19807f50e029adabbb/razer-ornata-chroma,14256563153_3.jpg",
                    ExtraParametersDictionary = new Dictionary<string, string>
                    {
                        {"Podswietlana", "nie" },
                        {"Zasilanie", "bateria" },
                        {"Rodzaj", "na baterie" }

                    }

                },
                new Product
                {
                    Code = "ROC3",
                    Name = "Razer Ornata Chroma",
                    Description = "Piękne podświetlenie RGB, wysoki skok klawiszy idealna gamingowa klawiatura, kabel USB solidny w oplocie. Polecam po ponad roku testów.",
                    Price = 299,
                    WarrantyMonths = 24,
                    ImgUrl = "https://f01.esfr.pl/foto/6/14256563153/ca6518eb7506475bd2b34888e7358a8a/razer-ornata-chroma,14256563153_7.jpg",
                    ExtraParametersDictionary = new Dictionary<string, string>
                    {
                        {"Podswietlana", "tak" },
                        {"Zasilanie", "USB" },
                        {"Rodzaj", "Przewodowa" }

                    }

                },
                new Product
                {
                    Code = "ROC4",
                    Name = "Razer Ornata Chroma",
                    Description = "Piękne podświetlenie RGB, wysoki skok klawiszy idealna gamingowa klawiatura, kabel USB solidny w oplocie. Polecam po ponad roku testów.",
                    Price = 299,
                    WarrantyMonths = 24,
                    ImgUrl = "https://f01.esfr.pl/foto/6/14256563153/ca6518eb7506475bd2b34888e7358a8a/razer-ornata-chroma,14256563153_7.jpg",
                    ExtraParametersDictionary = new Dictionary<string, string>
                    {
                        {"Podswietlana", "tak" },
                        {"Zasilanie", "USB" },
                        {"Rodzaj", "Przewodowa" }

                    }

                },
                new Product
                {
                    Code = "Display1",
                    Name = "Monitor iiyama",
                    Description = "Piękne podświetlenie RGB, wysoki skok klawiszy idealna gamingowa klawiatura, kabel USB solidny w oplocie. Polecam po ponad roku testów.",
                    Price = 799,
                    WarrantyMonths = 12,
                    ImgUrl = "https://image.ceneostatic.pl/data/products/47995171/i-iiyama-24-prolite-xu2492hsu-b1.jpg",
                    ExtraParametersDictionary = new Dictionary<string, string>
                    {
                        {"Podswietlana", "tak" },
                        {"Zasilanie", "USB" },
                        {"Rodzaj", "Przewodowa" }

                    }

                },
            };
            ListViewProducts.ItemsSource = Products;
        }




    }
}
