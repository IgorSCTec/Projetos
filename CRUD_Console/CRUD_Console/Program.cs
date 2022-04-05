using CRUD_Console.Models;
using CRUD_Console.Repositories;
using Dapper;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;
using System;

namespace CRUD_Console
{
    class Program
    {
        const string connectionString = "Server=localhost,1433;Database=TesteCadastro;User ID=sa;Password=Teste@123;Trusted_Connection=False; TrustServerCertificate=True;";
        static void Main(string[] args)
        {
            var connection = new SqlConnection(connectionString);
            connection.Open();
            var menu = new Menu();
            menu.MenuCRUD(connection);
            connection.Close();
            Console.ReadKey();
        }
    }
}
