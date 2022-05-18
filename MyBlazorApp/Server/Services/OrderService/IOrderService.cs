﻿namespace MyBlazorApp.Server.Services.OrderService
{
    public interface IOrderService
    {
        Task<List<Order>> GetOrdersAsync(CancellationToken cancellationToken);
        Task<Order> GetOrderAsync(int orderId, CancellationToken cancellationToken);
        Task<OrderPage> GetOrdersByStatusPageAsync(string orderStatusUrl, int page, CancellationToken cancellationToken);
        Task<OrderPage> GetOrdersByPageAsync(int page, CancellationToken cancellationToken);
        Task<int> AddOrderAsync(Order order, CancellationToken cancellationToken);
    }
}
