using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.MVCUI.AuthenticationClasses
{
    public class AdminAuthentication:AuthorizeAttribute
    {
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            if (httpContext.Session["admin"] != null)
            {
                return true;
            }
            else if (httpContext.Session["admin"]==null)
            {
                httpContext.Response.Redirect("/Home/Index");
                return false;
            }
            return false;
        }
    }
}