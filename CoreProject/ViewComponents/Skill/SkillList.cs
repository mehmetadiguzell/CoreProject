using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject.ViewComponents.Skill
{
    public class SkillList : ViewComponent
    {
        private readonly SkillManager skillManager = new(new EfSkillDal());
        public IViewComponentResult Invoke()
        {
            var model = skillManager.TGetList();
            return View(model);
        }
    }
}
