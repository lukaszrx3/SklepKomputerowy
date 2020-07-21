using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SklepKomputerowy.ViewModels
{
    /// <summary>
    /// View model dla produktu, zawiera podstawowe pola d
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Pole nazwy produktu
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Kod produktu uzywany potem do filtrowania
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Opis produktu zawierajacy dodatkowe informacje ktore chce podac sprzedawca
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Dlugosc Gwarancji - Zwykle 24 miesiace
        /// </summary>
        public int WarrantyMonths { get; set; }

        /// <summary>
        /// Cena produktu - uzywana do filtrowania
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Adres URL obrazka, w bazie danych aby jej nie przepelniac obrazki trzymane sa w postaci linkow
        /// </summary>
        public string ImgUrl { get; set; }
    }
}

