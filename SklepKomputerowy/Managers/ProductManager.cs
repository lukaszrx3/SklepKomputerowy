using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SklepKomputerowy.Managers
{
    /// <summary>
    /// Statyczna klasa wspomagajaca - 
    /// </summary>
    public static class ProductManager
    {
        /// <summary>
        /// Sprawdzanie czy Produkt nie ma pustych pol ktore sa wymagane
        /// Nazwy, Opisu i Ceny
        /// </summary>
        public static bool CheckIfProductCanBeAdded(Produkty p)
        {
            if (string.IsNullOrEmpty(p.Nazwa))
                return false;
            if (p.Cena == 0)
                return false;
            if (string.IsNullOrEmpty(p.Opis))
                return false;

            return true;
        }
    }
}
