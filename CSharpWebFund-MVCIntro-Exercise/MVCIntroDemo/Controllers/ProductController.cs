
namespace MVCIntroDemo.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Net.Http.Headers;
    using Newtonsoft.Json;
    using MVCIntroDemo.ViewModels.Product;
    using static Seeding.ProductData;
    using System.Text;

    public class ProductController : Controller
    {
        public IActionResult All(string keyword)
        {
            if (String.IsNullOrWhiteSpace(keyword))
            {
                return View(Products);
            }

            IEnumerable<ProductViewModel> productsAfterSearch = Products
                .Where(p => p.Name.ToLower().Contains(keyword.ToLower()))   
                .ToArray();

            return View(productsAfterSearch);   
        }

        [Route("/Product/Details/{Id?}")]
        public IActionResult ById(string id)
        {
            ProductViewModel? product = Products
                .FirstOrDefault(p => p.Id.ToString().Equals(id));
            if (product == null)
            {
                return RedirectToAction("All");
            }

            return View(product);
        }

        public IActionResult AllAsJson()
        {
            string jsonText = JsonConvert.SerializeObject(Products, Formatting.Indented);

            return Json(jsonText);

        }

        public IActionResult DownloadProductInfo()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var product in Products)
            {
                sb
                    .AppendLine($"Product with ID: {product.Id}")
                .AppendLine($"## Product Name {product.Name}")
                .AppendLine($"## Price: {product.Price:f2}$")
                .AppendLine($"-------------------------");
            }

            Response.Headers
                .Add(HeaderNames.ContentDisposition, "attachment;filename=product.txt");

            return File(Encoding.UTF8.GetBytes(sb.ToString()), "text/plain");
        }
    }
}
