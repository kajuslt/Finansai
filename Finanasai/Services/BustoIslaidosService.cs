using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Finanasai.ViewModel;
using Finansai.DAL;

namespace Finanasai.Services
{
    public class BustoIslaidosService : IDisposable
    {
        private FinansaiEntities entities;

        public BustoIslaidosService(FinansaiEntities entities)
        {
            this.entities = entities;
        }

        public IEnumerable<BustoIslaidosViewModel> Read()
        {
            return entities.BustoIslaidos.Select(bustoIslaidos => new BustoIslaidosViewModel
            {
                Id = bustoIslaidos.Id,
                MetaiId = bustoIslaidos.MetaiId,
                Metai = new MetaiViewModel
                {
                    Id = bustoIslaidos.Metai.Id,
                    Pavadinimas = bustoIslaidos.Metai.Pavadinimas
                },
                MenuoId = bustoIslaidos.MenuoId,
                Menesiai = new MenesiaiViewModel
                {
                    Id = bustoIslaidos.Menesiai.Id,
                    Pavadinimas = bustoIslaidos.Menesiai.Pavadinimas
                },
                SavaiteId = bustoIslaidos.SavaiteId,
                Savaites = new SavaitesViewModel
                {
                    Id = bustoIslaidos.Savaites.Id,
                    Pavadinimas = bustoIslaidos.Savaites.Pavadinimas
                },
                DienaId = bustoIslaidos.DienaId,
                Dienos = new DienosViewModel
                {
                    Id = bustoIslaidos.Dienos.Id,
                    Pavadinimas = bustoIslaidos.Dienos.Pavadinimas
                },
                Data = bustoIslaidos.Data,
                Paskola = bustoIslaidos.Paskola,
                MalgozatosTelefonas = bustoIslaidos.MalgozatosTelefonas,
                JuliausTelefonas = bustoIslaidos.JuliausTelefonas,
                Elektra = bustoIslaidos.Elektra,
                Vanduo = bustoIslaidos.Vanduo,
                Šildymas = bustoIslaidos.Šildymas,
                TvIrInterntetas = bustoIslaidos.TvIrInterntetas,
                BendriMokesciai = bustoIslaidos.BendriMokesciai,
                Kita = bustoIslaidos.Kita

            });
        }

        public void Create(BustoIslaidosViewModel bustoIslaidos)
        {
            var entity = new BustoIslaidos();

            entity.MetaiId = bustoIslaidos.Metai.Id;
            if (entity.MetaiId == null)
            {
                entity.MetaiId = 1;
            }

            if (bustoIslaidos.Metai == null)
            {
                entity.MetaiId = bustoIslaidos.Metai.Id;
            }
            entity.MenuoId = bustoIslaidos.Menesiai.Id;
            entity.SavaiteId = bustoIslaidos.Savaites.Id;
            entity.DienaId = bustoIslaidos.Dienos.Id;
            entity.Data = bustoIslaidos.Data;
            entity.Paskola = bustoIslaidos.Paskola;
            entity.MalgozatosTelefonas = bustoIslaidos.MalgozatosTelefonas;
            entity.JuliausTelefonas = bustoIslaidos.JuliausTelefonas;
            entity.Elektra = bustoIslaidos.Elektra;
            entity.Vanduo = bustoIslaidos.Vanduo;
            entity.Šildymas = bustoIslaidos.Šildymas;
            entity.TvIrInterntetas = bustoIslaidos.TvIrInterntetas;
            entity.BendriMokesciai = bustoIslaidos.BendriMokesciai;
            entity.Kita = bustoIslaidos.Kita;

            entities.BustoIslaidos.Add(entity);
            entities.SaveChanges();

            bustoIslaidos.Id = entity.Id;
        }

        public void Update(BustoIslaidosViewModel bustoIslaidos)
        {
            var entity = new BustoIslaidos();

            entity.Id = bustoIslaidos.Id;
            entity.MetaiId = bustoIslaidos.Metai.Id;
            
            if (bustoIslaidos.Metai != null)
            {
                entity.MetaiId = bustoIslaidos.Metai.Id;
            }
            entity.MenuoId = bustoIslaidos.Menesiai.Id;
            entity.SavaiteId = bustoIslaidos.Savaites.Id;
            entity.DienaId = bustoIslaidos.Dienos.Id;
            entity.Data = bustoIslaidos.Data;
            entity.Paskola = bustoIslaidos.Paskola;
            entity.MalgozatosTelefonas = bustoIslaidos.MalgozatosTelefonas;
            entity.JuliausTelefonas = bustoIslaidos.JuliausTelefonas;
            entity.Elektra = bustoIslaidos.Elektra;
            entity.Vanduo = bustoIslaidos.Vanduo;
            entity.Šildymas = bustoIslaidos.Šildymas;
            entity.TvIrInterntetas = bustoIslaidos.TvIrInterntetas;
            entity.BendriMokesciai = bustoIslaidos.BendriMokesciai;
            entity.Kita = bustoIslaidos.Kita;

            entities.BustoIslaidos.Attach(entity);
            entities.Entry(entity).State = EntityState.Modified;
            entities.SaveChanges();
        }

        public void Destroy(BustoIslaidosViewModel bustoIslaidos)
        {
            var entity = new BustoIslaidos();

            entity.Id = bustoIslaidos.Id;
            entities.BustoIslaidos.Attach(entity);
            entities.BustoIslaidos.Remove(entity);
            entities.SaveChanges();
        }

        public void Dispose()
        {
            entities.Dispose();
        }
    }
}