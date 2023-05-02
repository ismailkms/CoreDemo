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
    public class AdminNotificationController : Controller
    {
        NotificationManager nm = new NotificationManager(new EfNotificationRepository());
        public IActionResult Index()
        {
            var values = nm.GetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddNotification()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNotification(Notification p)
        {
            p.Status = true;
            p.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            nm.TAdd(p);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteNotification(int id)
        {
            var value = nm.TGetById(id);
            nm.TDelete(value);
            return RedirectToAction("Index");
        }
    }
}
