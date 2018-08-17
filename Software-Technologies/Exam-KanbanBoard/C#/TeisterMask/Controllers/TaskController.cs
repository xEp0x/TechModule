using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using TeisterMask.Models;

namespace TeisterMask.Controllers
{
    [ValidateInput(false)]
	public class TaskController : Controller
	{
	    [HttpGet]
        [Route("")]
	    public ActionResult Index()
	    {
	        using (TeisterMaskDbContext db = new TeisterMaskDbContext())
	        {
	            List<Task> tasks = db.Tasks.ToList();

	            return this.View(tasks);
	        }
        }

        [HttpGet]
        [Route("create")]
        public ActionResult Create()
		{
		    return View();
        }

		[HttpPost]
		[Route("create")]
        [ValidateAntiForgeryToken]
		public ActionResult Create(Task task)
		{
		    if (task == null)
		    {
		        return RedirectToAction("Index");
		    }

		    if (string.IsNullOrWhiteSpace(task.Title) || string.IsNullOrWhiteSpace(task.Status))
		    {
		        return RedirectToAction("Index");
		    }

		    using (TeisterMaskDbContext db = new TeisterMaskDbContext())
		    {
		        db.Tasks.Add(task);
		        db.SaveChanges();

		        return RedirectToAction("Index");
		    }
        }

		[HttpGet]
		[Route("edit/{id}")]
        public ActionResult Edit(int id)
		{
            using (TeisterMaskDbContext db = new TeisterMaskDbContext())
            {
                var task = db.Tasks.Find(id);

                if (task == null)
                {
                    return RedirectToAction("Index");
                }

                return View(task);
            }
        }

		[HttpPost]
		[Route("edit/{id}")]
        [ValidateAntiForgeryToken]
		public ActionResult EditConfirm(int id, Task task)
		{
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }

            using (TeisterMaskDbContext db = new TeisterMaskDbContext())
            {
                var taskFromDb = db.Tasks.Find(task.Id);
                if (taskFromDb != null)
                {
                    taskFromDb.Title = task.Title;
                    taskFromDb.Status = task.Status;
                    db.SaveChanges();
                }

                return RedirectToAction("Index");
            }
        }
	}
}