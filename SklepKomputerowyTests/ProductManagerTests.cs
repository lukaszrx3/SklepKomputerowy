using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SklepKomputerowy;
using SklepKomputerowy.Managers;

namespace SklepKomputerowyTests
{
    [TestClass]
    public class ProductManagerTests
    {
        [TestMethod]
        public void CheckIfProductCanBeAdded_FilledProduct_ReturnsTrue()
        {
            Produkty testowyProdukt = new Produkty();
            testowyProdukt.Cena = 200;
            testowyProdukt.Nazwa = "Mysz";
            testowyProdukt.Opis = "Mysz komputerowa";
            bool result = ProductManager.CheckIfProductCanBeAdded(testowyProdukt);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CheckIfProductCanBeAdded_EmptyProduct_ReturnsFalse()
        {
            Produkty testowyProdukt = new Produkty();
            bool result = ProductManager.CheckIfProductCanBeAdded(testowyProdukt);
            Assert.IsFalse(result);
        }
    }
}
