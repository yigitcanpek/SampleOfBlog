using Project.BLL.DesignPatterns.Repository.ConcRep;
using Project.ENTITIES.Models.Entities;
using Project.MVCUI.AuthenticationClasses;
using Project.MVCUI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.MVCUI.Controllers
{
    public class PanelController : Controller
    {
        PostRepository _postRep;

        public PanelController()
        {
            _postRep = new PostRepository();
        }

        [AdminAuthentication]
        public ActionResult AdminPanel()
        {
            
            PostVM pvm = new PostVM()
            {
                Posts = _postRep.GetActives()
                
            };
            return View(pvm);
        }
        
        public ActionResult GoToPost(int id)
        {
            PostVM pvm = new PostVM()
            {
                PostInstance = _postRep.Find(id)
                
            };
            return View(pvm);
        }

        public ActionResult AddPost(Post PostInstance)
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult Addpost(Post PostInstance)
        {
            
            _postRep.Add(PostInstance);
            return RedirectToAction("AdminPanel");
        }

        public ActionResult DeletePost (int id)
        {
            _postRep.Destroy(_postRep.Find(id));
            return RedirectToAction("AdminPanel");
        }

        [HttpPost]
        public ActionResult UpdatePost (int id)
        {
            _postRep.Update(_postRep.Find(id));
            return RedirectToAction("AdminPanel");
        }
    }
}