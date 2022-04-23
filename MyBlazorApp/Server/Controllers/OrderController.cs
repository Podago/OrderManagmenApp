﻿using Microsoft.AspNetCore.Mvc;

namespace MyBlazorApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly DataContext _context;

        public OrderController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Order>>>> GetOrders()
        {
            var orders = await _context.Orders.ToListAsync();
            var response = new ServiceResponse<List<Order>>()
            {
                Data = orders
            };
            return Ok(response);
        }
    }
}
