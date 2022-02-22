using System;

namespace Shop
{
    public class Cart
    {
        private readonly string[] _carts = new string[] {""};

        public Cart()
        {

        }

        public void Print()
        {
            Console.WriteLine();
            foreach (var orders in _carts)
            {
                Console.WriteLine(orders);
            }

            new Catalog();
        }

        public void CartAdded(string name, int query, int price)
        {

            for (int i = 0; i < _carts.Length; i++)
            {
                _carts[i] =
                    $"Наименование : {name}  Количество: {query.ToString()} шт. Стоимость: {price.ToString()} руб.";
           
            }

        }

    }
}