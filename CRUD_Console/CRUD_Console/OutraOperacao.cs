using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Console
{
    class OutraOperacao
    {
        public void OutraOperacaoCRUD(SqlConnection connection)
        {
            var menu = new Menu();
            Console.WriteLine("Deseja fazer mais alguma operação?");
            Console.WriteLine("");
            Console.Write("Digite Sim ou Não: ");
            string escolha = Console.ReadLine();

            if (escolha == "Sim")
            {
                menu.MenuCRUD(connection);
            }

            if (escolha == "Não")
            {
                Console.WriteLine("");
                Console.WriteLine("Obrigado por utilizar o nosso software, até a próxima.");
                Console.WriteLine("");
                Console.WriteLine("Aperte qualque tecla para finalizar.");
                Console.ReadKey();
                System.Environment.Exit(0);
            }

            if (escolha != "Sim" && escolha != "Não")
            {
                while (escolha != "Sim" && escolha != "Não")
                {
                    Console.Write("Está não é uma opção válida. Digite Sim para fazer outra operação ou Não para sair do Sistema: ");
                    string novaEscolha = Console.ReadLine();
                    escolha = novaEscolha;
                }

                if (escolha == "Sim")
                {
                    menu.MenuCRUD(connection);
                }

                if (escolha == "Não")
                {
                    Console.WriteLine("");
                    Console.WriteLine("Obrigado por utilizar o nosso software, até a próxima.");
                    Console.WriteLine("");
                    Console.WriteLine("Aperte qualque tecla para finalizar.");
                    Console.ReadKey();
                    System.Environment.Exit(0);
                }
            }

            Console.WriteLine("Obrigado por utilizar o nosso software, até a próxima.");
            Console.WriteLine("Aperte qualquer tecla para finalizar.");
            Console.ReadKey();
            System.Environment.Exit(0);

        }
    }
}
