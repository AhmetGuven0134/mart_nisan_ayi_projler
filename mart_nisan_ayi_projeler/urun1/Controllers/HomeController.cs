using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using urun1.Models;

namespace urun1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        private static List<Urun> urunler = new List<Urun>();

        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult UrunEkle()
        {
            return View();
        }

        // Ürün ekleme işlemini gerçekleştirir
        [HttpPost]
        public IActionResult UrunEkle(Urun urun)
        {
            if (ModelState.IsValid)
            {
                urunler.Add(urun);
                return RedirectToAction(nameof(UrunBasarili));
            }
            return View(urun);
        }

        // Ürün ekleme başarılı sayfası
        public IActionResult UrunBasarili()
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