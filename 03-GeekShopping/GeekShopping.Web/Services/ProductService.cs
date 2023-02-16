using GeekShopping.Web.Models;
using GeekShopping.Web.Services.IServices;
using GeekShopping.Web.Utils;

namespace GeekShopping.Web.Services
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _client;
        public const string BasePath = "api/v1/product";
        public Task<ProductModel> Create(ProductModel product)
        {
            throw new NotImplementedException();
        }

        public Task<ProductModel> CreateProduct(ProductModel product)
        {
            throw new NotImplementedException();
        }
        public Task<ProductModel> UpdateProduct(ProductModel product)
        {
            throw new NotImplementedException();
        }
        public Task<bool> DeleteProductById(long id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ProductModel>> FindAllProduct()
        {
            var response = await _client.GetAsync(BasePath);
            return await response.ReadContentAs<List<ProductModel>>();
        }

        public async Task<ProductModel> FindProductById(long id)
        {
            var response = await _client.GetAsync($"{BasePath}/{id}");
            return await response.ReadContentAs<ProductModel>();
        }

      
    }
}
