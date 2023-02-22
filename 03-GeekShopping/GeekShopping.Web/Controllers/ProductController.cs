using GeekShopping.Web.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace GeekShopping.Web.Controllers
{
    public class ProductController : Controller
    {

        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService ?? throw new ArgumentNullException(nameof(productService));
        }

        public async Task<IActionResult> ProductIndex()
        {
            var products = await _productService.FindAllProduct();
            return View(products);
        }
    }
}
