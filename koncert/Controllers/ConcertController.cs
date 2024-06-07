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

        public IActionResult Details(int id)
        {
            var concert = _concertRepository.GetConcertById(id);
            if (concert == null)
            {
                return NotFound();
            }
            return View(concert);
        }
    }
}
