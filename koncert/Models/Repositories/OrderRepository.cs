using Microsoft.AspNetCore;
using koncert.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace koncert.Models.Repositories;

public class OrderRepository : IOrderRepository
{
    private readonly koncertDbContext _koncertDbContext;
    private readonly IShoppingCart _shoppingCart;

    public OrderRepository(koncertDbContext koncertDbContext, IShoppingCart shoppingCart)
    {
        _koncertDbContext = koncertDbContext;
        _shoppingCart = shoppingCart;
    }

    public void CreateOrder(Order order)
    {
        order.OrderPlaced = DateTime.Now;
        order.OrderTotal = _shoppingCart.GetShoppingCartTotal();
        order.OrderDetails = new List<OrderDetail>();

        List<ShoppingCartItem>? shoppingCartItems = _shoppingCart.ShoppingCartItems;

        foreach(var shoppingCartItem in shoppingCartItems)
        {
            var orderDetail = new OrderDetail
            {
                Amount = shoppingCartItem.Amount,
                ConcertId = shoppingCartItem.concert.ConcertId,
                Price = shoppingCartItem.concert.Price
            };
            order.OrderDetails.Add(orderDetail);
        }

        _koncertDbContext.Orders.Add(order);
        _koncertDbContext.SaveChanges();
    }
}
