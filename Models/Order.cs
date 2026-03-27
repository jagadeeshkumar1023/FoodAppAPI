namespace FoodAppAPI.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int FoodItemId { get; set; }
        public int Quantity { get; set; }
    }
}