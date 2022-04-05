using System;
using System.Threading;
using CRUD_Console.Operacoes;
using Microsoft.Data.SqlClient;

namespace CRUD_Console
{
    class Menu
    {
        public void MenuCRUD(SqlConnection connection)
        {
            Console.Clear();
            Console.WriteLine("Clientes");
            Console.WriteLine("");
            Console.WriteLine("1 - Cadastrar");
            Console.WriteLine("2 - Atualizar");
            Console.WriteLine("3 - Consultar");
            Console.WriteLine("4 - Deletar");
            Console.WriteLine("");
            Console.Write("Escolha a opção desejada: ");

            int opcao;

            while (!int.TryParse(Console.ReadLine(), out opcao))
            {
                Console.WriteLine("");
                Console.Write("Essa não é uma opção válida. Por gentileza selecionar a operação que deseja.");
                Thread.Sleep(1000);
                MenuCRUD(connection);
            }

            switch (opcao)
            {
                case 1: var create = new Insert(); create.CreateUser(connection); break;
                case 2: var update = new Update(); update.UpdateUser(connection); break;
                case 3: var select = new Select(); select.ReadUser(connection); break;
                case 4: var delete = new Delete(); delete.DeleteUser(connection); break;
                default:
                    Console.WriteLine("");
                    Console.Write("Essa não é uma opção válida. Por gentileza selecionar a operação que deseja.");
                    Thread.Sleep(1000);
                    MenuCRUD(connection); break;
                    ;
            }
        }
    }
}
