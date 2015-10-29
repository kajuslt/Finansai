using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Finanasai.ViewModel
{
    public class KitaViewModel
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
        [DisplayName("Nenumatyti atvejai")]
        [DisplayFormat(DataFormatString = "{0:#.00}")]
        public decimal NenumatytiAtvejai { get; set; }

        [Required(ErrorMessage = "Privalomas")]
        [DisplayName("Buitienė technika")]
        [DisplayFormat(DataFormatString = "{0:#.00}")]
        public decimal BuitieneTechnika { get; set; }

        [Required(ErrorMessage = "Privalomas")]
        [DisplayName("Cigaretės")]
        [DisplayFormat(DataFormatString = "{0:#.00}")]
        public decimal Cigaretes { get; set; }

        [Required(ErrorMessage = "Privalomas")]
        [DisplayName("Kita")]
        [DisplayFormat(DataFormatString = "{0:#.00}")]
        public decimal Kita1 { get; set; }
    }
}