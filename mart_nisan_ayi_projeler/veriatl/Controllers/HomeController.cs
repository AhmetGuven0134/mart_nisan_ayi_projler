using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using veriatl.Models;

namespace veriatl.Controllers;

public class HomeController : Controller
{


    private readonly ogrenciContext context;
    public HomeController(ogrenciContext context)
    { this.context = context; }

    public IActionResult Index()
    {
        return View(context.ogrenciler.ToList());
    }
    public IActionResult Ekle()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Ekle(Ogrenci ogrenci)
    {

        if (!ModelState.IsValid)
        {
            return View(ogrenci);
        }

        context.ogrenciler.Add(ogrenci);
        context.SaveChanges();

        return RedirectToAction("Index");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
