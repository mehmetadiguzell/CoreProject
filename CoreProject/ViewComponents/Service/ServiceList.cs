using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject.ViewComponents.Service
{
    public class ServiceList : ViewComponent
    {
        private readonly ServiceManager serviceManager = new(new EfServiceDal());
        public IViewComponentResult Invoke()
        {
            var model = serviceManager.TGetList();
            return View(model);
        }
    }
}
