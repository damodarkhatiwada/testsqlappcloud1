using testsqlappcloud.Models;

namespace testsqlappcloud.Services
{
    public interface IProductService
    {
        List<Product> GetProducts();
    }
}