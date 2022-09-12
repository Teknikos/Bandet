using Bandet.Models;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.Serialization.Json;

namespace Bandet.Controllers
{
    public class BandsController : Controller
    {
        DataService dataService;
        public BandsController()
        {
            dataService = new DataService();
        }
        [HttpGet("")]
        [HttpGet("index")]
        public IActionResult Bands()
        {
            Band[] allBands = dataService.GetAllBands();
            return View(allBands);
        }

        [HttpGet("band/{id}")]
        public IActionResult BandDetails(int id)
        {
            var band = dataService.GetBandById(id);
            return View(band);
        }
    }
}
