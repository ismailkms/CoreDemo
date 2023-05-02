using BusinessLayer.Concrete;
using CoreDemo.Areas.Admin.Models;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class WriterController : Controller
    {
        UserManager um = new UserManager(new EfUserRepository());

        private readonly Microsoft.AspNetCore.Identity.UserManager<AppUser> _userManager;
        public WriterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult WriterList()
        {
            var jsonWriters = JsonConvert.SerializeObject(um.GetList());
            return Json(jsonWriters);
        }

        public IActionResult GetWriterByID(int writerId)
        {
            var findWriter = um.TGetById(writerId);
            var jsonWriter = JsonConvert.SerializeObject(findWriter);
            return Json(jsonWriter);
        }

        [HttpPost]
        public async Task<IActionResult> AddWriter(AppUser p)
        {
            p.ImageUrl = "default.png";
            await _userManager.CreateAsync(p, p.PasswordHash);
            p.LockoutEnabled = true;
            p.NormalizedUserName = p.UserName.ToUpper().Replace("İ","I").Replace("Ö", "O").Replace("Ü", "U").Replace("Ç", "C").Replace("Ğ", "G").Replace("Ş", "S");
            p.NormalizedEmail = p.Email.ToUpper().Replace("İ", "I").Replace("Ö", "O").Replace("Ü", "U").Replace("Ç", "C").Replace("Ğ", "G").Replace("Ş", "S");
            um.TAdd(p);
            var jsonWriters = JsonConvert.SerializeObject(p);
            return Json(jsonWriters);
        }

        public IActionResult DeleteWriter(int id)
        {
            var writer = um.TGetById(id);
            um.TDelete(writer);
            var jsonWriter = JsonConvert.SerializeObject(writer);
            return Json(jsonWriter);
        }

        public IActionResult UpdateWriter(AppUser p)
        {
            var writer = um.TGetById(p.Id);
            writer.NameSurname = p.NameSurname;
            writer.Email = p.Email;
            writer.NormalizedEmail = p.Email.ToUpper().Replace("İ", "I").Replace("Ö", "O").Replace("Ü", "U").Replace("Ç", "C").Replace("Ğ", "G").Replace("Ş", "S");
            um.TUpdate(writer);
            var jsonWriter = JsonConvert.SerializeObject(writer);
            return Json(jsonWriter);
        }

    }
}
