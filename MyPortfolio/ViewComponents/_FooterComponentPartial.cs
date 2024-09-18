using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
    public class _FooterComponentPartial : ViewComponent
    {
        MyPortfolioContext dbContext = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = dbContext.SocialMedias.ToList();
            return View(values);
        }
    }
}
