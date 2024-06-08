using koncert.Models.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace koncert.Components;

public class CategoryMenu : ViewComponent
{
    private readonly ICategoryRepository _categoryRepository;

    public CategoryMenu(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }
    
    public IViewComponentResult Invoke()
        => View(_categoryRepository.AllCategories.OrderBy(c => c.Name));
}
