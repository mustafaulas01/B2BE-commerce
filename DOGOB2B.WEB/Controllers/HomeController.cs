using DOGOB2B.BUSINESS.Abstract;
using DOGOB2B.WEB.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DOGOB2B.WEB.Controllers
{
    public class HomeController : Controller
    {

        private readonly IProductService _productService;
        public HomeController(IProductService service)
        {
            _productService = service;
        }

        public async Task< IActionResult> Index()
        {
            var products = await _productService.GetAll();

            if (products.Count < 1)
                return NotFound();
            return View(products.OrderByDescending(a=>a.Id).Take(3));
        }

        public async Task<IActionResult> Shop()
        {
            var products = await _productService.GetAll();

            if (products.Count < 1)
                return NotFound();
            return View(products);
        }

        public async Task<IActionResult> ProductDetail(int Id)
        {
            var product=await _productService.Get(a=>a.Id == Id); 

            if(product == null)
                    return NotFound();

            return View(product);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}