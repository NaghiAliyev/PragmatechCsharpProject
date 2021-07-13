using System;

namespace Task01
{
    public class Order
    {
        public Product OrderedProduct { get; set; }
        public int Weight { get; set; }
        public int Price { get; set; }
        public DateTime Date { get; set; }
        public string DeliveryMethod { get; set; }

        public int CalculateOrderPrice()
        {
            return Price = OrderedProduct.Price * Weight;
        }
    }
}
