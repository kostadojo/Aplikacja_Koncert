using koncert.Models.Repositories;
using koncert.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace koncert.Controllers;

public class ShoppingCartController : Controller
{
    private readonly IConcertRepository _concertRepository;
    private readonly IShoppingCart _shoppingCart;

    public ShoppingCartController(IConcertRepository concertRepository, IShoppingCart shoppingCart)
    {
        _concertRepository = concertRepository;
        _shoppingCart = shoppingCart;
    }

    public ViewResult Index()
    {
        var items = _shoppingCart.GetShoppingCartItems();
        _shoppingCart.ShoppingCartItems = items;

        var shoppingCartViewModel = new ShoppingCartViewModel(_shoppingCart, _shoppingCart.GetShoppingCartTotal());

        return View(shoppingCartViewModel);
    }

    public RedirectToActionResult AddToShoppingCart(int concertId)
    {
        var selectedConcert = _concertRepository.AllConcerts.FirstOrDefault(p => p.ConcertId==concertId);
        if (selectedConcert != null)
        {
            _shoppingCart.AddToCart(selectedConcert);
        }
        return RedirectToAction("Index");
    }
    public RedirectToActionResult RemoveFromShoppingCart(int concertId)
    {
        var selectedConcert =_concertRepository.AllConcerts.FirstOrDefault(p=>p.ConcertId==concertId);
        if (selectedConcert != null)
        {
            _shoppingCart.RemoveFromCart(selectedConcert);
        }
        return RedirectToAction("Index");
    }

}
