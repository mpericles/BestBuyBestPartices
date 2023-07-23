using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestBuyBestPartices
{
    internal class DapperProductRepository : IProductRepository
    {
        //We are connected to the Database here
        private readonly IDbConnection _conn;

        public DapperProductRepository(IDbConnection conn)
        {
            _conn = conn;
        }
        // creating Method GetAllProducts
        public IEnumerable<Product> GetAllProducts()
        {
            //here we are querying the database
            return _conn.Query<Product>("SELECT * FROM products");
        }

        // creating Method InsertDepartments
       // public void InsertProducts(string name)
       // {
        //    _conn.Execute("INSERT INTO departments (Name) VALUES (@name)", new { name = name });
        //}
    }
}
