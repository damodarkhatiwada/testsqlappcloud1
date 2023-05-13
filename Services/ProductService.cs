
using System.Data.SqlClient;
using System.Text.Json;
using testsqlappcloud.Models;

namespace testsqlappcloud.Services
{
    public class ProductService : IProductService
    {

        private static string db_source = "testsqlserver-db.database.windows.net";
        private static string db_user = "cloudadmin";
        private static string db_password = "Applic@t!0n@123";
        private static string db_database = "testsqldb";

        private readonly IConfiguration _configuration;
        public ProductService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        private SqlConnection GetConnection()
        {
            //var _builder = new SqlConnectionStringBuilder();
            //_builder.DataSource = db_source;
            //_builder.UserID = db_user;
            //_builder.Password = db_password;
            //_builder.InitialCatalog = db_database;
            //_builder.ConnectTimeout = 60;
            //return new SqlConnection(_builder.ConnectionString);

            return new SqlConnection(_configuration["SQLConnection"]);
        }
        public async Task<List<Product>> GetProducts()
        {
            string fuctionfUrl = "https://functestda.azurewebsites.net/api/GetProducts?code=-X0BqsE8nEkUVkGdc138UylCTpKyfoCdPEvKez_uYhrDAzFuyq5Qlg==";
            using HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(fuctionfUrl);
            string content = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<List<Product>>(content);           


        }




    }
}
