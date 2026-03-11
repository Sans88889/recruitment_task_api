namespace recruitment_task.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }

        // Relacja: Produkt może być w wielu zamówieniach
        public List<Order> Orders { get; set; } = new();
    }
}