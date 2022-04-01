using CRUD_Console.Models;
using Dapper;
using Microsoft.Data.SqlClient;
using System;

namespace CRUD_Console.Operacoes
{
    class Select
    {
        const string connectionString = "Server=localhost,1433;Database=TesteCadastro;User ID=sa;Password=Teste@123;Trusted_Connection=False; TrustServerCertificate=True;";
        public void ReadUser()
        {
            Console.WriteLine("");
            Console.Write("Digite o nome que deseja consultar: ");
            var nome = Console.ReadLine();
            Console.WriteLine("");

            using (var connection = new SqlConnection(connectionString))
            {
                var sql = $"SELECT [Id],[Nome],[Email],[Phone],[Birthdate],[CreateDate] FROM [Cliente] WHERE [Nome] LIKE @teste";

                var cliente = connection.Query<Cliente>(sql, new { teste = $"%{nome}%" });

                foreach(var item in cliente)
                {
                    Console.WriteLine($"Id: {item.Id} - Nome: {item.Nome} - E-mail: {item.Email} - Telefone: {item.Phone} - Data de Nascimento: {item.Birthdate} - Data de Cadastro: {item.CreateDate}");
                }
            }

            Console.WriteLine("");
            var outraOperacao = new OutraOperacao();
            outraOperacao.OutraOperacaoCRUD();
        }
    }
}
