using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PackageableMVCAreaPOC.Areas.Area51.Controllers
{
    public class AlienController : Controller
    {
        // GET: Area51/Alien
        public ActionResult Index()
        {
            return View(new [] {"gazoo", "kang", "kodos"});
        }
    }
}