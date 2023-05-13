using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject.ViewComponents.Experience
{
    public class ExperienceList : ViewComponent
    {
        private readonly ExperienceManager experienceManager = new(new EfExperienceDal());
        public IViewComponentResult Invoke()
        {
            var model = experienceManager.TGetList();
            return View(model);
        }
    }
}
