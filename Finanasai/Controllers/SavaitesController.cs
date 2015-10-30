using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Finanasai.Helpers;
using Finansai.DAL;

namespace Finanasai.Controllers
{
    public class SavaitesController : BaseController
    {

        // GET: Savaites
        public ActionResult Index()
        {
            return PartialView(_db.Savaites.ToList());
        }

        // GET: Savaites/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Savaites savaites = _db.Savaites.Find(id);
            if (savaites == null)
            {
                return HttpNotFound();
            }
            return View(savaites);
        }

        // GET: Savaites/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Savaites/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Pavadinimas")] Savaites savaites)
        {
            if (ModelState.IsValid)
            {
                _db.Savaites.Add(savaites);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(savaites);
        }

        // GET: Savaites/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Savaites savaites = _db.Savaites.Find(id);
            if (savaites == null)
            {
                return HttpNotFound();
            }
            return View(savaites);
        }

        // POST: Savaites/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Pavadinimas")] Savaites savaites)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(savaites).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(savaites);
        }

        // GET: Savaites/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Savaites savaites = _db.Savaites.Find(id);
            if (savaites == null)
            {
                return HttpNotFound();
            }
            return View(savaites);
        }

        // POST: Savaites/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Savaites savaites = _db.Savaites.Find(id);
            _db.Savaites.Remove(savaites);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public JsonResult GetSavaitesJsonResult()
        {
            return Json(_db.Savaites.Select(c => new { SavaitesId = c.Id, SavaitesPavadinimas = c.Pavadinimas }), JsonRequestBehavior.AllowGet);
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
