using System;
using System.Collections.Generic;

namespace OrderManagement.Model
{
    public class Order
    {
        public string OrderNo { get; set; }
        public List<OrderItem> Items { get; set; }
        public DateTime OrderDate { get; set; }
        public int UserId { get; set; }
        public double TotalAmount { get; set; }
        public Double DiscountedAmount { get; set; }
    }
}
