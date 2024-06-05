using koncert.Models.Repositories;
using koncert.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace koncert.Controllers
{
    public class ConcertController : Controller
    {
        private readonly IConcertRepository _concertRepository;
        
        public ConcertController(IConcertRepository concertRepository) 
        { 
            _concertRepository = concertRepository;
        }

        public IActionResult List()
        {
            var concertListViewModel = new ConcertListViewModel(
                _concertRepository.AllConcerts, 
                "Wydarzenia w Twoim mieście!");
            var result = _concertRepository.AllConcerts;
            return View(concertListViewModel);
        }
    }
}
