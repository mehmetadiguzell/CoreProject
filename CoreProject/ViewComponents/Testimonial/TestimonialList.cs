using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject.ViewComponents.Testimonial
{
    public class TestimonialList : ViewComponent
    {
        private readonly TestimonialManager testimonialManager = new(new EfTestimonialDal());
        public IViewComponentResult Invoke()
        {
            var model = testimonialManager.TGetList();
            return View(model);
        }
    }
}
