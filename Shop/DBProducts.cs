using System;

namespace Shop
{
    public class DbProducts
    {
        public class Shirts : Product
        {
            public override string Name()
            {
                string name = "Чёрная футболка";
                
                return name;
            }

            public override int Price()
            {
                int price = 750;

                return price;
            }

            public override void GetAction()
            {
                Console.WriteLine($"Наименование: {Name()}");
                Console.WriteLine($"Стоимость: {Price().ToString()} рублей");
            }
        }
        
        public class Cup : Product
        {
            public override string Name()
            {
                string name = "Белая кружкка";
                
                return name;
            }

            public override int Price()
            {
                int price = 330;

                return price;
            }
            
            public override void GetAction()
            {
                Console.WriteLine($"Наименование: {Name()}");
                Console.WriteLine($"Стоимость: {Price().ToString()} рублей");
            }
        }
        
        public class Canvas : Product
        {
            public override string Name()
            {
                string name = "Фотография на холсте 50*40";
                
                return name;
            }

            public override int Price()
            {
                int price = 1150;

                return price;
            }
            
            public override void GetAction()
            {
                Console.WriteLine($"Наименование: {Name()}");
                Console.WriteLine($"Стоимость: {Price().ToString()} рублей");
            }
        }
        
        public class Pin : Product
        {
            public override string Name()
            {
                string name = "Значек закатной 56см";
                
                return name;
            }

            public override int Price()
            {
                int price = 100;

                return price;
            }
            
            public override void GetAction()
            {
                Console.WriteLine($"Наименование: {Name()}");
                Console.WriteLine($"Стоимость: {Price().ToString()} рублей");
            }
        }
    }
}