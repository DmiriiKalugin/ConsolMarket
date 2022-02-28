using System;
using System.Linq;
using System.Xml;

namespace Shop
{
    internal class Program
    {
        struct Product
        {
            public string _name;
            public string _price;

            public void Print()
            {
                Console.WriteLine(
                    $"Имя {_name} \n" +
                    $"Цена {_price} рублей"
                );
            }
        }
        
        static int _stateMenu;
        static void Menu()
        {
            Console.Write(
                "выберите действие: \n" +
                "1.Главная страница \n" +
                "2.Каталог товаров  \n" +
                "3.Корзина  \n" +
                "4.Контакты  \n" +
                "0.Выход: \n"
            );

            _stateMenu = Convert.ToInt32(Console.ReadLine());
        }
        public static void Main(string[] args)

        {
            Console.WriteLine("Рады приветствовать вас в нашем магазине!");
            
            Menu();
            int _action;
            bool isData = false;
            Product[] _data = new Product[0];
            
            while (_stateMenu != 0)
            {
                switch (_stateMenu)
                {
                    case 1:
                        Console.WriteLine("Привет");
                        break;
                }
            }
        }
    }
}