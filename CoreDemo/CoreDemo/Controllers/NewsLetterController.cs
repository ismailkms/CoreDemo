using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    [AllowAnonymous]
    public class NewsLetterController : Controller
    {
        NewsLetterManager nm = new NewsLetterManager(new EfNewsLetterRepository());

        [HttpPost]
        public IActionResult SubscribeMail(NewsLetter newsLetter,int? blogid)
        {
            newsLetter.Status = true;
            nm.AddNewsLetter(newsLetter);
            
            return blogid != 0 ? RedirectToAction("BlogReadAll", "Blog", new { id = blogid }) : RedirectToAction("Index", "About");
        }
    }
}
