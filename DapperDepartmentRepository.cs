using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZstdSharp.Unsafe;

namespace BestBuyBestPartices
{
    public class DapperDepartmentRepository : IDepartmentRepository
    {
        //We are connected to the Database here
        private readonly IDbConnection _conn;

        public DapperDepartmentRepository(IDbConnection conn)
        {
            _conn = conn;
        }
        // creating Method GetAllDepartments
        public IEnumerable<Department> GetAllDepartments()
        {
            return _conn.Query<Department>("SELECT * FROM departments");
        }

        // creating Method InsertDepartments
        public void InsertDepartments(string name)
        {
            _conn.Execute("INSERT INTO departments (Name) VALUES (@name)", new {name = name });
        }
    }
}
