using OrderManagement.Model;
using System.Collections.Generic;

namespace OrderManagement.Strategies
{
    public interface IPromotion
    {
         public void Apply(List<OrderItem> items);
    }
}