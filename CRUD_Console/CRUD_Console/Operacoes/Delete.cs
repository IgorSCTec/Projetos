using CRUD_Console.Models;
using Dapper;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;
using System;

namespace CRUD_Console.Operacoes
{
    class Delete
    {
        const string connectionString = "Server=localhost,1433;Database=TesteCadastro;User ID=sa;Password=Teste@123;Trusted_Connection=False; TrustServerCertificate=True;";
        public void Deletar()
        {
            Console.WriteLine("");
            using (var connection = new SqlConnection(connectionString))
            {
                Console.WriteLine("Clientes Cadastrados");
                Console.WriteLine("");

                var clientes = connection.GetAll<Cliente>();

                foreach (var item in clientes)
                {
                    Console.WriteLine($"Id: {item.Id} - Nome: {item.Nome} - E-mail: {item.Email} - Telefone: {item.Phone} - Data de Nascimento: {item.Birthdate} - Data de Cadastro: {item.CreateDate}");
                    Console.WriteLine("");
                }

                Console.Write("Digite o nome do cliente que deseja Deletar: ");
                var nomeCliente = Console.ReadLine();
                Console.WriteLine("");

                var sql = $"DELETE FROM [Cliente] WHERE [Nome] LIKE @teste";

                var cliente = connection.Query<Cliente>(sql, new { teste = $"%{nomeCliente}%" });

                Console.WriteLine("Excluido com sucesso.");
                Console.WriteLine("");
                var outraOperacao = new OutraOperacao();
                outraOperacao.OutraOperacaoCRUD();
            }
        }
    }
}
