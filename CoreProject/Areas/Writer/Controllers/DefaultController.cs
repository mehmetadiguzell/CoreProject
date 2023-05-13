using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Route("Writer/[controller]/[action]")]
    public class DefaultController : Controller
    {
        private readonly AnnouncementManager _announcementManager = new AnnouncementManager(new EfAnnouncementDal());

        public IActionResult Index()
        {
            var model = _announcementManager.TGetList();
            return View(model);
        }

        public IActionResult AnnouncementDetails(int id = 0)
        {
            var model = _announcementManager.TGetById(id);
            return View(model);
        }
    }
}


