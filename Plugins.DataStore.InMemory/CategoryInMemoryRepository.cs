using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.InMemory
{
    public class CategoryInMemoryRepository : ICategoryRepository
    {
        private IList<Category> categories;

        public CategoryInMemoryRepository()
        {
            categories = new List<Category>()
            {
                new Category{CategoryId = 1, Name = "Beverage", Description = "Beverage"},
                new Category{CategoryId = 2, Name = "Bakery", Description = "Bakery"},
                new Category{CategoryId = 3, Name = "Meat", Description =  "Meat"},
            };
        }

        public void AddCategory(Category category)
        {
            if (categories.Any(x => x.Name.Equals(category.Name, StringComparison.OrdinalIgnoreCase))) 
                return;

            if(categories.Count > 0)
            {
                var maxId = categories.Max(x => x.CategoryId);
                category.CategoryId = maxId + 1;
            }
            else
            {
                category.CategoryId = 1;
            }

            categories.Add(category);
        }

        public void UpdateCategory(Category category)
        {
            var categoryToUpdate = GetCategoryById(category.CategoryId);
            if (categoryToUpdate != null)
            {
                categoryToUpdate.Name = category.Name;
                categoryToUpdate.Description = category.Description;
            };
        }

        public IEnumerable<Category> GetCategories() => categories;

        public Category GetCategoryById(int categoryId) 
            => categories?.FirstOrDefault(x => x.CategoryId == categoryId);

        public void DeleteCategory(int categoryId) => categories?.Remove(GetCategoryById(categoryId));
    }
}
