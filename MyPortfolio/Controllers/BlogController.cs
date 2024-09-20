using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;
using MyPortfolio.DAL.Entities;

namespace MyPortfolio.Controllers
{
	public class BlogController : Controller
	{
		MyPortfolioContext context = new MyPortfolioContext();
		public IActionResult BlogList()
		{
			var values = context.Blogs.ToList();
			return View(values);
		}

		[HttpGet]
		public IActionResult CreateBlog()
		{
			return View();
		}

		[HttpPost]
		public IActionResult CreateBlog(Blog experience)
		{
			context.Blogs.Add(experience);
			context.SaveChanges();
			return RedirectToAction("BlogList");
		}

		public IActionResult DeleteBlog(int id)
		{
			var value = context.Blogs.Find(id);
			context.Blogs.Remove(value);
			context.SaveChanges();
			return RedirectToAction("BlogList");
		}

		[HttpGet]
		public IActionResult UpdateBlog(int id)
		{
			var value = context.Blogs.Find(id);
			return View(value);
		}

		[HttpPost]
		public IActionResult UpdateBlog(Blog experience)
		{
			context.Blogs.Update(experience);
			context.SaveChanges();
			return RedirectToAction("BlogList");
		}
	}
}
