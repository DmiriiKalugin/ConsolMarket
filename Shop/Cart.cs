using System;

namespace Shop
{
    public class Cart
    {
        private string Name;
        private int Query;
        private float Price;

        public Cart()
        {
            Console.WriteLine("Корзина");
        }
        
        public Cart(string name, int query, float price)
        {
            Name = name;
            Query = query;
            Price = price;
        }

        public string Print()
        {
            string order =
                $"Наименование : {Name}  Количество: {Query.ToString()} шт. Стоимость: {Price.ToString()} руб.";

            return order;
        }
        
        private void CartAdded(string Name, int Query)
        {
            
        }

    }
}