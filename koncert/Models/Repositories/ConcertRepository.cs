using koncert.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace koncert.Models.Repositories
{
    public class ConcertRepository : IConcertRepository
    {
        private readonly koncertDbContext _koncertDbContext;

        public ConcertRepository(koncertDbContext koncertDbContext)
        {
            _koncertDbContext = koncertDbContext;
        }

        public IEnumerable<Concert> AllConcerts 
            => _koncertDbContext.Concerts
            .Include(c => c.Category)
            .Include(c => c.Description);

        public IEnumerable<Concert> ConcertOfTheMonth 
            => _koncertDbContext.Concerts
            .Include(c => c.Category)
            .Include(c => c.Description)
            .Include(c => c.ConcertContent)
            .Where(c => c.IsConcertOfTheMonth);
        public IEnumerable<Concert> Recommended
            => _koncertDbContext.Concerts
            .Include(c => c.Category)
            .Include(c => c.Description)
            .Include(c => c.ConcertContent)
            .Where(c => c.IsRecommended);
        public Concert? GetConcertById(int concertId)
            => _koncertDbContext.Concerts
            .Include(c => c.Category)
            .Include(c => c.Description.NoteOneDescription)
            .Include(c => c.Description.NoteTwoSell)
            .Include(c => c.Description.NoteThreeOther)
            .Include(c => c.ConcertContent).ThenInclude(c => c.chapters!).ThenInclude(c => c.Places)
            .Include(c => c.Faq)
            .Include(c => c.Announcements)
            .FirstOrDefault(c => c.ConcertId == concertId);

    }
}
