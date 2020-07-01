using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SklepKomputerowy.ViewModels
{
    public class Product
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int WarrantyMonths { get; set; }
        public decimal Price { get; set; }
        public string ImgUrl { get; set; }
    }
}

