using koncert.Models.Entities;

namespace koncert.Models.Repositories
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; } //wszystkie kategorie jakie mamy
    }
}
