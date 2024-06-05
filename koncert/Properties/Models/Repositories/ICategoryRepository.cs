using koncert.Properties.Models.Entities;

namespace koncert.Properties.Models.Repositories
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; } //wszystkie kategorie jakie mamy
    }
}
