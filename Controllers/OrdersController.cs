using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using recruitment_task.Data;
using recruitment_task.DTOs;
using recruitment_task.Models;

namespace recruitment_task.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly DataContext _context;

        public OrdersController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Orders (Pobiera zamówienia wraz z produktami)
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OrderDto>>> GetOrders()
        {
            var orders = await _context.Orders
                .Include(o => o.Products) 
                .ToListAsync();

            var result = orders.Select(o => new OrderDto
            {
                Id = o.Id,
                CustomerName = o.CustomerName,
                OrderDate = o.OrderDate,
                Products = o.Products.Select(p => new ProductDto
                {
                    Id = p.Id,
                    Name = p.Name,
                    Price = p.Price
                }).ToList()
            });

            return Ok(result);
        }

        // POST: api/Orders (Tworzy nowe zamówienie)
        [HttpPost]
        public async Task<ActionResult<OrderDto>> CreateOrder(CreateOrderDto createOrderDto)
        {
            var products = await _context.Products
                .Where(p => createOrderDto.ProductIds.Contains(p.Id))
                .ToListAsync();

            if (products.Count == 0) return BadRequest("Nie znaleziono żadnych pasujących produktów.");

            var order = new Order
            {
                CustomerName = createOrderDto.CustomerName,
                OrderDate = DateTime.UtcNow,
                Products = products // EF Core sam obsłuży tabelę łączącą
            };

            _context.Orders.Add(order);
            await _context.SaveChangesAsync();

            return Ok("Zamówienie złożone pomyślnie!");
        }
    }
}