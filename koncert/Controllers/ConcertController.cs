using koncert.Models.Entities;
using koncert.Models.Repositories;
using koncert.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace koncert.Controllers
{
    public class ConcertController : Controller
    {
        private readonly IConcertRepository _concertRepository;
        private readonly ICategoryRepository _categoryRepository;
        
        public ConcertController(IConcertRepository concertRepository, ICategoryRepository categoryRepository) 
        { 
            _concertRepository = concertRepository;
            _categoryRepository = categoryRepository;   
        }

        public IActionResult List(string category)
        {
            IEnumerable<Concert> concerts;
            string? currentCategory;

            if (string.IsNullOrEmpty(category))
            {
                concerts = _concertRepository.AllConcerts.OrderBy(p => p.ConcertId);
                currentCategory = "Wszystkie";
            }
            else
            {
                concerts = _concertRepository.AllConcerts
                    .Where(p => p.Category.Name == category)
                    .OrderBy(p => p.ConcertId);

                currentCategory = _categoryRepository.AllCategories
                    .FirstOrDefault(c => c.Name == category)?.Name;
            }

            return View(new ConcertListViewModel(concerts, currentCategory));
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
