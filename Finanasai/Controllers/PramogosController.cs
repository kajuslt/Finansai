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
    public class PramogosController : BaseController
    {

        // GET: Pramogos
        public ActionResult Index()
        {
            var pramogos = _db.Pramogos.Include(p => p.Metai).Include(m => m.Menesiai).Include(m => m.Savaites).Include(m => m.Dienos);
            return View();
        }

        // GET: Pramogos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pramogos pramogos = _db.Pramogos.Find(id);
            if (pramogos == null)
            {
                return HttpNotFound();
            }
            return View(pramogos);
        }

        // GET: Pramogos/Create
        public ActionResult Create()
        {
            ViewBag.MetaiId = new SelectList(_db.Metai, "Id", "Id");
            return View();
        }

        // POST: Pramogos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,MetaiId,MenuoId,SavaiteId,DienaId,Data,Kinas,Koncertai,SportoRenginiai,Teatras,Kita")] Pramogos pramogos)
        {
            if (ModelState.IsValid)
            {
                _db.Pramogos.Add(pramogos);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MetaiId = new SelectList(_db.Metai, "Id", "Id", pramogos.MetaiId);
            return View(pramogos);
        }

        // GET: Pramogos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pramogos pramogos = _db.Pramogos.Find(id);
            if (pramogos == null)
            {
                return HttpNotFound();
            }
            ViewBag.MetaiId = new SelectList(_db.Metai, "Id", "Id", pramogos.MetaiId);
            return View(pramogos);
        }

        // POST: Pramogos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,MetaiId,MenuoId,SavaiteId,DienaId,Data,Kinas,Koncertai,SportoRenginiai,Teatras,Kita")] Pramogos pramogos)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(pramogos).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MetaiId = new SelectList(_db.Metai, "Id", "Id", pramogos.MetaiId);
            return View(pramogos);
        }

        // GET: Pramogos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pramogos pramogos = _db.Pramogos.Find(id);
            if (pramogos == null)
            {
                return HttpNotFound();
            }
            return View(pramogos);
        }

        // POST: Pramogos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Pramogos pramogos = _db.Pramogos.Find(id);
            _db.Pramogos.Remove(pramogos);
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
        public ActionResult GetPramogos([DataSourceRequest] DataSourceRequest request)
        {
            var pramogos = _db.Pramogos.ToList();
            DataSourceResult result = pramogos.ToDataSourceResult(request);
            result.Data = Mapper.Map<IEnumerable<PramogosViewModel>>(result.Data);
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}
