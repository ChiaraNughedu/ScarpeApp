using Microsoft.AspNetCore.Mvc;
using ScarpeApp.Models;

namespace ScarpeApp.Controllers
{
    public class ArticoliController : Controller
    {
        public IActionResult Index()
        {
            var articoli = Magazzino.GetArticoli();
            return View(articoli);
        }

        public IActionResult Dettaglio(int id)
        {
            var articolo = Magazzino.GetArticoloById(id);
            if (articolo == null)
            {
                return NotFound();
            }
            return View(articolo);
        }
    }
}
