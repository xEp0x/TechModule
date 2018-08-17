namespace LogNoziroh.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Mvc;
    using Models;

    [ValidateInput(false)]
    public class ReportController : Controller
    {
        [HttpGet]
        [Route("")]
        public ActionResult Index()
        {
            using (LogNozirohDbContext db = new LogNozirohDbContext())
            {
                List<Report> reports = db.Reports.ToList();

                return this.View(reports);
            }
        }

        [HttpGet]
        [Route("details/{id}")]
        public ActionResult Details(int id)
        {
            using (LogNozirohDbContext db = new LogNozirohDbContext())
            {
                Report report = db.Reports.Where(a => a.Id == id).First();

                if (report == null)
                {
                    return HttpNotFound();
                }

                return View(report);
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
        public ActionResult Create(Report report)
        {
            if (ModelState.IsValid)
            {
                using (var db = new LogNozirohDbContext())
                {
                    db.Reports.Add(report);
                    db.SaveChanges();
                    return Redirect("/");
                }
            }
            return View();
        }

        [HttpGet]
        [Route("delete/{id}")]
        public ActionResult Delete(int id)
        {
            using (LogNozirohDbContext db = new LogNozirohDbContext())
            {
                Report report = db.Reports.Find(id);

                if (report == null)
                {
                    return RedirectToAction("Index");
                }

                return View(report);
            }
        }

        [HttpPost]
        [Route("delete/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirm(int id, Report reportModel)
        {
            using (LogNozirohDbContext db = new LogNozirohDbContext())
            {
                Report report = db.Reports.Find(id);

                if (report == null)
                {
                    return RedirectToAction("Index");
                }

                db.Reports.Remove(report);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
        }
    }
}