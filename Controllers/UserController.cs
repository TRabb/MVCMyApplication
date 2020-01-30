using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCMyApplication.Models;

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
        public ActionResult NewUser(string userFirst, string userLast, string userArtist, string userSong)
        {
            UserModel u = new UserModel()
            {
                FirstName = userFirst,
                LastName = userLast,
                FavoriteMusicArtist = userArtist,
                FavoriteSong = userSong
            };
            return View("ConfirmUser", u);
        }

        public ActionResult NewUser()
        {
            return View("NewUserForm");
        }

    }
}