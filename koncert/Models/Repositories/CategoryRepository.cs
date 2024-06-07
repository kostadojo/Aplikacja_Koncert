using koncert.Models.Entities;

namespace koncert.Models.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly koncertDbContext _koncertDbContext;

        public CategoryRepository(koncertDbContext koncertDbContext)
        {
            _koncertDbContext = koncertDbContext;
        }
        public IEnumerable<Category> AllCategories 
            => _koncertDbContext.Categories
                .OrderBy(c => c.Name);
    }
}
