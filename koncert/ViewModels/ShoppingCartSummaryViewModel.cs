
using koncert.Models.Repositories;

namespace koncert.ViewModels;

public class ShoppingCartSummaryViewModel
{
    public ShoppingCartSummaryViewModel(IShoppingCart shoppingCart, int amount)
    {
        ShoppingCart = shoppingCart;
        Amount = amount;
    }

    public IShoppingCart ShoppingCart { get; }
    public int Amount { get; set; }
}