using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
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
    public class AdminAboutController : Controller
    {
        AboutManager ma = new AboutManager(new EfAboutRepository());
        public IActionResult Index()
        {
            var values = ma.GetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult UpdateAbout(int id)
        {
            var value = ma.TGetById(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateAbout(About p)
        {
            var value = ma.TGetById(p.ID);
            value.Details1 = p.Details1;
            value.Details2 = p.Details2;
            ma.TUpdate(value);
            return RedirectToAction("Index");
        }
    }
}
