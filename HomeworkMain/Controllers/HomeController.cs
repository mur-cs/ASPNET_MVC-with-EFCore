using HomeworkMain.Data;
using HomeworkMain.Models;
using HomeworkMain.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HomeworkMain.Controllers
{
	public class HomeController : Controller
	{
		private ApplicationContext _context;
		public HomeController(ApplicationContext context)
		{
			_context = context;
		}
		public IActionResult Index()
		{
			return View(_context.books.ToList());
		}
		public IActionResult Details(int? id)
		{
			var book = _context.books.FirstOrDefault(x => x.Id == id);
			var reviews = _context.reviews.Where(x=>x.BookId==book.Id).ToList();

            var viewModel = new BookViewModel
            {
                Book = book,
                Reviews = reviews
            };

            return View(viewModel);
		}

		[HttpGet]
		public IActionResult AddReview(int? id)
		{
			var book = _context.books.FirstOrDefault(x => x.Id == id);
			var reviews = _context.reviews.Where(x => x.BookId==book.Id).ToList();

			var viewModel = new BookViewModel
			{
				Book = book,
				Reviews = reviews
			};
			return View(viewModel);
		}

		[HttpPost]
		public IActionResult AddReview(ReviewViewModel? reviewViewModel)
		{
                _context.reviews.Add(new Review()
                {
                    BookId=reviewViewModel.BookId,
					Rating=reviewViewModel.Rating,
					Text=reviewViewModel.ReviewText
                });
				_context.SaveChanges();
			return RedirectToAction("Index");
		}
	}
}
