using Project.BLL.DesignPatterns.Repository.ConcRep;
using Project.ENTITIES.Models.Entities;
using Project.MVCUI.AuthenticationClasses;
using Project.MVCUI.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.MVCUI.Controllers
{
    public class PanelController : Controller
    {
        PostTagRepository _postTagRep;
        PostRepository _postRep;
        CategoryRepository _categoryRep;
        TagRepository _tagRep;
        public PanelController()
        {
            _postTagRep = new PostTagRepository();
            _tagRep = new TagRepository();
            _categoryRep = new CategoryRepository();
            _postRep = new PostRepository();
        }

        [AdminAuthentication]
        public ActionResult AdminPanel()
        {

            PostVM pvm = new PostVM()
            {
                Posts = _postRep.GetActives(),
                Categories = _categoryRep.GetActives()
            };
            
            return View(pvm);
        }

        [AdminAuthentication]
        public ActionResult AddCategory()
        {
            
            return View();
            
        }

        [HttpPost]
        [AdminAuthentication]
        public ActionResult AddCategory(Category categoryInstance)
        {
            _categoryRep.Add(categoryInstance);
            return RedirectToAction("AdminPanel");
        }

        [AdminAuthentication]
        public ActionResult AddTag()
        {
            return View();
        }
           
         [AdminAuthentication]
         [HttpPost]
         public ActionResult AddTag(Tag tagInstance)
        {
            _tagRep.Add(tagInstance);
            return RedirectToAction("AdminPanel");
        }

        [AdminAuthentication]
        public ActionResult GoToPost(int id)
        {
            PostVM pvm = new PostVM()
            {
                PostInstance = _postRep.Find(id)
                
            };
            return View(pvm);
        }
        [AdminAuthentication]
        public ActionResult AddPost()
        {
            PostVM pvm = new PostVM()
            {
                Categories = _categoryRep.GetActives()
                

            };
            return View(pvm);
        }

        [HttpPost]
        [AdminAuthentication]
        public ActionResult Addpost(Post PostInstance)
        {
            /*Image Uploader can be converted to function */
            if (Request.Files.Count>0)
            {
                string filename = Path.GetFileName(Request.Files[0].FileName);
                string extension = Path.GetExtension(Request.Files[0].FileName);
                string path = "~/Images/" + filename + extension;
                Request.Files[0].SaveAs(Server.MapPath(path));
                PostInstance.ImagePath = "/Images/" + filename + extension;
            }

            
            _postRep.Add(PostInstance);


            return RedirectToAction("AdminPanel");
        }
        [AdminAuthentication]
        public ActionResult AddPostTag(int id)
        {
            PostTagVM ptm = new PostTagVM()
            {
                Tags = _tagRep.GetActives(),
                postInstance = _postRep.Find(id)
            };
            
            return View(ptm);
        }
        [AdminAuthentication]
        [HttpPost]
        public ActionResult AddPostTag(Post post,FormCollection collection)
        {
            foreach (string element in collection.GetValues("checkbox"))
            {
                int id = Convert.ToInt32(element);
                PostTag pt = new PostTag();
                pt.PostID = post.ID;
                pt.TagID = id;
                _postTagRep.Add(pt);
            }

            
            return RedirectToAction("AddPostTag");
        }

        [AdminAuthentication]
        public ActionResult DeletePost (int id)
        {
            _postRep.Destroy(_postRep.Find(id));
            return RedirectToAction("AdminPanel");
        }

       public ActionResult UpdatePost(int id )
        {
            PostVM pvm = new PostVM()
            {
                PostInstance = _postRep.Find(id)
            };
            return View(pvm);
        }
        
        [AdminAuthentication]
        [HttpPost]
        public ActionResult UpdatePost (Post postInstance)
        {
            _postRep.Update(postInstance);
            return RedirectToAction("AdminPanel");
        }

        

    }
}





