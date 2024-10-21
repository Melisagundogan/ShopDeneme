using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Models;
using shopapp.business.Abstract;
using shopapp.entity;


namespace shopapp.webui.Controllers
{
    public class ShopController : Controller
    {
        private IProductService _productService;
        public ShopController(IProductService productService)
        {
            this._productService = productService;
        }

        public IActionResult List()
        {
            var productViewModel = new ProductListViewModel()
            {
                Products = _productService.GetAll()
            };

            return View(productViewModel);
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Product product = _productService.GetProductDetails((int)id);

            if (product == null)
            {
                return NotFound();
            }

            return View(new ProductDetailModel // Corrected line
            {
                Product = product,
                Categories = product.ProductCategories.Select(i => i.Category).ToList()
            });
        }

    }
}