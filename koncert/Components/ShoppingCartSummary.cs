using koncert.Models.Repositories;
using koncert.ViewModels;
using Microsoft.AspNetCore.Mvc;


namespace koncert.Components;

public class ShoppingCartSummary : ViewComponent
{
    private readonly IShoppingCart _shoppingCart;
    private int _amount = 0;

    public ShoppingCartSummary(IShoppingCart shoppingCart)
    {
        _shoppingCart = shoppingCart;
    }

    public IViewComponentResult Invoke()
    {
        _shoppingCart.ShoppingCartItems = _shoppingCart.GetShoppingCartItems();

        foreach (var item in _shoppingCart.ShoppingCartItems)
        {
            _amount += item.Amount;
        }

        return View(new ShoppingCartSummaryViewModel(_shoppingCart,_amount));
    }

}
