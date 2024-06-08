using koncert.Models.Entities;

namespace koncert.Models.Repositories;

public interface IShoppingCart
{
    void AddToCart(Concert concert);
    int RemoveFromCart(Concert concert);
    List<ShoppingCartItem> GetShoppingCartItems();
    void ClearCart();
    decimal GetShoppingCartTotal();
    List<ShoppingCartItem> ShoppingCartItems { get; set; }

}
