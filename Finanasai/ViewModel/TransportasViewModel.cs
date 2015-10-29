using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Finanasai.ViewModel
{
    public class TransportasViewModel
    {
        [DisplayName("Transportas ID")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Privalomas")]
        [DisplayName("Metai")]
        public int Metai { get; set; }

        [Required(ErrorMessage = "Privalomas")]
        [DisplayName("Menuo")]
        public string Menesiai { get; set; }

        [Required(ErrorMessage = "Privalomas")]
        [DisplayName("Savaite")]
        public string Savaites { get; set; }

        [Required(ErrorMessage = "Privalomas")]
        [DisplayName("Diena")]
        public string Dienos { get; set; }

        [DisplayName("Data")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? Data { get; set; }

        [Required(ErrorMessage = "Privalomas")]
        [DisplayName("Mašinos priežiūra")]
        [DisplayFormat(DataFormatString = "{0:#.00}")]
        public decimal MašinosPrieziura { get; set; }

        [Required(ErrorMessage = "Privalomas")]
        [DisplayName("Autobuso, taksi išlaidos")]
        [DisplayFormat(DataFormatString = "{0:#.00}")]
        public decimal AutobusoTaksiIslaidos { get; set; }

        [Required(ErrorMessage = "Privalomas")]
        [DisplayName("Draudimas")]
        [DisplayFormat(DataFormatString = "{0:#.00}")]
        public decimal Draudimas { get; set; }

        [Required(ErrorMessage = "Privalomas")]
        [DisplayName("Kuras")]
        [DisplayFormat(DataFormatString = "{0:#.00}")]
        public decimal Kuras { get; set; }

        [Required(ErrorMessage = "Privalomas")]
        [DisplayName("Plovimas")]
        [DisplayFormat(DataFormatString = "{0:#.00}")]
        public decimal Plovimas { get; set; }

        [Required(ErrorMessage = "Privalomas")]
        [DisplayName("Kita")]
        [DisplayFormat(DataFormatString = "{0:#.00}")]
        public decimal Kita { get; set; } 
    }
}