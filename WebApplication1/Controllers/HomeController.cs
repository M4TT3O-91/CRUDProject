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
            return View();
        }

        [HttpPost]
        public IActionResult Insert(MyMusicViewModels music)
        {
            int idArtista = _dBPersister.InsertArtista(music.ArtistaViewModel);
            music.BandViewModel.Artista_ID = idArtista;
            _logger.LogInformation($"ID artista inserito: {idArtista}");

            int idBrano = _dBPersister.InsertBrano(music.BranoViewModel);
            _logger.LogInformation($"ID Brano inserito: {idBrano}");
            music.AlbumViewModel.Brano_ID = idBrano;

            int idBand = _dBPersister.InsertBand(music.BandViewModel);
            _logger.LogInformation($"ID Band inserito: {idBand}");
            music.AlbumViewModel.Band_ID = idBand;

            int idAlbum = _dBPersister.InsertAlbum(music.AlbumViewModel);
            _logger.LogInformation($"ID Album inserito: {idAlbum}");

            return RedirectToAction("IndexBrani");
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