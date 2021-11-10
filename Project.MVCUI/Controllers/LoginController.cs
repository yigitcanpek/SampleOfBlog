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
    public class LoginController : Controller
    {
        AppUserRepository _appUserRep;

        public LoginController()
        {
            _appUserRep = new AppUserRepository();
            
        }
    
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(AppUser appUser)
        {
             AppUser ap = _appUserRep.FirstOrDefault(x => x.UserName == appUser.UserName && x.Password == appUser.Password);
           if (ap != null)
            {
                if (ap.UserRole == Project.ENTITIES.Models.Enums.UserRole.Admin)
                {
                    Session["admin"] = ap;
                    //Session["AdminName"] = ap.Name;
                    return RedirectToAction("AdminPanel", "Panel");
                }
                ViewBag.Message = "Yetkiniz Admin Değil";
                return View();
            }
            return View();
        }

    }
}