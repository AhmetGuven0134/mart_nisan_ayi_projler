using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using webodev2.Models;

namespace webodev2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var urunler = new List<Urun>
            {
                new Urun { Id = 1, Ad = "Laptop", Aciklama = "16GB RAM, i7 İşlemci", Fiyat = 25000, Kategori = UrunKategorisi.Elektronik },
                new Urun { Id = 2, Ad = "Tişört", Aciklama = "Pamuklu, M beden", Fiyat = 150, Kategori = UrunKategorisi.Giyim },
                new Urun { Id = 3, Ad = "Defter", Aciklama = "Spiralli A4", Fiyat = 25, Kategori = UrunKategorisi.Kirtasiye }
            };

            return View(urunler);
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