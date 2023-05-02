using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.ViewComponents.Blog
{
    public class WriterLastBlog : ViewComponent
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());

        public IViewComponentResult Invoke(int id)
        {
            var userId = bm.GetBlogById(id).Where(y => y.Status == true).Select(x => x.AppUserId).FirstOrDefault();
            var values = bm.GetBlogListByWriter(userId);
            return View(values);
        }
    }
}
