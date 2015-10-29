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
    public class AsmeninePrieziuraController : BaseController
    {
        // GET: AsmeninePrieziuras
        public ActionResult Index()
        {
            var asmeninePrieziuras = _db.AsmeninePrieziura.Include(a => a.Metai).Include(m => m.Menesiai).Include(m => m.Savaites).Include(m => m.Dienos);
            return View();
        }

        // GET: AsmeninePrieziuras/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AsmeninePrieziura asmeninePrieziura = _db.AsmeninePrieziura.Find(id);
            if (asmeninePrieziura == null)
            {
                return HttpNotFound();
            }
            return View(asmeninePrieziura);
        }

        // GET: AsmeninePrieziuras/Create
        public ActionResult Create()
        {
            ViewBag.MetaiId = new SelectList(_db.Metai, "Id", "Id");
            return View();
        }

        // POST: AsmeninePrieziuras/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,MetaiId,MenuoId,SavaiteId,DienaId,Data,Medicina,PlaukaiNagai,Rubai,RubuValymas,SveikatingumoKlubas,Bureliai,HigienoPrekes,Kita")] AsmeninePrieziura asmeninePrieziura)
        {
            if (ModelState.IsValid)
            {
                _db.AsmeninePrieziura.Add(asmeninePrieziura);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MetaiId = new SelectList(_db.Metai, "Id", "Id", asmeninePrieziura.MetaiId);
            return View(asmeninePrieziura);
        }

        // GET: AsmeninePrieziuras/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AsmeninePrieziura asmeninePrieziura = _db.AsmeninePrieziura.Find(id);
            if (asmeninePrieziura == null)
            {
                return HttpNotFound();
            }
            ViewBag.MetaiId = new SelectList(_db.Metai, "Id", "Id", asmeninePrieziura.MetaiId);
            return View(asmeninePrieziura);
        }

        // POST: AsmeninePrieziuras/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,MetaiId,MenuoId,SavaiteId,DienaId,Data,Medicina,PlaukaiNagai,Rubai,RubuValymas,SveikatingumoKlubas,Bureliai,HigienoPrekes,Kita")] AsmeninePrieziura asmeninePrieziura)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(asmeninePrieziura).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MetaiId = new SelectList(_db.Metai, "Id", "Id", asmeninePrieziura.MetaiId);
            return View(asmeninePrieziura);
        }

        // GET: AsmeninePrieziuras/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AsmeninePrieziura asmeninePrieziura = _db.AsmeninePrieziura.Find(id);
            if (asmeninePrieziura == null)
            {
                return HttpNotFound();
            }
            return View(asmeninePrieziura);
        }

        // POST: AsmeninePrieziuras/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AsmeninePrieziura asmeninePrieziura = _db.AsmeninePrieziura.Find(id);
            _db.AsmeninePrieziura.Remove(asmeninePrieziura);
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
        public ActionResult GetAsmeninePrieziura([DataSourceRequest] DataSourceRequest request)
        {
            var asmeninePrieziura = _db.AsmeninePrieziura.ToList();
            DataSourceResult result = asmeninePrieziura.ToDataSourceResult(request);
            result.Data = Mapper.Map<IEnumerable<AsmeninePrieziuraViewModel>>(result.Data);
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}
