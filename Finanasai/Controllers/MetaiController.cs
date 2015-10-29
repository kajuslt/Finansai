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
    public class MetaiController : BaseController
    {

        // GET: Metai
        public ActionResult Index()
        {
            return PartialView(_db.Metai.ToList());
        }

        // GET: Metai/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Metai metai = _db.Metai.Find(id);
            if (metai == null)
            {
                return HttpNotFound();
            }
            return View(metai);
        }

        // GET: Metai/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Metai/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Pavadinimas")] Metai metai)
        {
            if (ModelState.IsValid)
            {
                _db.Metai.Add(metai);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(metai);
        }

        // GET: Metai/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Metai metai = _db.Metai.Find(id);
            if (metai == null)
            {
                return HttpNotFound();
            }
            return View(metai);
        }

        // POST: Metai/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Pavadinimas")] Metai metai)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(metai).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(metai);
        }

        // GET: Metai/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Metai metai = _db.Metai.Find(id);
            if (metai == null)
            {
                return HttpNotFound();
            }
            return View(metai);
        }

        // POST: Metai/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Metai metai = _db.Metai.Find(id);
            _db.Metai.Remove(metai);
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

        public ActionResult GetMetai([DataSourceRequest] DataSourceRequest request)
        {
            var metai = _db.Metai.ToList();
            DataSourceResult result = metai.ToDataSourceResult(request);
            result.Data = Mapper.Map<IEnumerable<MetaiViewModel>>(result.Data);
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}
