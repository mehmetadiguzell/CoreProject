using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject.ViewComponents.Contact
{
    public class ContactDetail : ViewComponent
    {
        private readonly ContactManager contactManager = new(new EfContactDal());
        public IViewComponentResult Invoke()
        {
            var model = contactManager.TGetList();
            return View(model);
        }
    }
}
