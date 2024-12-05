using AcodexWebSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcodexWebSite.Controllers
{
    public class ProjectController : Controller
    {
        private AcodexWeb_DbEntities db = new AcodexWeb_DbEntities();

        public ActionResult Index()
        {
            return View(db.TblProjects.ToList());
        }

        public ActionResult _PartialProject()
        {
            return PartialView("_PartialProject", db.TblProjects.ToList());
        }
    }
}