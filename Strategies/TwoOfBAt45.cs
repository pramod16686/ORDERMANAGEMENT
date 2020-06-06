using System;
using OrderManagement.Model;
using System.Linq;
using System.Collections.Generic;


namespace OrderManagement.Strategies
{
    public class TwoOfBAt45 : IPromotion
    {
        public const double offeredPrice = 45;

        public void Apply(List<OrderItem> items)
        {
            var productsB = items.Where(x => x.Category == "B").SingleOrDefault();

            if (productsB != null)
            {
                int quotient = (productsB.Quantity) / 2;
                int remainder = (productsB.Quantity) % 2;

                double price = (offeredPrice * quotient) + (remainder * productsB.Price);
                productsB.DiscountedPrice = price;
                productsB.IsDiscountApplied = true;
            }
        }
    }
}
