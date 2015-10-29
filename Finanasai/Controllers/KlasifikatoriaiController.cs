using System.Web.Mvc;
using Finanasai.Models;

namespace Finanasai.Controllers
{
    public class KlasifikatoriaiController : Controller
    {
        public ActionResult Index(int aId = 0)
        {
            ViewBag.ControllerName = KlasifikatoriaiList.GetControllerName(aId);
            return View(new KlasifikatoriaiList { KlasifikatoriusName = ViewBag.ControllerName, Id = aId });
        }

        [HttpPost]
        public ActionResult Index(KlasifikatoriaiList item)
        {
            ViewBag.ControllerName = KlasifikatoriaiList.GetControllerName(item.Id);
            return View(item);
        }
         
    }
}