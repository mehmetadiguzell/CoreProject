using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject.ViewComponents.Portfolio
{
    public class PortfolioList : ViewComponent
    {
        private readonly PortfolioManager portfolioManager = new(new EfPortfolioDal());
        public IViewComponentResult Invoke()
        {
            var model = portfolioManager.TGetList();
            return View(model);
        }
    }
}
