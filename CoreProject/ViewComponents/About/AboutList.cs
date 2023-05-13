using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject.ViewComponents.About
{
    public class AboutList : ViewComponent
    {
        private readonly AboutManager aboutManager = new(new EfAboutDal());
        public IViewComponentResult Invoke()
        {
            var model = aboutManager.TGetList();
            return View(model);
        }
    }
}
