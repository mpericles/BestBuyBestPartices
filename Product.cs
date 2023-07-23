using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestBuyBestPartices
{
    //Create a public Product Class - this class will contain public properties that represent each column in the Products table.
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int CategoryID { get; set; }
        public int StockLevel { get; set; }
        public bool OnSale { get; set; }
    }
}
