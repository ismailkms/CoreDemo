using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Areas.Admin.ViewComponents.Statistic
{
    public class Statistic4 : ViewComponent
    {
        Context c = new Context();

        public IViewComponentResult Invoke()
        {
            ViewBag.AdminName = c.Admins.Where(x => x.ID == 1).Select(y => y.Name).FirstOrDefault();
            ViewBag.AdminImage = c.Admins.Where(x => x.ID == 1).Select(y => y.Image).FirstOrDefault();
            ViewBag.AdminShortDescription = c.Admins.Where(x => x.ID == 1).Select(y => y.ShortDescription).FirstOrDefault();
            return View();
        }
    }
}
