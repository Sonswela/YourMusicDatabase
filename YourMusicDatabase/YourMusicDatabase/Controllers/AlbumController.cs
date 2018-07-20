using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YourMusicDatabase.Models.Album;

namespace YourMusicDatabase.Controllers
{
    public class AlbumController : Controller
    {
        // GET: Album
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        } 

        [HttpPost]
        public ActionResult AlbumCreate(AlbumModel model)
        {
            return RedirectToAction("Index");
        }
    }
}