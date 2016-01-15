using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bibliothèque.Controllers
{
    public class EmpruntController : Controller
    {
        // GET: Emprunt
        public ActionResult Index()
        {
            return View();
        }
    }
}