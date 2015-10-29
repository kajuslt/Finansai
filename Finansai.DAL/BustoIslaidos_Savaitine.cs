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
    
    public partial class BustoIslaidos_Savaitine
    {
        public int Id { get; set; }
        public int MetaiId { get; set; }
        public int MenuoId { get; set; }
        public int SavaiteId { get; set; }
        public int DienaId { get; set; }
        public Nullable<System.DateTime> Data { get; set; }
        public decimal Paskola { get; set; }
        public decimal MalgozatosTelefonas { get; set; }
        public decimal JuliausTelefonas { get; set; }
        public decimal Elektra { get; set; }
        public decimal Vanduo { get; set; }
        public decimal Šildymas { get; set; }
        public decimal TvIrInterntetas { get; set; }
        public decimal BendriMokesciai { get; set; }
        public decimal Kita { get; set; }
    
        public virtual Dienos Dienos { get; set; }
        public virtual Menesiai Menesiai { get; set; }
        public virtual Metai Metai { get; set; }
        public virtual Savaites Savaites { get; set; }
    }
}
