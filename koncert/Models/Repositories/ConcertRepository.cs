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

        public Concert? GetConcertById(int concertId)
            => _koncertDbContext.Concerts
            .Include(c => c.Category)
            .Include(c => c.Description.NoteOneDescription)
            .Include(c => c.Description.NoteTwoSell)
            .Include(c => c.Description.NoteThreeOther)
            .FirstOrDefault(c => c.ConcertId == concertId);

    }
}
