using System;

namespace CRUD_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var menu = new Menu();
            menu.MenuCRUD();
            Console.ReadKey();
        }
    }
}
