using koncert.Models.Entities;
using koncert.Models.Repositories;

namespace koncert.ViewModels;

public class ShoppingCartViewModel
{
    public ShoppingCartViewModel(IShoppingCart shoppingCart, decimal shoppingCartTotal)
    {
        ShoppingCart = shoppingCart;
        ShoppingCartTotal = shoppingCartTotal;
    }
    public IShoppingCart ShoppingCart { get; }
    public decimal ShoppingCartTotal { get; }
}
