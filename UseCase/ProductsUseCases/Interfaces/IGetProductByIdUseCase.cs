using CoreBusiness;

namespace UseCases.ProductsUseCases.Interfaces
{
    public interface IGetProductByIdUseCase
    {
        Product Execute(int productId);
    }
}
