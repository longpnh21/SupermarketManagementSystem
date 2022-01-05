using CoreBusiness;
using System.Collections.Generic;

namespace UseCases.ProductsUseCases.Interfaces
{
    public interface IViewProductsUseCase
    {
        IEnumerable<Product> Execute();
    }
}
