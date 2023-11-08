using BookStore.Data;
using BookStore.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace BookStore.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly BookStoreDbContext _dbContext;

        public HomeController(ILogger<HomeController> logger, BookStoreDbContext bookStoreDbContext)
        {
            _logger = logger;
            _dbContext = bookStoreDbContext;
        }

        public IActionResult Index()
        {
            var books = _dbContext.Book.OrderByDescending(x => x.Title).Take(4).ToList();
            return View(books);
        }

        [HttpPost]
        public JsonResult AddToCart(int userId,int bookId)
        {
            _dbContext.CartItems.Add(new() { BookId = bookId, UserId = userId });
            var result = _dbContext.SaveChanges();
            return Json(result);
        }

        public IActionResult Cart()
        {
            var cartItems = _dbContext.CartItems.Where(x => x.UserId == 2).Include(i=>i.Book).ToList();
            return View(cartItems);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}