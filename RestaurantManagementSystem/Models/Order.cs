namespace RestaurantManagementSystem.Models
{
    public class Order
    {
        public Order()
        {
            OrderItems = new HashSet<OrderItem>();
        }

        public int Id { get; set; }

        public bool IsTakeAway { get; set; }

        public int? TableNo { get; set; }

        public string? OrderPlaceBy { get; set; }

        public double Total { get; set; }

        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
