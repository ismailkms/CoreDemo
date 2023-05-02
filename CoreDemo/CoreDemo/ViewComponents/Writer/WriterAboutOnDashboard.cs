using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.ViewComponents.Writer
{
    public class WriterAboutOnDashboard : ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;

        public WriterAboutOnDashboard(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            //Claims ve Identy ile login yapılınca her ikisindede aynı şekilde veri çekiliyor
            //Claims için yaptığımızda mail i, ıdentity için yaptığımızda username i çeker
            //var username = User.Identity.Name;

            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            return View(values);
        }
    }
}
