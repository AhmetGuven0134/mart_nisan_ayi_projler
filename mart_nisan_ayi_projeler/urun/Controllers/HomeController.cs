using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using kitap.Models;
using urun.Models;

namespace urun.Controllers;

public class HomeController : Controller
{
    private readonly KitapContext context;
    public HomeController(KitapContext context)
    {
        this.context = context;
    }

    public IActionResult Index()
    {
        return View(context.kitaplistesi.ToList());
    }
    public IActionResult Ekle()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Ekle(Kitaplar kitap)
    {
        if (!ModelState.IsValid)
        {
            return View(kitap);

        }
        context.kitaplistesi.Add(kitap);
        context.SaveChanges();
        return RedirectToAction("Index");
    }


    public IActionResult Duzenle()
    {
        return View();
    }
    public IActionResult Sil()
    {
        return View();
    }



    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
