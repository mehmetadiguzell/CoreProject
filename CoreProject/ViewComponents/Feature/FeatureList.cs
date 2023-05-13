using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject.ViewComponents.Feature
{
    public class FeatureList : ViewComponent
    {
        private readonly FeatureManager featureManager = new(new EfFeatureDal());
        public IViewComponentResult Invoke()
        {
            var model = featureManager.TGetList();
            return View(model);
        }
    }
}
