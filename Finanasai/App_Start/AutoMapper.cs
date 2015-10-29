using AutoMapper;
using Finanasai.ViewModel;
using Finansai.DAL;

namespace Finanasai
{
    public class AutoMapper
    {
        public static void RegisterMaps()
        {
            Mapper.CreateMap<Metai, int>()
                .ConvertUsing(d => d.Pavadinimas);
            Mapper.CreateMap<Menesiai, string>()
                .ConvertUsing(d => d.Pavadinimas);
            Mapper.CreateMap<Savaites, string>()
                .ConvertUsing(d => d.Pavadinimas);
            Mapper.CreateMap<Dienos, string>()
                .ConvertUsing(d => d.Pavadinimas);
            //Jei nesikeicia type ir name, tai nereikia atskirai aprasineti, apraso pvz:
            // .ForMember(d => d.Acres, m => m.ResolveUsing(new RawLeadDataNameResolver("Acres")));
            Mapper.CreateMap<BustoIslaidos, BustoIslaidosViewModel>();
            Mapper.CreateMap<BustoIslaidos_Savaitine, BustoIslaidosSavaitinesViewModel>();
            Mapper.CreateMap<Transportas, TransportasViewModel>();

            Mapper.CreateMap<Maistas, MaistasViewModel>();

            Mapper.CreateMap<AsmeninePrieziura, AsmeninePrieziuraViewModel>();

            Mapper.CreateMap<Pramogos, PramogosViewModel>();

            Mapper.CreateMap<Kita, KitaViewModel>();

            Mapper.CreateMap<Dovanos, DovanosViewModel>();

            Mapper.CreateMap<Metai, MetaiViewModel>();
            Mapper.CreateMap<Menesiai, MenesiaiViewModel>();
            Mapper.CreateMap<Savaites, SavaitesViewModel>();
            Mapper.CreateMap<Dienos, DienosViewModel>();


        }
    }
}