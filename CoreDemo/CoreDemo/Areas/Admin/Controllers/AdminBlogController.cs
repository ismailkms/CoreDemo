using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class AdminBlogController : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        public IActionResult Index()
        {
            var values = bm.GetBlogListWithCategory();
            return View(values);
        }

        public IActionResult MakePassive(int id)
        {
            var value = bm.TGetById(id);
            value.Status = false;
            bm.TUpdate(value);
            return RedirectToAction("Index");
        }

        public IActionResult MakeActive(int id)
        {
            var value = bm.TGetById(id);
            value.Status = true;
            bm.TUpdate(value);
            return RedirectToAction("Index");
        }
    }
}
