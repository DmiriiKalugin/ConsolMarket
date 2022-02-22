using System;
using Shop;

namespace Shop
{
    public class Catalog
    {
        private readonly DbProducts.Shirts _shirts = new DbProducts.Shirts();
        private readonly DbProducts.Cup _cup = new DbProducts.Cup();
        private readonly DbProducts.Canvas _canvas = new DbProducts.Canvas();
        private readonly DbProducts.Pin _pin = new DbProducts.Pin();


        public Catalog()
        {
            ConsoleKey key;
            
            ActionsInCatalog();
            
            key = Console.ReadKey().Key;

            Console.WriteLine();
            
            SwitchKeysCatalog(key);
            
        }

        private void ActionsInCatalog()
        {
            Console.WriteLine();
            Console.WriteLine("Каталог");
            Console.WriteLine("Выберите нужный пункт:");
            Console.WriteLine("1:Футболка");
            Console.WriteLine("2:Кружка");
            Console.WriteLine("3:Картина");
            Console.WriteLine("4:Значок");
            Console.WriteLine("0:Назад");
            Console.WriteLine();
        }

        private void SwitchKeysCatalog(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.D1:
                    ActionCategory("shirts");
                    break;
                case ConsoleKey.D2:
                    ActionCategory("cup");
                    break;
                case ConsoleKey.D3:
                    ActionCategory("canvas");
                    break;
                case ConsoleKey.D4:
                    ActionCategory("pin");
                    break;
                case ConsoleKey.D0:
                    new IndexPage();
                    break;
                default:
                    InvalidInput();
                    break;
            }
        }
        
        private void ActionCategory(string obj)
        {
            ConsoleKey key;

            if (obj == "shirts")
            {
                _shirts.GetAction();
                ActionBuy();
                
                key = Console.ReadKey().Key;
                
                SwitchKeysCategory(key, _shirts.Name(), _shirts.Price());
            }
            else if (obj == "cup")
            {
                _cup.GetAction();
                ActionBuy();

                key = Console.ReadKey().Key;
                
                SwitchKeysCategory(key, _cup.Name(), _cup.Price());
            }
            else if (obj == "canvas")
            {
                _canvas.GetAction();
                ActionBuy();

                key = Console.ReadKey().Key;
                
                SwitchKeysCategory(key, _canvas.Name(), _canvas.Price());
            }
            else if (obj == "pin")
            {
                _pin.GetAction();
                ActionBuy();
                
                key = Console.ReadKey().Key;
                
                SwitchKeysCategory(key, _pin.Name(), _pin.Price());
            }

        }
        
        private void ActionBuy()
        {
            Console.WriteLine();
            Console.WriteLine("Выберите нужное действие:");
            Console.WriteLine("1:Купить");
            Console.WriteLine("0:Вернуться назад");
            Console.WriteLine();
        }
        
        private void SwitchKeysCategory(ConsoleKey key, string name, int price)
        {
            switch (key)
            {
                case ConsoleKey.D1:
                    Console.WriteLine();
                    Buy(name,price);
                    break;
                case ConsoleKey.D0:
                    Console.WriteLine();
                    new Catalog();
                    break;
            }
        }

        private void Buy(string name, int price)
        {
            Console.WriteLine("Введите нужное количество и нажмите Enter:");
            string key = Console.ReadLine();
            int count = Convert.ToInt32(key);
            Console.WriteLine(
                $"Наименование: {name}, Количество = {key} шт. Общая стоимость = {(count * price).ToString()} руб.");
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
        
        private void Success()
        {   Console.WriteLine("Товар успешно помещен в корзину");
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
                    new Cart();
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
            Console.WriteLine("Неверная категория, попробуйте ещё");
            new Catalog();
        }
    }
}
    

