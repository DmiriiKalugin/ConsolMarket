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
            foreach (var orders in _carts)
            {
                Console.WriteLine(orders);
            }
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