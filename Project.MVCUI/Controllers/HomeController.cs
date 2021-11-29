using Project.BLL.DesignPatterns.Repository.ConcRep;
using Project.MVCUI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.MVCUI.Controllers
{
    public class HomeController : Controller
    {
        PostRepository _postrep;
        public HomeController()
        {
            _postrep = new PostRepository();
        }
        public ActionResult Index()
        {
            PostVM pvm = new PostVM()
            {
                Posts = _postrep.GetActives()
            };
            return View(pvm);
        }
   

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}