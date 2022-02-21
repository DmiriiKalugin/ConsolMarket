namespace Shop
{
    public class DbProducts
    {
        public class Shirts : Product
        {
            public override string Name()
            {
                string name = "Красивая футболка";
                
                return name;
            }

            public override int Price()
            {
                int price = 750;

                return price;
            }
        }
        
        public class Cup : Product
        {
            public override string Name()
            {
                string name = "Красивая кружкка";
                
                return name;
            }

            public override int Price()
            {
                int price = 330;

                return price;
            }
        }
        
        public class Canvas : Product
        {
            public override string Name()
            {
                string name = "Красивый холст";
                
                return name;
            }

            public override int Price()
            {
                int price = 1150;

                return price;
            }
        }
    }
}