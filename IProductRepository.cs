using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestBuyBestPartices
{
    internal interface IProductRepository
    {


        // creating Method GetAllProducts
        public IEnumerable<Product> GetAllProducts();
        //{
        //    //return _conn.Query<Product>("SELECT * FROM Product");
        //}

        //// creating Method InsertDepartments
        //public void CreateProduct(string name, double price, int categoryID)
        //{
            
        //}

    }
}
