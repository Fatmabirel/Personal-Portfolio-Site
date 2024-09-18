using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
    public class _StatisticComponentPartial : ViewComponent
    {
        MyPortfolioContext portfolioContext = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.TotalBlogs = portfolioContext.Blogs.Count();
            ViewBag.TotalReferences = portfolioContext.Testimonials.Count();
            ViewBag.TotalExperiences = portfolioContext.Experiences.Count();
            ViewBag.TotalProjects = portfolioContext.Portfolios.Count();

            return View();
        }
    }
}
