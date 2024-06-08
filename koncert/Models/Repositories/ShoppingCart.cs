using koncert.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace koncert.Models.Repositories;

public class ShoppingCart : IShoppingCart
{
    private readonly koncertDbContext _koncertDbContext;
    public string? ShoppingCartId { get; set; }
    public List<ShoppingCartItem> ShoppingCartItems { get; set; } = default!;
    private ShoppingCart(koncertDbContext koncertDbContext)
    {
        _koncertDbContext = koncertDbContext;
    }
    public static ShoppingCart GetCart(IServiceProvider services)
    {
        ISession? session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext?.Session;

        var context = services.GetService<koncertDbContext>()
            ?? throw new Exception("Error initializing");

        var cardId = session?.GetString("CartId") ?? Guid.NewGuid().ToString();

        session?.SetString("CartId", cardId);

        return new ShoppingCart(context) { ShoppingCartId = cardId };
    }
    public void AddToCart(Concert concert)
    {
        var shoppingCartItem = _koncertDbContext.ShoppingCartItems.SingleOrDefault
                    (s => s.concert.ConcertId == concert.ConcertId
                      && s.ShoppingCartId == ShoppingCartId
                    );

        if (shoppingCartItem == null)
        {
            shoppingCartItem = new ShoppingCartItem
            {
                ShoppingCartId = ShoppingCartId,
                concert = concert,
                Amount = 1
            };
            _koncertDbContext.ShoppingCartItems.Add(shoppingCartItem);
        }
        else
        {
            shoppingCartItem.Amount++;
        }
        _koncertDbContext.SaveChanges();
    }
    public int RemoveFromCart(Concert concert)
    {
        var shoppingCartItem = _koncertDbContext.ShoppingCartItems.SingleOrDefault(
            s => s.concert.ConcertId == concert.ConcertId
            && s.ShoppingCartId == ShoppingCartId);

        var localAmount = 0;

        if (shoppingCartItem != null)
        {
            if (shoppingCartItem.Amount > 1)
            {
                shoppingCartItem.Amount--;
                localAmount = shoppingCartItem.Amount;
            }
            else
            {
                _koncertDbContext.ShoppingCartItems.Remove(shoppingCartItem);
            }
        }
        _koncertDbContext.SaveChanges();

        return localAmount;
    }
    public List<ShoppingCartItem> GetShoppingCartItems()
    {
        return ShoppingCartItems ??= _koncertDbContext.ShoppingCartItems
       .Where(c => c.ShoppingCartId == ShoppingCartId)
       .Include(s => s.concert)
       .Include(s => s.concert.Description)
       .Include(s => s.concert.Description.NoteOneDescription)
       .ToList();
    }
    public void ClearCart()
    {
        var cartItems = _koncertDbContext.ShoppingCartItems
            .Where(cart => cart.ShoppingCartId == ShoppingCartId);

        _koncertDbContext.ShoppingCartItems.RemoveRange(cartItems);

        _koncertDbContext.SaveChanges();
    }
    public decimal GetShoppingCartTotal()
    {
        var total = _koncertDbContext.ShoppingCartItems
            .Where(c => c.ShoppingCartId == ShoppingCartId)
            .Select(c => c.concert.Price * c.Amount)
            .Sum();

        return total;
    }
}
