namespace recruitment_task.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.UtcNow;
        public string CustomerName { get; set; } = string.Empty;

        // Relacja: Zamówienie może mieć wiele produktów
        public List<Product> Products { get; set; } = new();
    }
}