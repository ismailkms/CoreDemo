using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CoreDemo.Areas.Admin.ViewComponents.Statistic
{
    public class Statistic1 : ViewComponent
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.TotalBlog = bm.GetList().Count();
            ViewBag.TotalContact = c.Contacts.Count();
            ViewBag.TotalComment = c.Comments.Count();

            //Hava durumunu Api den çektik
            string apiKey = "eff3975440c346f34e042f0cfd29f028";
            string city = "istanbul";
            string connection = "https://api.openweathermap.org/data/2.5/weather?q="+city+"&mode=xml&lang=tr&units=metric&appid="+apiKey;
            XDocument document = XDocument.Load(connection);
            ViewBag.Temperature = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;

            return View();
        }
    }
}
