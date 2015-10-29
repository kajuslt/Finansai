using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using AutoMapper;
using Finanasai.Helpers;
using Finanasai.Services;
using Finanasai.ViewModel;
using Finansai.DAL;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using System.Data.Entity;

namespace Finanasai.Controllers
{
    public partial class BustoIslaidosExperimentController : BaseController
    {
        private BustoIslaidosService bustoIslaidosService;

        public BustoIslaidosExperimentController()
        {

            bustoIslaidosService = new BustoIslaidosService(new FinansaiEntities());
        }

        // GET: BustoIslaidos
        public ActionResult Index()
        {
            var maistas = _db.Maistas.Include(m => m.Metai).Include(m => m.Menesiai).Include(m => m.Savaites).Include(m => m.Dienos);
            //ViewBag.MetaiId = new SelectList(_db.Metai, "Id", "Pavadinimas");
            //ViewBag.MenuoId = new SelectList(_db.Menesiai, "Id", "Pavadinimas");
            //ViewBag.SavaiteId = new SelectList(_db.Savaites, "Id", "Pavadinimas");
            //ViewBag.DienaId = new SelectList(_db.Dienos, "Id", "Pavadinimas");
            return View();
        }

        public ActionResult Index_Read([DataSourceRequest] DataSourceRequest request)
        {

            return Json(bustoIslaidosService.Read().ToDataSourceResult(request));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Create([DataSourceRequest] DataSourceRequest request, BustoIslaidosViewModel product)
        {
            if (product != null && ModelState.IsValid)
            {
                bustoIslaidosService.Create(product);
            }

            return Json(new[] { product }.ToDataSourceResult(request, ModelState));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Update([DataSourceRequest] DataSourceRequest request, BustoIslaidosViewModel product)
        {
            if (product != null && ModelState.IsValid)
            {
                bustoIslaidosService.Update(product);
            }

            return Json(new[] { product }.ToDataSourceResult(request, ModelState));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Destroy([DataSourceRequest] DataSourceRequest request, BustoIslaidosViewModel product)
        {
            if (product != null)
            {
                bustoIslaidosService.Destroy(product);
            }

            return Json(new[] { product }.ToDataSourceResult(request, ModelState));
        }

        public void PopulateMetai([DataSourceRequest] DataSourceRequest request)
        {
            

            var dataContext = new FinansaiEntities();
            var metai = dataContext.Dovanos.ToList();
            DataSourceResult result = metai.ToDataSourceResult(request);
            result.Data = Mapper.Map<IEnumerable<DovanosViewModel>>(result.Data);

            ViewData["metai"] = result;
        }

       public ActionResult GetBustoIslaidos([DataSourceRequest] DataSourceRequest request)
        {
            var bustoIslaidos = _db.BustoIslaidos.ToList();
            DataSourceResult result = bustoIslaidos.ToDataSourceResult(request);
            result.Data = Mapper.Map<IEnumerable<BustoIslaidosViewModel>>(result.Data);
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}