using System;

namespace Shop
{
    public class Contact
    {
        public Contact()
        {

            ConsoleKey key;
            
            
            Console.WriteLine();
            Console.WriteLine("Контакты");
            Console.WriteLine("Номер телефона:");
            Console.WriteLine("8-800-200-600");
            Console.WriteLine("Email:");
            Console.WriteLine("mail@mai.ru");
            Console.WriteLine("Адрес:");
            Console.WriteLine("г. Москва");
            Console.WriteLine();
            
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
                    new Cart();
                    break;
                case ConsoleKey.D4:
                    new Contact();
                    break;
                case ConsoleKey.D0:
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