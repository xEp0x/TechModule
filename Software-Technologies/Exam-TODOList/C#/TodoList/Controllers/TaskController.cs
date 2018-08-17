using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using TodoList.Models;

namespace TodoList.Controllers
{
        [ValidateInput(false)]
	public class TaskController : Controller
	{
	    [HttpGet]
        [Route("")]
	    public ActionResult Index()
	    {
	        using (TodoListDbContext db = new TodoListDbContext())
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

		    if (string.IsNullOrWhiteSpace(task.Title) || string.IsNullOrWhiteSpace(task.Comments))
		    {
		        return RedirectToAction("Index");
            }

		    using (TodoListDbContext db = new TodoListDbContext())
		    {
		        db.Tasks.Add(task);
		        db.SaveChanges();

		        return RedirectToAction("Index");
		    }
        }

		[HttpGet]
		[Route("delete/{id}")]
        public ActionResult Delete(int id)
		{
		    using (TodoListDbContext db = new TodoListDbContext())
		    {
		        Task task = db.Tasks.Find(id);

		        if (task == null)
		        {
		            return RedirectToAction("Index");
                }

		        return View(task);
		    }
        }

		[HttpPost]
		[Route("delete/{id}")]
        [ValidateAntiForgeryToken]
		public ActionResult DeleteConfirm(int id)
		{
		    using (TodoListDbContext db = new TodoListDbContext())
		    {
		        Task task = db.Tasks.Find(id);

		        if (task == null)
		        {
		            return RedirectToAction("Index");
		        }

		        db.Tasks.Remove(task);
		        db.SaveChanges();

		        return RedirectToAction("Index");
		    }
        }
	}
}