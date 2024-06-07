using koncert.Models.Entities;

namespace koncert.ViewModels;

public class HomeViewModel
{
    public IEnumerable<Concert> Concert { get; }
    public HomeViewModel(IEnumerable<Concert> concert) 
    {
        Concert = concert;
    }
}
