using CRUD_Console.Models;
using CRUD_Console.Repositories;
using Microsoft.Data.SqlClient;
using System;

namespace CRUD_Console.Screens.ScreensUser
{
    class Select
    {
       
        public void ReadUser(SqlConnection connection)
        {
                Console.WriteLine("");
                Console.Write("Digite o nome que deseja consultar: ");
                var nome = Console.ReadLine();
                Console.WriteLine("");
                var sql = $"SELECT [Id],[Nome],[Email],[Phone],[Birthdate],[CreateDate] FROM [Cliente] WHERE [Nome] LIKE @teste";

                var repository = new Repository<Cliente>(connection);
                var users = repository.Read(sql, nome);

                foreach (var item in users)
                {
                    Console.WriteLine($"Id: {item.Id} - Nome: {item.Nome} - E-mail: {item.Email} - Telefone: {item.Phone} - Data de Nascimento: {item.Birthdate} - Data de Cadastro: {item.CreateDate}");
                }


                Console.WriteLine("");
                var outraOperacao = new OutraOperacao();
                outraOperacao.OutraOperacaoCRUD(connection);
        }
    }
}
