using System;
using System.Diagnostics;

namespace Shop
{
    
    public struct ProductData
    {
        public string name;
        public int count;
        public int price;
    }
    
    
    public class Cart
    {
        private ProductData _productData;
        
        public Cart(){}

        public void AddToCart(ProductData productData)
        {
            _productData = productData;
        }

        public void DataCartOut()
        {
            Console.WriteLine("Товар: " + _productData.name);
            Console.WriteLine("Количество товара: " + Convert.ToString(_productData.count) + "шт.");
            Console.WriteLine("Стоимость за единицу товара: " + Convert.ToString(_productData.price) + ".00" + " ₽");
            Console.WriteLine("Общая стоимость:" + Convert.ToString(_productData.count *  _productData.price) + ".00" + " ₽");
        }
    }
}