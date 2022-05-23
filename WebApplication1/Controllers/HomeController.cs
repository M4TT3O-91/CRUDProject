using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private DBManager.DBReader _dbReader;
        private DBManager.DBPersister _dBPersister;
        private DBManager.DBModifier _dbModifier;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _dbReader = new DBManager.DBReader();
            _dBPersister = new DBManager.DBPersister();
            _dbModifier = new DBManager.DBModifier();   
        }

        public IActionResult IndexBrani()
        {

            return View(_dbReader.GetAllBrani());
        }
        public IActionResult IndexAlbum()
        {
            return View(_dbReader.GetAllAlbum());

        }
        public IActionResult IndexBand()
        {
            return View(_dbReader.GetAllBand());
        }        
        
        public IActionResult IndexArtista()
        {
            return View(_dbReader.GetAllArtista());
        }



        public IActionResult Insert()
        {
            return RedirectToAction("Index");
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