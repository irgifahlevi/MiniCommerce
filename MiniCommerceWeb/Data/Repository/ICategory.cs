using MiniCommerceWeb.Models;

namespace MiniCommerceWeb.Data.Repository
{
    public interface ICategory
    {
        IEnumerable<Category> GetAllCategory();
        Category GetCategory(int id);
        void AddCategory(Category category);
        void UpdateCategory(Category category);
        void DeleteCategory(int id);
    }
}
