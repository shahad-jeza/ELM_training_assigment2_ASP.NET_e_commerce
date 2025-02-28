using ECommerceApp.Data;
using ECommerceApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceApp.Controllers
{
    public class ProductController : Controller
    {
        // GET /Products
        [HttpGet("/Products")]
        public IActionResult Index()
        {
            return View(ProductData.Products);
        }
    }
}