using Finansai.DAL;

namespace Finansai.BL.Intefaces
{
    public interface IBustoIslaidos
    {
        bool ValidateBustoIslaidos(BustoIslaidos bustoIslaidos);

        BustoIslaidos FillBustoIslaidos(BustoIslaidos model);
    }
}