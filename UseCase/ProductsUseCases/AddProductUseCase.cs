using CoreBusiness;
using UseCases.DataStorePluginInterfaces;
using UseCases.ProductsUseCases.Interfaces;

namespace UseCases.ProductsUseCases
{
    public class AddProductUseCase : IAddProductUseCase
    {
        private readonly IProductRepository productRepository;

        public AddProductUseCase(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public void Execute(Product product) => productRepository.AddProduct(product);
    }
}
