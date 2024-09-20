using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.Controllers
{
	public class StatisticController : Controller
	{
		MyPortfolioContext context = new MyPortfolioContext();
		public IActionResult Index()
		{
			ViewBag.v1 = context.Skills.Count();
			ViewBag.v2 = context.Messages.Count();
			ViewBag.v3 = context.Messages.Where(x => x.IsRead == false).Count();
			ViewBag.v4 = context.Messages.Where(x => x.IsRead == true).Count();
			ViewBag.v5 = context.Experiences.Count(); //Toplam deneyim sayısı
			ViewBag.v6 = context.Blogs.Count(); //Toplam blog yazısı sayısı
			ViewBag.v7 = context.Portfolios.Count(); //Toplam proje sayısı
			ViewBag.v8 = context.Testimonials.Count(); //Toplam referans sayısı
			ViewBag.v9 = context.ToDoLists.Count(); //Toplam yapılacak sayısı
			ViewBag.v10 = context.SocialMedias.Count(); //Toplam sosyal medya sayısı

			return View();
		}
	}
}
