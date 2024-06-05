using koncert.Models.Entities;

namespace koncert.Models.Repositories
{
    public class MockCategoryRepository : ICategoryRepository //implementacja interfejsu
    {
        public IEnumerable<Category> AllCategories => new List<Category>
        {
            new Category
            {
                CategoryId = 1,
                Name = "Rock",

            },
            new Category
            {
                CategoryId = 2,
                Name = "Pop"
            },
            new Category
            {
                CategoryId = 3,
                Name = "Dance"
            },
            new Category
            {
                CategoryId = 4,
                Name = "Jazz"
            },
            new Category
            {
                CategoryId = 5,
                Name = "Blues"
            }

        };
    }
}
