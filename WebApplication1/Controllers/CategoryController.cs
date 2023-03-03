using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CategoryController : Controller
    {
        public readonly FMDBContext db;
        public CategoryController(FMDBContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Category> content = db.Categories.ToList();
            return View(content);
        }
        public IActionResult Create() {
            return View();
        }
    }
}
