﻿using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using IMDB.Models;

namespace IMDB.Controllers
{
    [ValidateInput(false)]
    public class FilmController : Controller
    {
        [HttpGet]
        [Route("")]
        public ActionResult Index()
        {
            using (IMDBDbContext db = new IMDBDbContext())
            {
                List<Film> films = db.Films.ToList();

                return View(films);
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
        public ActionResult Create(Film film)
        {
            if (film == null)
            {
                return RedirectToAction("Index");
            }

            if (string.IsNullOrWhiteSpace(film.Name) || string.IsNullOrWhiteSpace(film.Genre) 
                || string.IsNullOrWhiteSpace(film.Director) || film.Year < 0)
            {
                return RedirectToAction("Index");
            }

            using (IMDBDbContext db = new IMDBDbContext())
            {
                db.Films.Add(film);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        [Route("edit/{id}")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            using (IMDBDbContext db = new IMDBDbContext())
            {
                Film film = db.Films.Find(id);

                if (film == null)
                {
                    return RedirectToAction("Index");
                }

                return View(film);
            }
        }

        [HttpPost]
        [Route("edit/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult EditConfirm(int? id, Film filmModel)
        {
            if (ModelState.IsValid)
            {
                using (IMDBDbContext db = new IMDBDbContext())
                {
                    Film filmFromDb = db.Films.Find(filmModel.Id);
                    if (filmFromDb != null)
                    {
                        filmFromDb.Name = filmModel.Name;
                        filmFromDb.Genre = filmModel.Genre;
                        filmFromDb.Director = filmModel.Director;
                        filmFromDb.Year = filmModel.Year;
                        db.SaveChanges();
                    }
                }
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("delete/{id}")]
        public ActionResult Delete(int? id)
        {
            using (IMDBDbContext db = new IMDBDbContext())
            {
                Film film = db.Films.Find(id);

                if (film == null)
                {
                    return RedirectToAction("Index");
                }

                return View(film);
            }
        }

        [HttpPost]
        [Route("delete/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirm(int? id, Film filmModel)
        {
            using (IMDBDbContext db = new IMDBDbContext())
            {
                Film film = db.Films.Find(id);

                if (film == null)
                {
                    return RedirectToAction("Index");
                }

                db.Films.Remove(film);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
        }
    }
}