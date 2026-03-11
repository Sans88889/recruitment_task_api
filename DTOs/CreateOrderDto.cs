namespace recruitment_task.DTOs
{
    public class CreateOrderDto
    {
        public string CustomerName { get; set; } = string.Empty;
        public List<int> ProductIds { get; set; } = new();
    }
}