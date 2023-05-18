using Microsoft.AspNetCore.Mvc;
using TP4_Bis.Models;

namespace TP4_Bis.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewBag.listaPaises = Info.ListarPaises();
        return View();
    }

    public IActionResult DetallePais(int id)
    {
        ViewBag.Pais = Info.DetallePais(id);
        return View("DetallePais");
    }
}
