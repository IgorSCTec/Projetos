using CRUD_Console.Models;
using CRUD_Console.Repositories;
using Microsoft.Data.SqlClient;
using System;

namespace CRUD_Console.Screens.ScreensUser
{
    class Update
    {
        public void UpdateUser(SqlConnection connection)
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

                Console.Write("Digite o nome do cliente que deseja Atualizar: ");
                var nome = Console.ReadLine();
                Console.WriteLine("");

                Console.Clear();

                var sql = $"SELECT [Id],[Nome],[Email],[Phone],[Birthdate],[CreateDate] FROM [Cliente] WHERE [Nome] LIKE @teste";

                var repository2 = new Repository<Cliente>(connection);
                var users = repository.Read(sql, nome);


                foreach (var item in users)
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
                    case 1: AlterarNome(nome, connection); break;

                    case 2: AlterarEmail(nome, connection); break;

                    case 3: AlterarPhone(nome, connection); break;

                    case 4: AlterarBirthdate(nome, connection); break;

                    default:
                        Console.WriteLine("");
                        Console.Write("Essa não é uma opção válida. Por gentileza selecionar a operação que deseja.");

                        break;

                }

            }


            public static void AlterarNome(string antigoNome, SqlConnection connection)
            {
                Console.Write("Digite o novo Nome: ");
                var novoNome = Console.ReadLine();
                Console.WriteLine("");
                var update = $"UPDATE[Cliente] SET [Nome] = @novoNome WHERE [Nome] Like @antigoNome";

                var repository = new Repository<Cliente>(connection);
                repository.Update(update, novoNome, antigoNome);

                Console.WriteLine("Cadastro Alterado com sucesso.");
                Console.WriteLine("");
                var outraOperacao = new OutraOperacao();
                outraOperacao.OutraOperacaoCRUD(connection);

            }

            public static void AlterarEmail(string antigoNome, SqlConnection connection)
            {
                Console.Write("Digite o novo E-mail: ");
                var novoEmail = Console.ReadLine();
                Console.WriteLine("");
                var update = $"UPDATE[Cliente] SET [Email] = @novoNome WHERE [Nome] Like @antigoNome";

                var repository = new Repository<Cliente>(connection);
                repository.Update(update, novoEmail, antigoNome);

                Console.WriteLine("Cadastro Alterado com sucesso.");
                Console.WriteLine("");
                var outraOperacao = new OutraOperacao();
                outraOperacao.OutraOperacaoCRUD(connection);
            }

            public static void AlterarPhone(string antigoNome, SqlConnection connection)
            {
                Console.Write("Digite o novo Telefone: ");
                var novoPhone = Console.ReadLine();
                Console.WriteLine("");
                var update = $"UPDATE[Cliente] SET [Phone] = @novoNome WHERE [Nome] Like @antigoNome";

                var repository = new Repository<Cliente>(connection);
                repository.Update(update, novoPhone, antigoNome);

                Console.WriteLine("Cadastro Alterado com sucesso.");
                Console.WriteLine("");
                var outraOperacao = new OutraOperacao();
                outraOperacao.OutraOperacaoCRUD(connection);
            }

            public static void AlterarBirthdate(string antigoNome, SqlConnection connection)
            {
                Console.Write("Digite a nova Data de Nascimento: ");
                var novoBirthdate = DateTime.Parse(Console.ReadLine());
                var update = $"UPDATE[Cliente] SET [Birthdate] = @novoNome WHERE [Nome] Like @antigoNome";

                var repository = new Repository<Cliente>(connection);
                repository.Update(update, novoBirthdate, antigoNome);

                Console.WriteLine("Cadastro Alterado com sucesso.");
                Console.WriteLine("");
                var outraOperacao = new OutraOperacao();
                outraOperacao.OutraOperacaoCRUD(connection);
            }
    }
}
