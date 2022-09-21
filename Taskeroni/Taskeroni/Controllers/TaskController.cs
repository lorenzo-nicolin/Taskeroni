using Microsoft.AspNetCore.Mvc;
using System.Linq;
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

            var datadb = _db.Tasks.ToList();

            return View(datadb);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(NewTasks obj)
        {
            _db.Tasks.Add(obj);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
