using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace MVC.ViewComponents.Category
{
    public class CategoryList : ViewComponent
    {
        private readonly ICategoryService _categoryService;

        public CategoryList(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IViewComponentResult Invoke(int id)
        {
            var categories = _categoryService.GetAllCategories();
            return View(categories);
        }
    }
}
