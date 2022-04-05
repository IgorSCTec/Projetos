using CRUD_Console.Models;
using System;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;
using CRUD_Console.Repositories;

namespace CRUD_Console.Operacoes
{
    class Insert
    {
       
        public void CreateUser(SqlConnection connection)
        {
            Console.WriteLine("");
                var cliente = new Cliente();
                Console.WriteLine("Iniciando");
                Console.WriteLine("");
                Console.Write("Digite o nome do cliente: ");
                cliente.Nome = Console.ReadLine();
                Console.WriteLine("");
                Console.Write("Digite o E-mail do cliente: ");
                cliente.Email = Console.ReadLine();
                Console.WriteLine("");
                Console.Write("Digite o Telefone do cliente: ");
                cliente.Phone = Console.ReadLine();
                Console.WriteLine("");
                Console.Write("Digite a Data de Nascimento do cliente: ");
                cliente.Birthdate = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("");
                cliente.CreateDate = DateTime.Now;

                Cliente cliente2 = new Cliente()
                {
                    Nome = cliente.Nome,
                    Email = cliente.Email,
                    Phone = cliente.Phone,
                    Birthdate = cliente.Birthdate,
                    CreateDate = cliente.CreateDate
                };

                var repository = new Repository<Cliente>(connection);

                repository.Create(cliente2);

                Console.WriteLine("Cadastro realizado.");
                Console.WriteLine("");
                var outraOperacao = new OutraOperacao();
                outraOperacao.OutraOperacaoCRUD(connection);
        }
    }
}