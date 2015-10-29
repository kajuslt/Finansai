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
    public class MaistasController : BaseController
    {

        // GET: Maistas
        public ActionResult Index()
        {
            var maistas = _db.Maistas.Include(m => m.Metai).Include(m => m.Menesiai).Include(m => m.Savaites).Include(m => m.Dienos);
            return View();
        }

        // GET: Maistas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Maistas maistas = _db.Maistas.Find(id);
            if (maistas == null)
            {
                return HttpNotFound();
            }
            return View(maistas);
        }

        // GET: Maistas/Create
        public ActionResult Create()
        {
            ViewBag.MetaiId = new SelectList(_db.Metai, "Id", "Id");
            return View();
        }

        // POST: Maistas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,MetaiId,MenuoId,SavaiteId,DienaId,Data,Pirkiniai,RestoranaiKavinesUzkandines,MaistasDarbe,Kita")] Maistas maistas)
        {
            if (ModelState.IsValid)
            {
                _db.Maistas.Add(maistas);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MetaiId = new SelectList(_db.Metai, "Id", "Id", maistas.MetaiId);
            return View(maistas);
        }

        // GET: Maistas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Maistas maistas = _db.Maistas.Find(id);
            if (maistas == null)
            {
                return HttpNotFound();
            }
            ViewBag.MetaiId = new SelectList(_db.Metai, "Id", "Id", maistas.MetaiId);
            return View(maistas);
        }

        // POST: Maistas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,MetaiId,MenuoId,SavaiteId,DienaId,Data,Pirkiniai,RestoranaiKavinesUzkandines,MaistasDarbe,Kita")] Maistas maistas)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(maistas).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MetaiId = new SelectList(_db.Metai, "Id", "Id", maistas.MetaiId);
            return View(maistas);
        }

        // GET: Maistas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Maistas maistas = _db.Maistas.Find(id);
            if (maistas == null)
            {
                return HttpNotFound();
            }
            return View(maistas);
        }

        // POST: Maistas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Maistas maistas = _db.Maistas.Find(id);
            _db.Maistas.Remove(maistas);
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
        public ActionResult GetMaistas([DataSourceRequest] DataSourceRequest request)
        {
            var maistas = _db.Maistas.ToList();
            DataSourceResult result = maistas.ToDataSourceResult(request);
            result.Data = Mapper.Map<IEnumerable<MaistasViewModel>>(result.Data);
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}
