using AcodexWebSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcodexWebSite.Controllers
{
    public class RoadMapsController : Controller
    {
        private AcodexWeb_DbEntities db = new AcodexWeb_DbEntities();

        public ActionResult Index()
        {
            return View(db.TblRoadMaps.ToList());
        }

        public ActionResult Details(int id)
        {
            return View(db.TblRoadMaps.Where(x => x.Id == id).ToList());
        }

        public ActionResult Image(int id)
        {
            return View(db.TblRoadMaps.Where(x => x.Id == id).ToList());
        }

        public ActionResult _PartialViewSource(bool isLimited = false)
        {
            var roadMaps = isLimited ? db.TblRoadMaps.Take(10).ToList() : db.TblRoadMaps.ToList();
            return PartialView("_PartialViewSource", roadMaps);
        }

    }
}