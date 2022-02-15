using System;
using Shop;

namespace Shop
{
    public class Catalog
    {
        static int invalid = 0;
        public Catalog()
        {
            ConsoleKey key;
            
            Console.WriteLine("Каталог");
            Console.WriteLine("Выберите нужный пункт:");
            Console.WriteLine("1:Футболка");
            Console.WriteLine("2:Кружка");
            Console.WriteLine("3:Картина");
            Console.WriteLine("4:Значок");
            Console.WriteLine("0:Назад");
            key = Console.ReadKey().Key;
            Console.WriteLine();
            switch (key)
            {
                case ConsoleKey.D1:
                    new Tshirts();
                    break;
                case ConsoleKey.D2:
                    new Cup();
                    break;
                case ConsoleKey.D3:
                    new Canvas();
                    break;
                case ConsoleKey.D4:
                    new Pin();
                    break;
                case ConsoleKey.D0:
                    new IndexPage();
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
                    Console.WriteLine("Неверная категория");
                    break;
                case 1:
                    Console.WriteLine("Опять не верно. ВНИМАТЕЛЬНЕЙ!");
                    break;
                case 2:
                default:
                    Console.WriteLine("Для возвращения назад нажмите 0");
                    break;
            }
            invalid++;  
        }
    }
    
    public class Tshirts{
        ConsoleKey key;
        static int invalid = 0;
        public Tshirts()
        {
            Console.WriteLine("Футболка новая и красивая");
            Console.WriteLine("Стоимость: 500 рублей");
            Console.WriteLine("Доступное количество: 100 шт.");
            Console.WriteLine("Выберите нужное действие:");
            Console.WriteLine("1:Купить");
            Console.WriteLine("0:Назад");
            
            key = Console.ReadKey().Key;
            
            Console.WriteLine();
            
            switch (key)
            {
                case ConsoleKey.D1:
                    new Buy();
                    break;
                case ConsoleKey.D0:
                    new Catalog();
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
                    Console.WriteLine("Неверная категория");
                    break;
                case 1:
                    Console.WriteLine("Опять не верно. ВНИМАТЕЛЬНЕЙ!");
                    break;
                case 2:
                default:
                    Console.WriteLine("Для возвращения назад нажмите 0");
                    break;
            }
            invalid++;  
        }
            
        }
    
        public class Cup{
        public Cup()
        {
            Console.WriteLine("Кружка");
        }
    }
    
    public class Canvas{
        public Canvas()
        {
            Console.WriteLine("Картина");
        }
    }
    
    public class Pin{
        public Pin()
        {
            Console.WriteLine("Значок");
        }
    }

    public class Buy{
        static int invalid = 0;
        public Buy()
        {
            Console.WriteLine("Введите нужное количество:");
            string key = Console.ReadLine();
            int count = Convert.ToInt32(key);
            Console.WriteLine($"Количество = {key} шт. Общая стоимость = {(count * 500).ToString()} руб.");
            Console.WriteLine("1:Поместить в корзину");
            Console.WriteLine("0:Отменить");
            ConsoleKey choise = Console.ReadKey().Key;
            Console.WriteLine();

            switch (choise)
            {
                case ConsoleKey.D1:
                    
                    Success();
                    break;
                case ConsoleKey.D0:
                    new Catalog();
                    break;
                default:
                    InvalidInput();
                    break;
            }
        }

        static void Success()
        {   Console.WriteLine("Товар помещен в корзину");
            Console.WriteLine();
            Console.WriteLine("Выберите нужное действие:");
            Console.WriteLine();
            Console.WriteLine("1:Открыть корзину");
            Console.WriteLine("2:Продолжить покупки");
            Console.WriteLine("0:Вернутся на главную страницу");
            ConsoleKey key = Console.ReadKey().Key;
            Console.WriteLine();

            switch (key)
            {
                case ConsoleKey.D1:
                    Success();
                    break;
                case ConsoleKey.D2:
                    new Catalog();
                    break;
                case ConsoleKey.D0:
                    new IndexPage();
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
                    Console.WriteLine("Неверный выбор");
                    break;
                case 1:
                    Console.WriteLine("Опять не верно. ВНИМАТЕЛЬНЕЙ!");
                    break;
            }
            invalid++;  
        }
    }
}
    

