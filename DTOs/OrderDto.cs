namespace recruitment_task.DTOs
{
    public class OrderDto
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public string CustomerName { get; set; } = string.Empty;
        public List<ProductDto> Products { get; set; } = new();
    }
}