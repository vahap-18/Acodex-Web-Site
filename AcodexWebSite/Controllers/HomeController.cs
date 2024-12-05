using AcodexWebSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcodexWebSite.Controllers
{
    public class HomeController : Controller
    {
        AcodexWeb_DbEntities db = new AcodexWeb_DbEntities();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Source()
        {
            return View();
        }
        public ActionResult _SourcePartialView(bool isLimited = false)
        {
            var sources = isLimited ? db.TblSource.Take(10).ToList() : db.TblSource.ToList();
            return PartialView("_SourcePartialView", sources);
        }

        public ActionResult Documention()
        {
            return View(db.TblDocumention.ToList());
        }

        public ActionResult _DocumentionPartialView(bool isLimited = false)
        {
            var documents = isLimited ? db.TblDocumention.Take(10).ToList() : db.TblDocumention.ToList();
            return PartialView("_DocumentionPartialView", documents);
        }

        public ActionResult SocialAccount() => View();

        public ActionResult Film()
        {
            return View(db.TblFilm.ToList());
        }

        public ActionResult _FilmPartialViewFilms(bool isLimited = false)
        {
            var films = isLimited ? db.TblFilm.Take(10).ToList() : db.TblFilm.ToList();
            return PartialView("_FilmPartialViewFilms", films);
        }

        public ActionResult Shop()
        {
            return View(db.TblShop.ToList());
        }
        public ActionResult _ShopPartialView(bool isLimited = false)
        {
            var shops = isLimited ? db.TblShop.Take(9).ToList() : db.TblShop.ToList();
            return PartialView("_ShopPartialView", shops);
        }
    }
}