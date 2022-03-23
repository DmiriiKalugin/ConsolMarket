using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace Shop
{
    internal class Program
    {
        private static int _choiseMenu;
        private static string _nameProducts;
        private static int _priceProducts;
        private static int _count;
        
        //MenuBlock
        static void MainMenu()
        {
            Print("Выберите нужный пункт \n" +
                  "1.Главная страница \n" +
                  "2.Каталог товаров \n" +
                  "3.Корзина \n" +
                  "4.Контакты \n" +
                  "0.Выход \n" +
                  "Ваш выбор: "
            );

            _choiseMenu = ConvertToInt(Console.ReadLine());
        }

        static void CatalogMenu()
        {
            Print("Выберите нужную категорию \n" +
                  "1.Футболки \n" +
                  "2.Кружки \n" +
                  "3.Значки \n" +
                  "4.Блокноты \n" +
                  "0.Назад \n" +
                  "Ваш выбор: "
            );

            _choiseMenu = ConvertToInt(Console.ReadLine());
        }
        
        static void ProductMenu(string name, int price)
        {
            Print("Наименование товара: \n" +
                  $"{name}, стоимость {Convert.ToString(price)}.00 ₽ \n" +
                  "\n" +
                  "Выберите нужное действие \n" +
                  "1.Положить в корзину \n" +
                  "0.Вернуться назад \n" +
                  "Ваш выбор: "
            );

            _choiseMenu = ConvertToInt(Console.ReadLine());
        }
        
        static void OrderMenu()
        {
            Print("Товар удачно помещен в корзину. \n" +
                  "\n" +
                  "Выберите нужное действие: \n" +
                  "1.Открыть корзину \n" +
                  "0.Продолжить покупки \n" +
                  "Ваш выбор: "
            );

            _choiseMenu = ConvertToInt(Console.ReadLine());
        }
        
        static void BuyMenu()
        {
            PrintLn("Выберите нужное действие: \n" +
                  "1.Оформить заказ \n" +
                  "2.Очистить корзину \n" +
                  "3.Продолжить покупки  \n" +
                  "0.Вернуться на главную покупки \n" +
                  "Ваш выбор: "
            );

            _choiseMenu = ConvertToInt(Console.ReadLine());
        }
        
        static void BuySuccess()
        {
            PrintLn("Выберите нужное действие: \n" +
                  "1.Перейти в каталог \n" +
                  "0.Перейти на главную страницу \n" +
                  "Ваш выбор: "
            );

            _choiseMenu = ConvertToInt(Console.ReadLine());
        }
        
        //EndblockMenu
        
        
        static void Main(string[] args)
        {
            MainMenu();

            Cart[] _carts = new Cart[0];

            while (_choiseMenu != 0)
            {
                switch (_choiseMenu)
                {
                    case 0:
                        Clear();
                        Array.Resize(ref _carts, 0);
                        break;
                    case 1:
                        Clear();
                        break;
                    case 2:
                        Clear();
                        Category(ref _carts);
                        break;
                    case 3:
                        Clear();
                        PrintCart(ref _carts);
                        break;
                    case 4:
                        Clear();
                        Contact(ref _carts);
                        break;
                }
                MainMenu();
            }
        }


        //OtherClassBlock
        static void Category(ref Cart[] _carts)
        {
            CatalogMenu();
            
            switch (_choiseMenu)
            {
                case 0:
                    Clear();
                    break;
                case 1:
                    Clear();
                    
                    _nameProducts = "Футболка хлопковая, черная";
                    _priceProducts = 780;

                    ProductMenu(_nameProducts, _priceProducts);

                    switch (_choiseMenu)
                    {
                        case 0:
                            Clear();
                            Category(ref _carts);
                            break;
                        case 1:
                            Clear();
                            Print("Введите нужное количество: ");
                            _count = ConvertToInt(InputConsole());
                            SendDataToCart(ref _carts, _nameProducts, _count,_priceProducts);
                            Clear();
                            OrderMenu();
                            if (_choiseMenu == 1)
                            {
                                Clear();
                                PrintCart(ref _carts);
                            }
                            else
                            {
                                Clear();
                                Category(ref _carts);
                            }
                            break;
                    }
                    break;
                case 2:
                    Clear();
                    
                    _nameProducts = "Кружка керамическая, белая, 330мл.";
                    _priceProducts = 450;

                    ProductMenu(_nameProducts, _priceProducts);

                    switch (_choiseMenu)
                    {
                        case 0:
                            Clear();
                            Category(ref _carts);
                            break;
                        case 1:
                            Clear();
                            Print("Введите нужное количество: ");
                            _count = ConvertToInt(InputConsole());
                            SendDataToCart(ref _carts, _nameProducts, _count,_priceProducts);
                            Clear();
                            OrderMenu();
                            if (_choiseMenu == 1)
                            {
                                Clear();
                                PrintCart(ref _carts);
                            }
                            else
                            {
                                Clear();
                                Category(ref _carts);
                            }
                            break;
                    }
                    break;
                case 3:
                    Clear();
                    
                    _nameProducts = "Значок закатной, круглый 56мм";
                    _priceProducts = 50;

                    ProductMenu(_nameProducts, _priceProducts);

                    switch (_choiseMenu)
                    {
                        case 0:
                            Clear();
                            Category(ref _carts);
                            break;
                        case 1:
                            Clear();
                            Print("Введите нужное количество: ");
                            _count = ConvertToInt(InputConsole());
                            SendDataToCart(ref _carts, _nameProducts, _count,_priceProducts);
                            Clear();
                            OrderMenu();
                            if (_choiseMenu == 1)
                            {
                                Clear();
                                PrintCart(ref _carts);
                            }
                            else
                            {
                                Clear();
                                Category(ref _carts);
                            }
                            break;
                    }
                    break;
                case 4:
                    Clear();
                    
                    _nameProducts = "Блокнот А5, 48листов";
                    _priceProducts = 110;

                    ProductMenu(_nameProducts, _priceProducts);

                    switch (_choiseMenu)
                    {
                        case 0:
                            Clear();
                            Category(ref _carts);
                            break;
                        case 1:
                            Clear();
                            Print("Введите нужное количество: ");
                            _count = ConvertToInt(InputConsole());
                            SendDataToCart(ref _carts, _nameProducts, _count,_priceProducts);
                            Clear();
                            OrderMenu();
                            if (_choiseMenu == 1)
                            {
                                Clear();
                                PrintCart(ref _carts);
                            }
                            else
                            {
                                Clear();
                                Category(ref _carts);
                            }
                            break;
                    }
                    break;
            }
        }

        static void Contact(ref Cart[] _carts)
        {
            PrintLn("Наши контакты:");
            PrintLn("Адрес: г.Екатеринбург, ул.Ленина");
            PrintLn("телефон: 89228888888");
            PrintLn("ПН-ПТ с 10:00 - 19:00");
            PrintLn("email: mail@mail.ru");
            PrintLn("");
            
            BuySuccess();
            if (_choiseMenu == 1)
            {
                Clear();
                Category(ref _carts);
            }
            else 
            {
                Clear();
            }
        }

        static void SendDataToCart(ref Cart[] _carts, string name, int count,int price)
        {
            int numberPositions = _carts.Length;

            ProductData _productData = default;

            if (numberPositions == 0)
            {
                _carts = new Cart[numberPositions + 1];

                for (int i = 0; i < _carts.Length; i++)
                {
                    _carts[i] = new Cart();
                }

                _productData.name = name;
                _productData.count = count;
                _productData.price = price;
                
                _carts[0].AddToCart(_productData);
            }
            else
            {
                Cart[] _bufCart = (Cart[]) _carts.Clone();
                
                _carts = new Cart[numberPositions + 1];

                for (int i = 0; i < _carts.Length; i++)
                {
                    _carts[i] = new Cart();
                }

                for (int i = 0; i < _bufCart.Length; i++)
                {
                    _carts[i] = _bufCart[i];
                }
                _productData.name = name;
                _productData.count = count;
                _productData.price = price;
                
                _carts[numberPositions].AddToCart(_productData);
            }
        }

        static void PrintCart(ref Cart[] _cart)
        {
            if (_cart.Length != 0)
            {
                int i = 1;

                foreach (Cart carts in _cart)
                {
                    PrintLn("Товар №" + i++);
                    carts.DataCartOut();
                    PrintLn("***************************");
                    PrintLn("");
                }
                
                BuyMenu();
                switch (_choiseMenu)
                {
                    case 1:
                        Clear();
                        Print("Заказ успешно оформлен");
                        Array.Resize(ref _cart, 0);
                        InputConsole();
                        Clear();
                        BuySuccess();
                        if (_choiseMenu == 1)
                        {
                            Clear();
                            Category(ref _cart);
                        }
                        else
                        {
                            Clear();
                        }
                        
                        break;
                    case 2:
                        Clear();
                        Print("Корзина очищена");
                        Array.Resize(ref _cart, 0);
                        InputConsole();
                        Clear();
                        PrintCart(ref _cart);
                        break;
                    case 3:
                        Clear();
                        Category(ref _cart);
                        break;
                    case 0:
                        Clear();
                        break;
                }
            }
            else 
            {
                Clear();
                PrintLn("Корзина пуста");
            }
            PrintLn("Для продолжения нажмите ENTER");
            InputConsole();
            Clear();
        }
        //EndOtherClassBlock
        
        
        //AdditionalClassBlock
        static string InputConsole()
        {
            return Console.ReadLine();
        }

        static int ConvertToInt(string text)
        {
            return Convert.ToInt32(text);
        }

        static void Print(object obj)
        {
            Console.Write(Convert.ToString(obj));
        }
        
        static void PrintLn(object obj)
        {
            Console.WriteLine(Convert.ToString(obj));
        }
        
        static void Clear()
        {
            Console.Clear();
        }
        //EndAdditionalClassBlock
        
    }
}