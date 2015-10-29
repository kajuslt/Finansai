using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using AutoMapper;
using Finanasai.Helpers;
using Finanasai.Models;
using Finanasai.ViewModel;
using Finansai.DAL;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;

namespace Finanasai.Controllers
{
    public class BustoIslaidosController : BaseController
    {

        // GET: BustoIslaidos
        public ActionResult Index()
        {
            var bustoIslaidos =
                _db.BustoIslaidos.Include(b => b.Metai)
                    .Include(m => m.Menesiai)
                    .Include(m => m.Savaites)
                    .Include(m => m.Dienos);
            return View();
        }

        // GET: BustoIslaidos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BustoIslaidos bustoIslaidos = _db.BustoIslaidos.Find(id);
            if (bustoIslaidos == null)
            {
                return HttpNotFound();
            }
            return View(bustoIslaidos);
        }

        // GET: BustoIslaidos/Create
        public ActionResult Create()
        {
            ViewBag.MetaiId = new SelectList(_db.Metai, "Id", "Pavadinimas");
            ViewBag.MenuoId = new SelectList(_db.Menesiai, "Id", "Pavadinimas");
            ViewBag.SavaiteId = new SelectList(_db.Savaites, "Id", "Pavadinimas");
            ViewBag.DienaId = new SelectList(_db.Dienos, "Id", "Pavadinimas");
            return View();
        }

        // POST: BustoIslaidos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(
            [Bind(
                Include =
                    "Id,MetaiId,MenuoId,SavaiteId,DienaId,Data,Paskola,MalgozatosTelefonas,JuliausTelefonas,Elektra,Vanduo,Šildymas,TvIrInterntetas,BendriMokesciai,Kita"
                )] BustoIslaidos bustoIslaidos)
        {
            if (ModelState.IsValid)
            {
                _db.BustoIslaidos.Add(bustoIslaidos);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MetaiId = new SelectList(_db.Metai, "Id", "Id", bustoIslaidos.MetaiId);
            return View(bustoIslaidos);
        }

        // GET: BustoIslaidos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BustoIslaidos bustoIslaidos = _db.BustoIslaidos.Find(id);
            if (bustoIslaidos == null)
            {
                return HttpNotFound();
            }
            ViewBag.MetaiId = new SelectList(_db.Metai, "Id", "Id", bustoIslaidos.MetaiId);
            return View(bustoIslaidos);
        }

        // POST: BustoIslaidos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(
            [Bind(
                Include =
                    "Id,MetaiId,MenuoId,SavaiteId,DienaId,Data,Paskola,MalgozatosTelefonas,JuliausTelefonas,Elektra,Vanduo,Šildymas,TvIrInterntetas,BendriMokesciai,Kita"
                )] BustoIslaidos bustoIslaidos)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(bustoIslaidos).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MetaiId = new SelectList(_db.Metai, "Id", "Id", bustoIslaidos.MetaiId);
            return View(bustoIslaidos);
        }

        // GET: BustoIslaidos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BustoIslaidos bustoIslaidos = _db.BustoIslaidos.Find(id);
            if (bustoIslaidos == null)
            {
                return HttpNotFound();
            }
            return View(bustoIslaidos);
        }

        // POST: BustoIslaidos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BustoIslaidos bustoIslaidos = _db.BustoIslaidos.Find(id);
            _db.BustoIslaidos.Remove(bustoIslaidos);
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
        public ActionResult GetBustoIslaidos([DataSourceRequest] DataSourceRequest request)
        {
            var bustoIslaidos = _db.BustoIslaidos.ToList();
            DataSourceResult result = bustoIslaidos.ToDataSourceResult(request);
            result.Data = Mapper.Map<IEnumerable<BustoIslaidosViewModel>>(result.Data);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetBustoIslaidosSavaitines([DataSourceRequest] DataSourceRequest request)
        {
            var bustoIslaidosSavaitine = _db.BustoIslaidos_Savaitine.ToList();
            DataSourceResult result = bustoIslaidosSavaitine.ToDataSourceResult(request);
            result.Data = Mapper.Map<IEnumerable<BustoIslaidosSavaitinesViewModel>>(result.Data);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public ActionResult BulkCreate()
        {

            return View();

        }

    }
}