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
using SklepKomputerowy.Pages;

namespace SklepKomputerowy
{
    /// <summary>
    /// Logika dla MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Laduje strone ProductsPage
        /// </summary>
        private void ProductsButton_OnClick(object sender, RoutedEventArgs e)
        {
            MainContentFrame.Navigate(new ProductsPage());
        }

        /// <summary>
        /// Laduje strone HomePage
        /// </summary>
        private void HomeListButton_OnClick(object sender, RoutedEventArgs e)
        {
            MainContentFrame.Navigate(new HomePage());
        }

        /// <summary>
        /// Laduje strone AddProductPage
        /// </summary>
        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            MainContentFrame.Navigate(new AddProductPage());
        }
    }
}
