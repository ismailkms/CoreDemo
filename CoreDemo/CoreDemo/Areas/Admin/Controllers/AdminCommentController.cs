using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
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
    public class AdminCommentController : Controller
    {
        CommentManager cm = new CommentManager(new EfCommentRepository());
        public IActionResult Index()
        {
            var values = cm.GetCommentListWithBlog();
            return View(values);
        }

        public IActionResult DeleteComment(int id)
        {
            var value = cm.GetById(id);
            cm.CommentDelete(value);
            return RedirectToAction("Index");
        }
    }
}
