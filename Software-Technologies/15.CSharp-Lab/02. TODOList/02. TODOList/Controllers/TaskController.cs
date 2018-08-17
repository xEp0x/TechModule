﻿using System.Web.Mvc;
using _02.TODOList.Models;

namespace _02.TODOList.Controllers
{
    public class TaskController : Controller
    {
        [HttpPost]
        public ActionResult Create(Task task)
        {
            if (task == null)
            {
                return RedirectToAction("Index", "Home");
            }

            using (TaskDbContext db = new TaskDbContext())
            {
                db.Tasks.Add(task);
                db.SaveChanges();
            }

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index", "Home");
            }

            using (TaskDbContext db = new TaskDbContext())
            {
                Task task = db.Tasks.Find(id);

                if (task == null)
                {
                    return RedirectToAction("Index", "Home");
                }

                db.Tasks.Remove(task);
                db.SaveChanges();
            }

            return RedirectToAction("Index", "Home");
        }
    }
}