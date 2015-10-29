using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using AutoMapper;
using Finanasai.Helpers;
using Finanasai.ViewModel;
using Finansai.DAL;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;

namespace Finanasai.Controllers
{
    public class KitaController : BaseController
    {
        // GET: Kita
        public ActionResult Index()
        {
            var kita = _db.Kita.Include(b => b.Metai).Include(m => m.Menesiai).Include(m => m.Savaites).Include(m => m.Dienos);
            return View();
        }

        // GET: Kita/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kita kita = _db.Kita.Find(id);
            if (kita == null)
            {
                return HttpNotFound();
            }
            return View(kita);
        }

        // GET: Kita/Create
        public ActionResult Create()
        {
            ViewBag.MetaiId = new SelectList(_db.Metai, "Id", "Id");
            return View();
        }

        // POST: Kita/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,MetaiId,MenuoId,SavaiteId,DienaId,Data,NenumatytiAtvejai,BuitieneTechnika,Cigaretes,Kita1")] Kita kita)
        {
            if (ModelState.IsValid)
            {
                _db.Kita.Add(kita);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MetaiId = new SelectList(_db.Metai, "Id", "Id", kita.MetaiId);
            return View(kita);
        }

        // GET: Kita/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kita kita = _db.Kita.Find(id);
            if (kita == null)
            {
                return HttpNotFound();
            }
            ViewBag.MetaiId = new SelectList(_db.Metai, "Id", "Id", kita.MetaiId);
            return View(kita);
        }

        // POST: Kita/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,MetaiId,MenuoId,SavaiteId,DienaId,Data,NenumatytiAtvejai,BuitieneTechnika,Cigaretes,Kita1")] Kita kita)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(kita).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MetaiId = new SelectList(_db.Metai, "Id", "Id", kita.MetaiId);
            return View(kita);
        }

        // GET: Kita/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kita kita = _db.Kita.Find(id);
            if (kita == null)
            {
                return HttpNotFound();
            }
            return View(kita);
        }

        // POST: Kita/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Kita kita = _db.Kita.Find(id);
            _db.Kita.Remove(kita);
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

        [HttpPost]
        public ActionResult GetKita([DataSourceRequest] DataSourceRequest request)
        {
            var kita = _db.Kita.ToList();
            DataSourceResult result = kita.ToDataSourceResult(request);
            result.Data = Mapper.Map<IEnumerable<KitaViewModel>>(result.Data);
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}
