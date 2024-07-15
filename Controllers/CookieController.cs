using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTasks.Controllers
{
    public class CookieController : Controller
    {
        // SET : Cookie
        public ActionResult SetCookie()
        {
            HttpCookie cookie = new HttpCookie("UserCookie");
            cookie.Value = "Test Cookie";
            cookie.Expires = DateTime.Now.AddHours(1); // Expire in 1H
            Response.Cookies.Add(cookie);
            return Content("Cookie set sucssfly.");
        }

        // GET :Cookie
        public ActionResult GetCookie()
        {
            HttpCookie cookie = Request.Cookies["UserCookie"];
            if (cookie != null)
            {
                return Content($"Cookie Value: {cookie.Value}");
            }
            else
            {
                return Content("No cookie found.");
            }
        }

        //Receive query string
        public ActionResult ShowQueryString(string name)
        {
            return Content($"Query String Value: {name}");
        }
    }
}