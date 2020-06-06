
namespace OrderManagement.Model
{
    public class OrderItem
    {


        public string Name { get; set; }
        public string Category { get; set; }
        public string SubCategory { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public double ActualPrice
        {
            get
            { return (Quantity * Price); }
        }
        public double DiscountedPrice { get; set; }
        public bool IsDiscountApplied { get; set; }
    }
}
