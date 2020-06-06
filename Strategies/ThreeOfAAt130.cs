using OrderManagement.Model;
using System.Linq;
using System.Collections.Generic;


namespace OrderManagement.Strategies
{
    public class ThreeOfAAt130 : IPromotion
    {
        public const double offeredPrice = 130;
        public void Apply(List<OrderItem> items)
        {
            var productsA = items.Where(x => x.Category == "A").SingleOrDefault();

            if (productsA != null)
            {
                int quotient = (productsA.Quantity) / 3;
                int remainder = (productsA.Quantity) % 3;

                double price = (offeredPrice * quotient) + (remainder * productsA.Price);
                productsA.DiscountedPrice = price;
                productsA.IsDiscountApplied = true;
            }
        }
    }
}