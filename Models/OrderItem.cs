namespace DessertOnTapWeb.Models
{
    public class OrderItem
    {
        public int Quantity { get; set; }
        public Item Item { get; set; }
        public decimal SubTotal { get; set; }
    }
}