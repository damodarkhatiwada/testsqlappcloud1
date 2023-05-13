using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using testsqlappcloud.Models;
using testsqlappcloud.Services;

namespace testsqlappcloud.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IProductService _productService;

        public List<Product> Products;
        public IndexModel(ILogger<IndexModel> logger, IProductService productService)
        {
            _logger = logger;
            _productService = productService;

            Products = _productService.GetProducts().GetAwaiter().GetResult();
        }

        public void OnGet()
        {

        }
    }
}