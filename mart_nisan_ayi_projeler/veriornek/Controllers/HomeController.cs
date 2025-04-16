using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using veriornek.Models;

namespace veriornek.Controllers
{
    public class UrunController : Controller
    {
        private readonly ILogger<UrunController> _logger;

        public UrunController(ILogger<UrunController> logger)
        {
            _logger = logger;
        }

        // Ürünleri tutmak için liste oluşturduk
        private static List<Urun> urunler = new List<Urun>();

        // Ana sayfa - ürünleri listele
        public IActionResult Index()
        {
            return View(urunler);
        }

        // Ürün ekleme formu
        public IActionResult Ekle()
        {
            return View();
        }

        // Ürün ekleme işlemi (formdan gelen verilerle)
        [HttpPost]
        public IActionResult Ekle(Urun urun)
        {
            if (ModelState.IsValid)
            {
                urunler.Add(urun);
                return RedirectToAction(nameof(Index));
            }
            return View(urun);
        }

        // Ürün düzenleme formu
        public IActionResult Duzenle(int id)
        {
            var urun = urunler.Find(u => u.UrunId == id);
            if (urun == null)
            {
                return NotFound();
            }
            return View(urun);
        }

        // Ürün düzenleme işlemi
        [HttpPost]
        public IActionResult Duzenle(Urun urun)
        {
            if (ModelState.IsValid)
            {
                var mevcutUrun = urunler.Find(u => u.UrunId == urun.UrunId);
                if (mevcutUrun != null)
                {
                    mevcutUrun.UrunAdi = urun.UrunAdi;
                    mevcutUrun.Fiyat = urun.Fiyat;
                    mevcutUrun.StokAdedi = urun.StokAdedi;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(urun);
        }

        // Ürün detaylarını göster
        public IActionResult Detaylar(int id)
        {
            var urun = urunler.Find(u => u.UrunId == id);
            if (urun == null)
            {
                return NotFound();
            }
            return View(urun);
        }

        // Ürün silme onay sayfası
        public IActionResult Sil(int id)
        {
            var urun = urunler.Find(u => u.UrunId == id);
            if (urun == null)
            {
                return NotFound();
            }
            return View(urun);
        }

        // Ürünü silme işlemi
        [HttpPost, ActionName("Sil")]
        public IActionResult SilOnayla(int id)
        {
            var urun = urunler.Find(u => u.UrunId == id);
            if (urun != null)
            {
                urunler.Remove(urun);
            }
            return RedirectToAction(nameof(Index));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
