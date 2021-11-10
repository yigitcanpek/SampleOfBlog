using Project.MVCUI.AuthenticationClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.MVCUI.Controllers
{
    public class PanelController : Controller
    {
        // GET: Panel
        [AdminAuthentication]
        public ActionResult AdminPanel()
        {
            return View();
        }
    }
}