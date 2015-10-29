using System.Web.Mvc;
using Finansai.DAL;

namespace Finanasai.Helpers
{
    public class BaseController : Controller
    {
        protected FinansaiEntities _db = new FinansaiEntities();
         
    }
}