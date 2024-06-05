using koncert.Models.Entities;

namespace koncert.ViewModels
{
    public class ConcertListViewModel
    {
        public IEnumerable<Concert> Concerts { get; set; }
        public string? Title { get; set; }
        public ConcertListViewModel(IEnumerable<Concert> concerts, string? title) 
        { 
            Concerts = concerts;
            Title = title;
        }
    }
}
