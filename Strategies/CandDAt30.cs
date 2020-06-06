using System;
using OrderManagement.Model;
using System.Linq;
using System.Collections.Generic;

namespace OrderManagement.Strategies
{
    public class CandDAt30 : IPromotion
    {
        public const double offeredPrice = 30;
        public void Apply(List<OrderItem> items)
        {
            double priceAfterDiscount  = 0;

             var productsC = items.Where(x=> x.Category == "C").SingleOrDefault(); 
             var productsD = items.Where(x=> x.Category == "C").SingleOrDefault(); 

 if(productsC != null && productsD != null)
 {
     if (productsC.Quantity == productsD.Quantity)
     {
         priceAfterDiscount = productsC.Quantity * offeredPrice;
     }
     else if (productsC.Quantity > productsD.Quantity)
     {
         int diff = productsC.Quantity - productsD.Quantity;
         priceAfterDiscount = (diff * offeredPrice) + (( productsC.Quantity - diff) * productsC.ActualPrice);
         
     }
     productsC.DiscountedPrice = priceAfterDiscount;
     productsD.DiscountedPrice = 0;
     productsC.IsDiscountApplied = true;
     productsD.IsDiscountApplied = true;
 }

        }

    }
}