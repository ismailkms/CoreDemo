using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using CoreDemo.Models;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class WriterController : Controller
    {
        UserManager um = new UserManager(new EfUserRepository());

        //Identity nin Manager Class ını kullandık
        private readonly UserManager<AppUser> _userManager;

        public WriterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var usermail = User.Identity.Name;
            ViewBag.v = usermail;
            Context c = new Context();
            var writerName = c.Writers.Where(x => x.Mail == usermail).Select(y => y.Name).FirstOrDefault();
            ViewBag.v2 = writerName;
            return View();
        }

        public IActionResult WriterProfile()
        {
            return View();
        }

        public IActionResult WriterMail()
        {
            return View();
        }

        public IActionResult Test()
        {
            return View();
        }

        public PartialViewResult WriterNavbarPartial()
        {
            return PartialView();
        }

        public PartialViewResult WriterFooterPartial()
        {
            return PartialView();
        }

        [HttpGet]
        public async Task<IActionResult> WriterEditProfile()
        {
            //Context c = new Context();
            //var userName = User.Identity.Name;
            //var userMail = c.Users.Where(x => x.UserName == userName).Select(y => y.Email).FirstOrDefault();

            //var writerID = c.Writers.Where(x => x.Mail == userMail).Select(y => y.ID).FirstOrDefault();
            //var writervalues = wm.TGetById(writerID);
            //return View(writervalues);

            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            return View(values);
        }

        [HttpPost]
        public async Task<IActionResult> WriterEditProfile(AppUser p)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            values.NameSurname = p.NameSurname;
            values.Email = p.Email;
            values.ImageUrl = p.ImageUrl;
            if(p.PasswordHash != null)
            {
                values.PasswordHash = _userManager.PasswordHasher.HashPassword(values, p.PasswordHash);
            }
            var result = await _userManager.UpdateAsync(values);
            return RedirectToAction("Index", "Dashboard");
        }

        [HttpGet]
        public IActionResult WriterAdd()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> WriterAdd(AppUser p, IFormFile image)
        {
            UserValidator ul = new UserValidator();
            ValidationResult results = ul.Validate(p);

            if (results.IsValid)
            {
                //Dosyaya Image ekleme
                if (image != null)
                {
                    var extension = Path.GetExtension(image.FileName);
                    var newimagename = Guid.NewGuid() + extension;
                    var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/WriterImageFiles/", newimagename);
                    var stream = new FileStream(location, FileMode.Create);
                    image.CopyTo(stream);
                    p.ImageUrl = newimagename;
                }
                var result = await _userManager.CreateAsync(p,p.PasswordHash);
                return RedirectToAction("Index", "Dashboard");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
    }
}
