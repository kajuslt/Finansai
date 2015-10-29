using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Finanasai.Helpers;
using Finanasai.Models;
using Finansai.DAL;

namespace Finanasai.Controllers
{
    public class DienosController : BaseController
    {

        // GET: Dienos
        public ActionResult Index()
        {
            return PartialView(_db.Dienos.ToList());
        }

        // GET: Dienos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dienos dienos = _db.Dienos.Find(id);
            if (dienos == null)
            {
                return HttpNotFound();
            }
            return View(dienos);
        }

        // GET: Dienos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Dienos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Pavadinimas")] Dienos dienos)
        {
            if (ModelState.IsValid)
            {
                _db.Dienos.Add(dienos);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dienos);
        }

        // GET: Dienos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dienos dienos = _db.Dienos.Find(id);
            if (dienos == null)
            {
                return HttpNotFound();
            }
            return View(dienos);
        }

        // POST: Dienos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Pavadinimas")] Dienos dienos)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(dienos).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dienos);
        }

        // GET: Dienos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dienos dienos = _db.Dienos.Find(id);
            if (dienos == null)
            {
                return HttpNotFound();
            }
            return View(dienos);
        }

        // POST: Dienos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Dienos dienos = _db.Dienos.Find(id);
            _db.Dienos.Remove(dienos);
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
