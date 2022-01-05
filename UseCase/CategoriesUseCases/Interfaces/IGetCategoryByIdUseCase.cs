using CoreBusiness;

namespace UseCases.CategoriesUseCases.Interfaces
{
    public interface IGetCategoryByIdUseCase
    {
        Category Execute(int categoryId);
    }
}
