using CoreBusiness;
using System.Collections.Generic;

namespace UseCases.DataStorePluginInterfaces
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetCategories();
        void AddCategory(Category category);
        void UpdateCategory(Category category);
        void DeleteCategory(int categoryId);
        Category GetCategoryById(int categoryId);
    }
}
