using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HSE.KPO.Domain.Models;
using HSE.KPO.MVC.Models;

namespace HSE.KPO.MVC.Controllers;

public class HomeController : Controller
{
    private static int _carId = 0;

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult CreateCar()
    {
        var car = new Car(++_carId);
        return View(HSE.KPO.MVC.Models.CarViewModel.From(car));
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
    }
}