using System.Web.Mvc;
using Finansai.BL.Intefaces;
using Finansai.DAL;


namespace Finansai.BL.Services
{
    public class BustoIslaidosService : IBustoIslaidos
    {
        private ModelStateDictionary _modelStateDictionary;

        public bool ValidateBustoIslaidos(BustoIslaidos bustoIslaidos)
        {
            return _modelStateDictionary.IsValid;
        }

        public BustoIslaidos FillBustoIslaidos(BustoIslaidos model)
        {
            throw new System.NotImplementedException();
        }
    }
}