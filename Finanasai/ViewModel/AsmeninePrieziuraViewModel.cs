using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Finanasai.ViewModel
{
    public class AsmeninePrieziuraViewModel
    {
        [DisplayName("Asmeninė priežiūra ID")]
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
        [DisplayName("Medicina")]
        [DisplayFormat(DataFormatString = "{0:#.00}")]
        public decimal Medicina { get; set; }

        [Required(ErrorMessage = "Privalomas")]
        [DisplayName("Plaukai nagai")]
        [DisplayFormat(DataFormatString = "{0:#.00}")]
        public decimal PlaukaiNagai { get; set; }

        [Required(ErrorMessage = "Privalomas")]
        [DisplayName("Rūbai")]
        [DisplayFormat(DataFormatString = "{0:#.00}")]
        public decimal Rubai { get; set; }

        [Required(ErrorMessage = "Privalomas")]
        [DisplayName("Rūbų valymas")]
        [DisplayFormat(DataFormatString = "{0:#.00}")]
        public decimal RubuValymas { get; set; }

        [Required(ErrorMessage = "Privalomas")]
        [DisplayName("Sveikatingumo klubas")]
        [DisplayFormat(DataFormatString = "{0:#.00}")]
        public decimal SveikatingumoKlubas { get; set; }

        [Required(ErrorMessage = "Privalomas")]
        [DisplayName("Būreliai")]
        [DisplayFormat(DataFormatString = "{0:#.00}")]
        public decimal Bureliai { get; set; }

        [Required(ErrorMessage = "Privalomas")]
        [DisplayName("Higienos prekės")]
        [DisplayFormat(DataFormatString = "{0:#.00}")]
        public decimal HigienoPrekes { get; set; }

        [Required(ErrorMessage = "Privalomas")]
        [DisplayName("Kita")]
        [DisplayFormat(DataFormatString = "{0:#.00}")]
        public decimal Kita { get; set; }
    }
}