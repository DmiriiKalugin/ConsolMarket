using System;
using System.Xml.Serialization;

namespace Shop
{
    public class IndexPage
    {
        static int invalid = 0;
        public IndexPage()
        {
            ConsoleKey key;
            Console.WriteLine("Выберите нужный пункт:");
            Console.WriteLine("1:Главная страница");
            Console.WriteLine("2:Каталог товаров");
            Console.WriteLine("3:Корзина");
            Console.WriteLine("4:Контакты");
            Console.WriteLine("0:Выход");
            key = Console.ReadKey().Key;
            Console.WriteLine();
            switch (key)
            {
                case ConsoleKey.D1:
                    new IndexPage();
                    break;
                case ConsoleKey.D2:
                    new Catalog();
                    break;
                case ConsoleKey.D3:
                    new Cart();
                    break;
                case ConsoleKey.D4:
                    new Contact();
                    break;
                case ConsoleKey.D0:
                    Console.WriteLine("Досвидания");
                    Environment.Exit(0);
                    break;
                default:
                    InvalidInput();
                    break;
            }
        }
        
        static void InvalidInput()
        {
            switch(invalid)
            {
                case 0:
                    Console.WriteLine("Неверный ввод");
                    break;
                case 1:
                    Console.WriteLine("Опять не верно. ВНИМАТЕЛЬНЕЙ!");
                    break;
                case 2:
                default:
                    Console.WriteLine("Для выхода нажмите 0");
                    Console.WriteLine("Ты ШО писать не умеешь не граматный");
                    break;
            }
            invalid++;  
        }
            
    }
}