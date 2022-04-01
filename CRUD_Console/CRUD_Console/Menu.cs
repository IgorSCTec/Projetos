using System;
using System.Threading;
using CRUD_Console.Operacoes;

namespace CRUD_Console
{
    class Menu
    {
        public void MenuCRUD()
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
                MenuCRUD();
            }

            switch (opcao)
            {
                case 1: var cadastrar = new Insert(); cadastrar.InsertUser(); break;
                case 2: var atualizar = new Update(); atualizar.Atualizar(); break;
                case 3: var consultar = new Select(); consultar.ReadUser(); break;
                case 4: var deletar = new Delete(); deletar.Deletar(); break;
                default:
                    Console.WriteLine("");
                    Console.Write("Essa não é uma opção válida. Por gentileza selecionar a operação que deseja.");
                    Thread.Sleep(1000);
                    MenuCRUD(); break;
                    ;
            }
        }
    }
}
