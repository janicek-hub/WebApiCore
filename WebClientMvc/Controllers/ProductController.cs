using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebClientMvc.Models;

namespace WebClientMvc.Controllers
{
    public class ProductController : Controller
    {
        private string webApiUrl;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="configuration"></param>
        public ProductController(IConfiguration configuration)
        {
            webApiUrl = configuration.GetSection("WebApi")["Url"];
        }
        /// <summary>
        /// Get paginated list of products
        /// </summary>
        /// <param name="pageNumber"></param>
        /// <returns></returns>
        public async Task<IActionResult> Index(int? pageNumber)
        {
            ViewData["Title"] = "Products";
            int pageSize = 10;
            using (var httpClient = new HttpClient())
            {
                var webApi = new WebApi.WebApi(webApiUrl, httpClient);
                var result = await webApi.PaginationAsync(((pageNumber ?? 1) - 1) * pageSize, 10);
                var items = JsonConvert.DeserializeAnonymousType(JsonConvert.SerializeObject(result.Rows.Select(v => v)), new List<Product>());
                return View(new PaginatedList<Product>(items ?? new List<Product>(), result.RowCount, pageNumber ?? 1, pageSize));
            }            
        }

        public async Task<IActionResult> IndexAll()
        {
            ViewData["Title"] = "Products (all)";
            using (var httpClient = new HttpClient())
            {
                var webApi = new WebApi.WebApi(webApiUrl, httpClient);
                var result = await webApi.AllAsync();
                var items = JsonConvert.DeserializeAnonymousType(JsonConvert.SerializeObject(result.Select(v => v)), new List<Product>());
                return View(items);
            }
        }
    }
}
