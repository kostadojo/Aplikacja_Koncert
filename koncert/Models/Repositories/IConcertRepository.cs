using koncert.Models.Entities;

namespace koncert.Models.Repositories
{
    public interface IConcertRepository
    {
        IEnumerable<Concert> AllConcerts { get; } //wszystkie koncerty jakie mamy
        Concert? GetConcertById(int concertid);
    }
}
