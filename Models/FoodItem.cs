namespace FoodAppAPI.Models
{
    public class FoodItem   // ✅ MUST be FoodItem (capital I)
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public double Price { get; set; }
    }
}