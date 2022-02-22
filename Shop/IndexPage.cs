using System;
using System.Xml.Serialization;

namespace Shop
{
    public class IndexPage
    {
        public IndexPage()
        {
            ConsoleKey key;
            Console.WriteLine("Выберите нужный пункт:");
            Console.WriteLine("1:Главная страница");
            Console.WriteLine("2:Каталог товаров");
            Console.WriteLine("3:Корзина");
            Console.WriteLine("4:Контакты");
            Console.WriteLine("0:Выход");
            Console.WriteLine();
            key = Console.ReadKey().Key;
            
            switch (key)
            {
                case ConsoleKey.D1:
                    new IndexPage();
                    break;
                case ConsoleKey.D2:
                    new Catalog();
                    break;
                case ConsoleKey.D3:
                    new Cart().Print();
                    break;
                case ConsoleKey.D4:
                    new Contact();
                    break;
                case ConsoleKey.D0:
                    Console.WriteLine();
                    Console.WriteLine("До свидания");
                    Environment.Exit(0);
                    break;
                default:
                    InvalidInput();
                    break;
            }
        }
        
        static void InvalidInput()
        {
            Console.WriteLine("Не верный пункт, попробуйте ещё раз");
            new IndexPage();
        }
            
    }
}