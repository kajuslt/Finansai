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
    public class DovanosController : BaseController
    {

        // GET: Dovanos
        public ActionResult Index()
        {
            var dovanos = _db.Dovanos.Include(d => d.Metai).Include(m => m.Menesiai).Include(m => m.Savaites).Include(m => m.Dienos);
            return View();
        }

        // GET: Dovanos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dovanos dovanos = _db.Dovanos.Find(id);
            if (dovanos == null)
            {
                return HttpNotFound();
            }
            return View(dovanos);
        }

        // GET: Dovanos/Create
        public ActionResult Create()
        {
            ViewBag.MetaiId = new SelectList(_db.Metai, "Id", "Id");
            return View();
        }

        // POST: Dovanos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,MetaiId,MenuoId,SavaiteId,DienaId,Data,Gimtadieniai,Sventės,Kita")] Dovanos dovanos)
        {
            if (ModelState.IsValid)
            {
                _db.Dovanos.Add(dovanos);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MetaiId = new SelectList(_db.Metai, "Id", "Id", dovanos.MetaiId);
            return View(dovanos);
        }

        // GET: Dovanos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dovanos dovanos = _db.Dovanos.Find(id);
            if (dovanos == null)
            {
                return HttpNotFound();
            }
            ViewBag.MetaiId = new SelectList(_db.Metai, "Id", "Id", dovanos.MetaiId);
            return View(dovanos);
        }

        // POST: Dovanos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,MetaiId,MenuoId,SavaiteId,DienaId,Data,Gimtadieniai,Sventės,Kita")] Dovanos dovanos)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(dovanos).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MetaiId = new SelectList(_db.Metai, "Id", "Id", dovanos.MetaiId);
            return View(dovanos);
        }

        // GET: Dovanos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dovanos dovanos = _db.Dovanos.Find(id);
            if (dovanos == null)
            {
                return HttpNotFound();
            }
            return View(dovanos);
        }

        // POST: Dovanos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Dovanos dovanos = _db.Dovanos.Find(id);
            _db.Dovanos.Remove(dovanos);
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
        public ActionResult GetDovanos([DataSourceRequest] DataSourceRequest request)
        {
            var dovanos = _db.Dovanos.ToList();
            DataSourceResult result = dovanos.ToDataSourceResult(request);
            result.Data = Mapper.Map<IEnumerable<DovanosViewModel>>(result.Data);
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}
