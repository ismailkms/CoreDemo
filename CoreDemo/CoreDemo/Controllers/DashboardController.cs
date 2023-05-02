using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            Context c = new Context();
            var userName = User.Identity.Name;
            var userId = c.Users.Where(x => x.UserName == userName).Select(y => y.Id).FirstOrDefault();

            ViewBag.BlogCount = c.Blogs.Count();
            ViewBag.WriterBlog = c.Blogs.Where(x => x.AppUserId == userId).Count();
            ViewBag.CategoryCount = c.Categories.Count();
            return View();
        }
    }
}
