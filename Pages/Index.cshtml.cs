using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using testsqlappcloud.Models;
using testsqlappcloud.Services;

namespace testsqlappcloud.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public List<Product> Products;
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            ProductService productService = new ProductService();

            Products = productService.GetProducts();
        }

        public void OnGet()
        {

        }
    }
}