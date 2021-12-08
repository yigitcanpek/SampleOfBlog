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
        PostRepository _postRep;
        CategoryRepository _categoryRep;
        public HomeController()
        {
            _postRep = new PostRepository();
            _categoryRep = new CategoryRepository();
        }
        public ActionResult Index()
        {
            PostVM pvm = new PostVM()
            {
                Posts = _postRep.GetActives()
                
            };
            return View(pvm);
        }
   

        public ActionResult CategoryList(int id)
        {
            CategoryVM cvm = new CategoryVM()
            {
                CategoryInstance = _categoryRep.Find(id),
                Posts = _postRep.Where(x=> x.CategoryID == id)
            };
            return View(cvm);
        }
    }
}