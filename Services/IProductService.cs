using testsqlappcloud.Models;

namespace testsqlappcloud.Services
{
    public interface IProductService
    {
        Task<List<Product>> GetProducts();
    }
}