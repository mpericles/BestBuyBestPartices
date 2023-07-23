using BestBuyBestPartices;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System.Data;

//Here we are creting our connection to the Database 
var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

string connString = config.GetConnectionString("DefaultConnection");

IDbConnection conn = new MySqlConnection(connString);

#region Department Section
//now we are going to call the methods we created
//we are creating an instance.
//WeakReference are instantiating the method
var departmentRepo = new DapperDepartmentRepository(conn);

//now we are going to insert a record into the database just to try
departmentRepo.InsertDepartments("Myriam's New Department");

var departments = departmentRepo.GetAllDepartments();

Console.WriteLine(" Listing all the records in the database");
foreach (var department in departments)
{
    Console.WriteLine(department.Name);
    Console.WriteLine(department.DepartmentID);
    Console.WriteLine();
    Console.WriteLine();

}
#endregion

//now we are going to call the methods we created
//we are creating an instance.
//WeakReference are instantiating the method
var productRepo = new DapperProductRepository(conn);

////now we are going to insert a record into the database just to try
//productRepo.InsertDepartments("Myriam's New Department");

var products = productRepo.GetAllProducts();

Console.WriteLine(" Listing all the Products in the database");
Console.WriteLine("ProductID  || Product Name || Product Price} || CategoryID || OnSale");
foreach (var product in products)
{
    Console.WriteLine($"{product.ProductID} || {product.Name} || {product.Price} || {product.CategoryID} || {product.OnSale}");
    //Console.WriteLine($"Here is the product info: {product.ProductID} || {product.Name} || {product.Price} || {product.CategoryID} || {product.OnSale}");
    //Console.WriteLine(product.Name);
    //Console.WriteLine(product.ProductID);
    //Console.WriteLine();
    //Console.WriteLine();

}
