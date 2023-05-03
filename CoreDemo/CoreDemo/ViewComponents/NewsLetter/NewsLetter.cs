using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.ViewComponents.NewsLetter
{
    public class NewsLetter : ViewComponent
    {
        public IViewComponentResult Invoke(int id)
        {
            ViewBag.blogid = id;
            return View();
        }
    }
}
