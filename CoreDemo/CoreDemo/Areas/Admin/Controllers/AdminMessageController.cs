using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class AdminMessageController : Controller
    {
        Message2Manager mm = new Message2Manager(new EfMessage2Repository());

        private readonly UserManager<AppUser> _userManager;
        public AdminMessageController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        public async Task<IActionResult> InBox()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var values = mm.GetInboxListByWriter(user.Id);
            return View(values);
        }

        public async Task<IActionResult> SendBox()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var values = mm.GetSendboxListByWriter(user.Id);
            return View(values);
        }

        [HttpGet]
        public async Task<IActionResult> SendMessage()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            //Dropdown
            UserManager um = new UserManager(new EfUserRepository());
            List<SelectListItem> recieverUsers = (from x in um.GetList()
                                                  where x.Id != user.Id
                                                  select new SelectListItem
                                                  {
                                                      Text = x.NameSurname.ToString(),
                                                      Value = x.Id.ToString()
                                                  }).ToList();
            //Burası Yukarıde Çektiğimiz Verileri Front-End Tarafına Taşıyoruz.
            ViewBag.RecieverUser = recieverUsers;

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SendMessage(Message2 p)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            p.SenderID = user.Id;
            p.Status = true;
            p.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            mm.TAdd(p);
            return RedirectToAction("InBox");
        }

        public IActionResult MessageDetails(int id)
        {
            var value = mm.TGetById(id);
            value.Status = false;
            mm.TUpdate(value);
            return View(value);
        }

        public IActionResult SenderMessageDetails(int id)
        {
            var value = mm.TGetById(id); ;
            return View(value);
        }
    }
}
