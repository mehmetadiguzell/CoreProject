using Business.Concrete;
using DataAccess.EntityFramework;
using Entity.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CoreProject.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {
        private readonly MessageManager messageManager = new(new EfMessageDal());
        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult SendMessage()
        {
            return PartialView();
        }
        [HttpPost]
        public IActionResult SendMessage(Message message)
        {
            message.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            message.Status = true;
            messageManager.TAdd(message);
            return RedirectToAction("Index");
        }
    }
}
