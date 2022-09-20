using Microsoft.AspNetCore.Mvc;
using Taskeroni.Models;

namespace Taskeroni.Controllers
{
    public class TaskController : Controller
    {
        public readonly ApplicationDbContext _db;

        public TaskController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {

            return View();
        }
    }
}
