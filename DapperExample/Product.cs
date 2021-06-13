using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryPattern
{
    public class Product
    {
        public string ProductId { get; set; }

        public string ProductName { get; set; }

        public decimal Price { get; set; }

        public string Barcode { get; set; }

        public int UnitInStock { get; set; }
    }
}