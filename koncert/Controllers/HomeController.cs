using koncert.Models.Repositories;
using koncert.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace koncert.Controllers;

public class HomeController : Controller
{
    private readonly IConcertRepository _concertRepository;

    public HomeController(IConcertRepository concertRepository)
    {
        _concertRepository = concertRepository;
    }
    public IActionResult Index()
    {
        var concert = _concertRepository.AllConcerts; 
        var homeViewModel = new HomeViewModel(concert);
        return View(homeViewModel);
    }
}
