using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCMyApplication.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index(string type)
        {
            string t = HttpUtility.HtmlEncode(type);
            if (t == "m")
            {
                ViewBag.Title = "Manager Index";
                return View("ManagerIndex");
            }
            else
                return View();
        }

        public ContentResult Search(string name)
        {
            var input = HttpUtility.HtmlEncode(name);
            return Content(input);
        }
        [HttpPost]
        public ActionResult NewUser(string firstName, string lastName)
        {
            ViewBag.Message = "Name: " + firstName + " " + lastName;
            return View("ConfirmUser");
        }

        public ActionResult NewUser()
        {
            return View("NewUserForm");
        }
    }
}