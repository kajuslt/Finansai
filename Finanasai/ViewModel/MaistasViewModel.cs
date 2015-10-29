using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Finanasai.ViewModel
{
    public class MaistasViewModel
    {
        [DisplayName("Maistas ID")]
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
        [DisplayName("Pirkiniai")]
        [DisplayFormat(DataFormatString = "{0:#.00}")]
        public decimal Pirkiniai { get; set; }

        [Required(ErrorMessage = "Privalomas")]
        [DisplayName("Restoranai ir kavinės")]
        [DisplayFormat(DataFormatString = "{0:#.00}")]
        public decimal RestoranaiKavinesUzkandines { get; set; }

        [Required(ErrorMessage = "Privalomas")]
        [DisplayName("Maistas darbe")]
        [DisplayFormat(DataFormatString = "{0:#.00}")]
        public decimal MaistasDarbe { get; set; }

        [Required(ErrorMessage = "Privalomas")]
        [DisplayName("Kita")]
        [DisplayFormat(DataFormatString = "{0:#.00}")]
        public decimal Kita { get; set; }
    }
}