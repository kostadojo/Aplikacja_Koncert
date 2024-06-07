using koncert.Models.Entities;

namespace koncert.ViewModels;

public class HomeViewModel
{
    public IEnumerable<Concert> ConcertOfTheMonth { get; }
    public HomeViewModel(IEnumerable<Concert> concertOfTheMonth) 
    {
        ConcertOfTheMonth = concertOfTheMonth;
    }
}
