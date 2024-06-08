using Microsoft.AspNetCore.Mvc;

namespace koncert.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
