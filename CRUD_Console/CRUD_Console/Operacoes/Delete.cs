using CRUD_Console.Models;
using CRUD_Console.Repositories;
using Dapper;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;
using System;

namespace CRUD_Console.Operacoes
{
    class Delete
    {
        
        public void DeleteUser(SqlConnection connection)
        {
                Console.WriteLine("");

                Console.WriteLine("Clientes Cadastrados");
                Console.WriteLine("");

                var repository = new Repository<Cliente>(connection);
                var clientes = repository.ReadAll();

                foreach (var item in clientes)
                {
                    Console.WriteLine($"Id: {item.Id} - Nome: {item.Nome} - E-mail: {item.Email} - Telefone: {item.Phone} - Data de Nascimento: {item.Birthdate} - Data de Cadastro: {item.CreateDate}");
                    Console.WriteLine("");
                }

                Console.Write("Digite o nome do cliente que deseja Deletar: ");
                var nome = Console.ReadLine();
                Console.WriteLine("");

                var sql = $"DELETE FROM [Cliente] WHERE [Nome] LIKE @teste";

                var repository2 = new Repository<Cliente>(connection);
                var users = repository.Read(sql, nome);

                Console.WriteLine("Excluido com sucesso.");
                Console.WriteLine("");
                var outraOperacao = new OutraOperacao();
                outraOperacao.OutraOperacaoCRUD(connection);
        }
    }
}
