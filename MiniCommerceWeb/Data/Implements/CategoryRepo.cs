using MiniCommerceWeb.Data.Repository;
using MiniCommerceWeb.Models;

namespace MiniCommerceWeb.Data.Implements
{
    public class CategoryRepo : ICategory
    {
        private readonly ApplicationDbContext _dbContext;

        public CategoryRepo(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;   
        }
        public void AddCategory(Category category)
        {
            throw new NotImplementedException();
        }

        public void DeleteCategory(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Category> GetAllCategory()
        {
            return _dbContext.Categories.Where(a => a.RowStatus == 0).ToList();
        }

        public Category GetCategory(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateCategory(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
