using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using _02.TODOList.Models;

namespace _02.TODOList.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (TaskDbContext db = new TaskDbContext())
            {
                List<Task> tasks = db.Tasks.ToList();

                return View(tasks);
            }
        }
    }
}