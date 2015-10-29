using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Finanasai.ViewModel
{
    public class PramogosViewModel
    {
        [DisplayName("Pramogos ID")]
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
        [DisplayName("Kinas")]
        [DisplayFormat(DataFormatString = "{0:#.00}")]
        public decimal Kinas { get; set; }

        [Required(ErrorMessage = "Privalomas")]
        [DisplayName("Koncertai")]
        [DisplayFormat(DataFormatString = "{0:#.00}")]
        public decimal Koncertai { get; set; }

        [Required(ErrorMessage = "Privalomas")]
        [DisplayName("Sporto renginiai")]
        [DisplayFormat(DataFormatString = "{0:#.00}")]
        public decimal SportoRenginiai { get; set; }

        [Required(ErrorMessage = "Privalomas")]
        [DisplayName("Teatras")]
        [DisplayFormat(DataFormatString = "{0:#.00}")]
        public decimal Teatras { get; set; }

        [Required(ErrorMessage = "Privalomas")]
        [DisplayName("Kita")]
        public decimal Kita { get; set; }
    }
}