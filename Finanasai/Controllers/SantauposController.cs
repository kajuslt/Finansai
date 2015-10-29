using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Finanasai.Helpers;
using Finansai.DAL;

namespace Finanasai.Controllers
{
    public class SantauposController : BaseController
    {

        // GET: Santaupos
        public ActionResult Index()
        {
            return View(_db.Santaupos.ToList());
        }

        // GET: Santaupos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Santaupos santaupos = _db.Santaupos.Find(id);
            if (santaupos == null)
            {
                return HttpNotFound();
            }
            return View(santaupos);
        }

        // GET: Santaupos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Santaupos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Data,Grynais,MKorteleDnB,JKorteleDanske,JKortelėSwe_dbank,JKortelėDnB,Automobiliui,Kelionei,ForceMajor,Sveikata,Rubai")] Santaupos santaupos)
        {
            if (ModelState.IsValid)
            {
                _db.Santaupos.Add(santaupos);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(santaupos);
        }

        // GET: Santaupos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Santaupos santaupos = _db.Santaupos.Find(id);
            if (santaupos == null)
            {
                return HttpNotFound();
            }
            return View(santaupos);
        }

        // POST: Santaupos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Data,Grynais,MKorteleDnB,JKorteleDanske,JKortelėSwe_dbank,JKortelėDnB,Automobiliui,Kelionei,ForceMajor,Sveikata,Rubai")] Santaupos santaupos)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(santaupos).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(santaupos);
        }

        // GET: Santaupos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Santaupos santaupos = _db.Santaupos.Find(id);
            if (santaupos == null)
            {
                return HttpNotFound();
            }
            return View(santaupos);
        }

        // POST: Santaupos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Santaupos santaupos = _db.Santaupos.Find(id);
            _db.Santaupos.Remove(santaupos);
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
