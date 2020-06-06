using System;
using OrderManagement.Model;
using OrderManagement.Business;
using OrderManagement.Strategies;
using System.Collections.Generic;

namespace OrderManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            List<OrderItem> items = new List<OrderItem>()
            {
                new OrderItem(){Name = "Mobile", Category = "A", Quantity = 2, Price = 15000,SubCategory ="A1"},
                new OrderItem(){Name = "Charge2", Category = "B", Quantity = 2, Price = 15000,SubCategory ="A1"},
                new OrderItem(){Name = "Laptop", Category = "C", Quantity = 2, Price = 15000,SubCategory ="A1"},
                new OrderItem(){Name = "WashiMachine", Category = "D", Quantity = 2, Price = 15000,SubCategory ="A1"}
            };

            Order order = new Order() { UserId = 123, Items = items, OrderNo = "O0000001", OrderDate = new DateTime() };


            List<IPromotion> promotions = new List<IPromotion>()
{
    new CandDAt30(),
    new ThreeOfAAt130(),
    new TwoOfBAt45()
};
            OrderManager manager = new OrderManager(order, promotions);
            order = manager.CalculateTotal();
        }
    }
}
