using CRUD_Console.Models;
using Dapper;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;
using System;

namespace CRUD_Console.Operacoes
{
    class Update
    {
        const string connectionString = "Server=localhost,1433;Database=TesteCadastro;User ID=sa;Password=Teste@123;Trusted_Connection=False; TrustServerCertificate=True;";
        public void Atualizar()
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

                Console.Write("Digite o nome do cliente que deseja Atualizar: ");
                var nomeCliente = Console.ReadLine();
                Console.WriteLine("");

                Console.Clear();

                var sql = $"SELECT [Id],[Nome],[Email],[Phone],[Birthdate],[CreateDate] FROM [Cliente] WHERE [Nome] LIKE @teste";

                var cliente = connection.Query<Cliente>(sql, new { teste = $"%{nomeCliente}%" });


                foreach (var item in cliente)
                {
                    Console.WriteLine($"Id: {item.Id} - Nome: {item.Nome} - E-mail: {item.Email} - Telefone: {item.Phone} - Data de Nascimento: {item.Birthdate} - Data de Cadastro: {item.CreateDate}");
                    Console.WriteLine("");
                }

                Console.WriteLine("O que deseja atualizar?");
                Console.WriteLine("");
                Console.WriteLine("1 - Nome\n2 - E-mail\n3 - Telefone\n4 - Data de Nascimento");
                Console.WriteLine("");
                Console.Write("Digite a opção: ");
                int opcao = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                

                
                switch (opcao)
                {
                    case 1: AlterarNome(nomeCliente); break;

                    case 2: AlterarEmail(nomeCliente);  break;

                    case 3:  AlterarPhone(nomeCliente); break;

                    case 4:  AlterarBirthdate(nomeCliente); break;

                    default:
                        Console.WriteLine("");
                        Console.Write("Essa não é uma opção válida. Por gentileza selecionar a operação que deseja.");

                        Atualizar();  break;

                }
            }
        }

        public void AlterarNome(string antigoNome)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                Console.Write("Digite o novo Nome: ");
                var novoNome = Console.ReadLine();
                Console.WriteLine("");
                var update = $"UPDATE[Cliente] SET [Nome] = @novoNome WHERE [Nome] Like @antigoNome";
                var rows = connection.Execute(update, new { novoNome = $"{novoNome}", antigoNome = $"%{antigoNome}%" });
                Console.WriteLine("Cadastro Alterado com sucesso.");
                Console.WriteLine("");
                var outraOperacao = new OutraOperacao();
                outraOperacao.OutraOperacaoCRUD();
            }
        }

        public void AlterarEmail(string clienteNome)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                Console.Write("Digite o novo E-mail: ");
                var novoEmail = Console.ReadLine();
                Console.WriteLine("");
                var update = $"UPDATE[Cliente] SET [Email] = @novoNome WHERE [Nome] Like @antigoNome";
                connection.Execute(update, new { novoNome = $"{novoEmail}", antigoNome = $"%{clienteNome}%" });
                Console.WriteLine("Cadastro Alterado com sucesso.");
                Console.WriteLine("");
                var outraOperacao = new OutraOperacao();
                outraOperacao.OutraOperacaoCRUD();
            };
        }

        public void AlterarPhone(string clienteNome)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                Console.Write("Digite o novo Telefone: ");
                var novoPhone = Console.ReadLine();
                Console.WriteLine("");
                var update = $"UPDATE[Cliente] SET [Phone] = @novoNome WHERE [Nome] Like @antigoNome";
                connection.Execute(update, new { novoNome = $"{novoPhone}", antigoNome = $"%{clienteNome}%" });
                Console.WriteLine("Cadastro Alterado com sucesso.");
                Console.WriteLine("");
                var outraOperacao = new OutraOperacao();
                outraOperacao.OutraOperacaoCRUD();
            }
        }

        public void AlterarBirthdate(string clienteNome)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                Console.WriteLine("Digite a nova Data de Nascimento: ");
                var novoBirthdate = DateTime.Parse(Console.ReadLine());
                var update = $"UPDATE[Cliente] SET [Birthdate] = @novoNome WHERE [Nome] Like @antigoNome";
                connection.Execute(update, new { novoNome = novoBirthdate, antigoNome = $"%{clienteNome}%" });
                Console.WriteLine("Cadastro Alterado com sucesso.");
                Console.WriteLine("");
                var outraOperacao = new OutraOperacao();
                outraOperacao.OutraOperacaoCRUD();
            }
        }
    }
}
