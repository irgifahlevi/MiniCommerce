
using Microsoft.AspNetCore.Mvc;
using MiniCommerceWeb.Data.Repository;

namespace MiniCommerceWeb.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ILogger<CategoryController> _logger;
        private readonly ICategory _category;

        public CategoryController(ILogger<CategoryController> logger, ICategory category)
        {
            _logger = logger;
            _category = category;
        }
        public IActionResult Index()
        {
            var data = _category.GetAllCategory();
            return View(data);
        }
    }
}
