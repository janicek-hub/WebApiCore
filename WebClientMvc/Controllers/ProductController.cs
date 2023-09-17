using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net;
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
        /// <summary>
        /// Get all produts
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// Get product for edit
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            ViewData["Title"] = "Product edit";
            using (var httpClient = new HttpClient())
            {
                var webApi = new WebApi.WebApi(webApiUrl, httpClient);
                var result = await webApi.ProductsGETAsync(id);
                if (result == null)
                {
                    return NotFound();
                }
                var model = JsonConvert.DeserializeObject<Product>(JsonConvert.SerializeObject(result));
                ViewData["ProductName"] = model?.Name;
                return View(model);
            }
        }
        /// <summary>
        /// POST update product
        /// </summary>
        /// <param name="id"></param>
        /// <param name="product"></param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,ImgUri,Price,Description")] Product product)
        {
            if (id != product.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    using (var httpClient = new HttpClient())
                    {
                        var webApi = new WebApi.WebApi(webApiUrl, httpClient);
                        var result = await webApi.ProductsPATCHAsync(id, new WebApi.ProductPatchDTO
                        {
                            Description = product.Description                            
                        });
                        if (result == null)
                        {
                            return NotFound();
                        }
                    }
                }
                catch (Exception)
                {
                     throw;                 
                }
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }
        /// <summary>
        /// Get product detail
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Detail(int id)
        {
            ViewData["Title"] = "Product detail";
            using (var httpClient = new HttpClient())
            {
                var webApi = new WebApi.WebApi(webApiUrl, httpClient);
                var result = await webApi.ProductsGETAsync(id);
                if (result == null)
                {
                    return NotFound();
                }
                var model = JsonConvert.DeserializeObject<Product>(JsonConvert.SerializeObject(result));
                ViewData["ProductName"] = model?.Name;
                return View(model);
            }
        }
    }
}
