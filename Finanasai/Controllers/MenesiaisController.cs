using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Finanasai.Helpers;
using Finansai.DAL;

namespace Finanasai.Controllers
{
    public class MenesiaisController : BaseController
    {

        // GET: Menesiais
        public ActionResult Index()
        {
            return PartialView(_db.Menesiai.ToList());
        }

        // GET: Menesiais/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Menesiai menesiai = _db.Menesiai.Find(id);
            if (menesiai == null)
            {
                return HttpNotFound();
            }
            return View(menesiai);
        }

        // GET: Menesiais/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Menesiais/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Pavadinimas")] Menesiai menesiai)
        {
            if (ModelState.IsValid)
            {
                _db.Menesiai.Add(menesiai);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(menesiai);
        }

        // GET: Menesiais/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Menesiai menesiai = _db.Menesiai.Find(id);
            if (menesiai == null)
            {
                return HttpNotFound();
            }
            return View(menesiai);
        }

        // POST: Menesiais/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Pavadinimas")] Menesiai menesiai)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(menesiai).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(menesiai);
        }

        // GET: Menesiais/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Menesiai menesiai = _db.Menesiai.Find(id);
            if (menesiai == null)
            {
                return HttpNotFound();
            }
            return View(menesiai);
        }

        // POST: Menesiais/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Menesiai menesiai = _db.Menesiai.Find(id);
            _db.Menesiai.Remove(menesiai);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
