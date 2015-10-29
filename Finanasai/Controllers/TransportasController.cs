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
    public class TransportasController : BaseController
    {
        // GET: Transportas
        public ActionResult Index()
        {
            return View();
        }

        // GET: Transportas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Transportas transportas = _db.Transportas.Find(id);
            if (transportas == null)
            {
                return HttpNotFound();
            }
            return View(transportas);
        }

        // GET: Transportas/Create
        public ActionResult Create()
        {
            ViewBag.MetaiId = new SelectList(_db.Metai, "Id", "Id");
            return View();
        }

        // POST: Transportas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,MetaiId,MenuoId,SavaiteId,DienaId,Data,MašinosPrieziura,AutobusoTaksiIslaidos,Draudimas,Kuras,Plovimas,Kita")] Transportas transportas)
        {
            if (ModelState.IsValid)
            {
                _db.Transportas.Add(transportas);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MetaiId = new SelectList(_db.Metai, "Id", "Id", transportas.MetaiId);
            return View(transportas);
        }

        // GET: Transportas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Transportas transportas = _db.Transportas.Find(id);
            if (transportas == null)
            {
                return HttpNotFound();
            }
            ViewBag.MetaiId = new SelectList(_db.Metai, "Id", "Id", transportas.MetaiId);
            return View(transportas);
        }

        // POST: Transportas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,MetaiId,MenuoId,SavaiteId,DienaId,Data,MašinosPrieziura,AutobusoTaksiIslaidos,Draudimas,Kuras,Plovimas,Kita")] Transportas transportas)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(transportas).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MetaiId = new SelectList(_db.Metai, "Id", "Id", transportas.MetaiId);
            return View(transportas);
        }

        // GET: Transportas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Transportas transportas = _db.Transportas.Find(id);
            if (transportas == null)
            {
                return HttpNotFound();
            }
            return View(transportas);
        }

        // POST: Transportas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Transportas transportas = _db.Transportas.Find(id);
            _db.Transportas.Remove(transportas);
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
        public ActionResult GetTransportas([DataSourceRequest] DataSourceRequest request)
        {
            var transportas = _db.Transportas.ToList();
            DataSourceResult result = transportas.ToDataSourceResult(request);
            result.Data = Mapper.Map<IEnumerable<TransportasViewModel>>(result.Data);
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}
