using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookLibrary.Models;
using Microsoft.AspNet.Identity;

namespace BookLibrary.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        public ActionResult Index()
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                List<Book> books = db.Books.Include(b => b.Author).ToList();

                return View(books);
            }
        }

        // GET: Book/Details/5
        public ActionResult Details(int id)
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                Book book = db.Books.Include(b => b.Author).FirstOrDefault(i => i.Id == id);

                if (book == null)
                {
                    return new HttpNotFoundResult($"Cannot found book with {id}ID!!!");
                }
                return View(book);
            }
        }

        // GET: Book/Create
        [Authorize] 
        public ActionResult Create()
        {
            return View();
        }

        // POST: Book/Create
        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Book book)
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                var userId = User.Identity.GetUserId();

                book.AuthorId = userId;

                db.Books.Add(book);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
        }

        // GET: Book/Edit/5
        public ActionResult Edit(int id)
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                Book book = db.Books.Include(b => b.Author).FirstOrDefault(i => i.Id == id);

                if (book == null)
                {
                    return new HttpNotFoundResult($"Cannot found book with {id}ID!!!");
                }
                return View(book);
            }
        }

        // POST: Book/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Book bookView)
        {
            if (bookView.Title == null || bookView.Description == null)
            {
                return View(bookView);
            }

            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                Book book = db.Books.Include(b => b.Author).SingleOrDefault(i => i.Id == id);

                if (book == null)
                {
                    return new HttpNotFoundResult($"Cannot found book with {id}ID!!!");
                }

                book.Title = bookView.Title;
                book.Description = bookView.Description;

                db.SaveChanges();
            }

            return RedirectToAction("Details", new {id = id});
        }

        // GET: Book/Delete/5
        [Authorize]
        public ActionResult Delete(int id)
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                Book book = db.Books.SingleOrDefault(i => i.Id == id);

                if (book == null)
                {
                    return new HttpNotFoundResult($"Cannot found book with {id}ID!!!");
                }

                return View(book);
            }
        }

        // POST: Book/Delete/5
        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Book bookView)
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                Book book = db.Books.SingleOrDefault(i => i.Id == id);

                if (book == null)
                {
                    return HttpNotFound($"Book with ID {id} not found!!!");
                }

                db.Books.Remove(book);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
        }
    }
}
