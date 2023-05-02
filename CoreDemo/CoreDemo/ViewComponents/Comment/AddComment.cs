using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.ViewComponents.Comment
{
    public class AddComment : ViewComponent
    {
        public IViewComponentResult Invoke(int id)
        {
            ViewBag.id = id;
            return View();
        }
    }
}
