//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Finansai.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Menesiai
    {
        public Menesiai()
        {
            this.AsmeninePrieziura = new HashSet<AsmeninePrieziura>();
            this.BustoIslaidos = new HashSet<BustoIslaidos>();
            this.Dovanos = new HashSet<Dovanos>();
            this.Kita = new HashSet<Kita>();
            this.Maistas = new HashSet<Maistas>();
            this.Pramogos = new HashSet<Pramogos>();
            this.Transportas = new HashSet<Transportas>();
            this.BustoIslaidos_Savaitine = new HashSet<BustoIslaidos_Savaitine>();
        }
    
        public int Id { get; set; }
        public string Pavadinimas { get; set; }
    
        public virtual ICollection<AsmeninePrieziura> AsmeninePrieziura { get; set; }
        public virtual ICollection<BustoIslaidos> BustoIslaidos { get; set; }
        public virtual ICollection<Dovanos> Dovanos { get; set; }
        public virtual ICollection<Kita> Kita { get; set; }
        public virtual ICollection<Maistas> Maistas { get; set; }
        public virtual ICollection<Pramogos> Pramogos { get; set; }
        public virtual ICollection<Transportas> Transportas { get; set; }
        public virtual ICollection<BustoIslaidos_Savaitine> BustoIslaidos_Savaitine { get; set; }
    }
}
