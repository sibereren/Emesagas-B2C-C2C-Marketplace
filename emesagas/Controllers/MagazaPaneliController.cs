using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using emesagas.Models;
using Microsoft.AspNet.Identity;

namespace emesagas.Controllers
{
    public class MagazaPaneliController : Controller
    {
        // GET: MagazaPaneli
       
        
        public ActionResult Index()
        {
            var userId = User.Identity.GetUserId();
            User.Identity.
            return View();
        }
    }
}