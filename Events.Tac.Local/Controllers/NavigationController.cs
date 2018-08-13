using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TAC.Sitecore.Abstractions.Interfaces;
using TAC.Sitecore.Abstractions.SitecoreImplementation;

namespace Events.Tac.Local.Controllers
{
    public class NavigationController : Controller
    {
        // GET: Navigation
        public ActionResult Index()
        {
            return View();
        }
    }
}