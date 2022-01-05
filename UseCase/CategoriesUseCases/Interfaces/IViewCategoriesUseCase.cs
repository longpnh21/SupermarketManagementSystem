using CoreBusiness;
using System.Collections.Generic;

namespace UseCases.CategoriesUseCases.Interfaces
{
    public interface IViewCategoriesUseCase
    {
        IEnumerable<Category> Execute();
    }
}