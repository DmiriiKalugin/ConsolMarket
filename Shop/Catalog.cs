using System;

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
        public Tshirts()
        {
            Console.WriteLine("Футболка");
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
}
