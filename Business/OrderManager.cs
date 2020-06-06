using OrderManagement.Model;
using OrderManagement.Strategies;
using System;
using System.Collections.Generic;

namespace OrderManagement.Business
{
    public class OrderManager
    {
        private List<IPromotion> _promotions { get; set; }
        private Order _order { get; set; }

        public OrderManager(Order order, List<IPromotion> promotions)
        {
            _order = order;
            _promotions = promotions;
        }

        public Order CalculateTotal()
        {
            try
            {
                double totalAmount = 0;
                double discountedAmount = 0;
                foreach (IPromotion promotion in _promotions)
                    promotion.Apply(_order.Items);

                foreach (var item in _order.Items)
                {
                    totalAmount += item.ActualPrice;
                    discountedAmount += item.IsDiscountApplied == true ? item.DiscountedPrice : item.ActualPrice;
                }

                _order.TotalAmount = totalAmount;
                _order.DiscountedAmount = discountedAmount;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return _order;
        }

    }
}