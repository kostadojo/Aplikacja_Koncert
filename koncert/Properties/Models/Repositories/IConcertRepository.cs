using koncert.Properties.Models.Entities;

namespace koncert.Properties.Models.Repositories
{
    public interface IConcertRepository
    {
        IEnumerable<Concert> AllConcerts { get; } //wszystkie koncerty jakie mamy
        IEnumerable<Concert> ConcertOfTheMonth { get; } //wszystkie koncerty miesiąca
        IEnumerable<Concert> Recommended {  get; } //wszystkie polecane koncerty
        Concert? GetConcertById(int concertid);
    }
}
