using Project.BLL.DesignPatterns.Repository.ConcRep;
using Project.ENTITIES.Models.Entities;
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
        PostTagRepository _postTagRep;
        TagRepository _tagRep;
        public HomeController()
        {
            _postRep = new PostRepository();
            _categoryRep = new CategoryRepository();
            _postTagRep = new PostTagRepository();
            _tagRep = new TagRepository();
        }
        public ActionResult Index(string searching)
        {
           
            PostVM pvm = new PostVM()
            {
                Posts = _postRep.Where(x=> x.Title.Contains(searching) || searching == null && x.Status != ENTITIES.Models.Enums.DataStatus.Deleted),
                Tags = _tagRep.GetActives(),
                Categories = _categoryRep.GetActives(),
            };

            return View(pvm);
        }
        

        public ActionResult CategoryList(int id)
        {
            
            CategoryVM cvm = new CategoryVM()
            {
                CategoryInstance = _categoryRep.Find(id),
                Posts = _postRep.Where(x=> x.CategoryID == id ),
                Categories = _categoryRep.GetActives(),
                Tags = _tagRep.GetActives()
            };
            return View(cvm);
        }

        public ActionResult GoToPostIndex(int id)
        {
           
            PostVM pvm = new PostVM()
            {
                PostInstance = _postRep.Find(id)
            };
            return View(pvm);
        }
        public ActionResult Taglist(int id)
        {
            
            TagVM tvm = new TagVM()
            {
                TagInstance = _tagRep.Find(id),
                Posts = _postRep.GetActives(),
                Categories = _categoryRep.GetActives(),
                Tags = _tagRep.GetActives()
            };
            
            return View(tvm);
        }
      
    }
}