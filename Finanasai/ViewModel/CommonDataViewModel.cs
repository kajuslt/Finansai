using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Finanasai.ViewModel
{
    public class CommonDataViewModel
    {
        [DisplayName("Busto išlaidų ID")]
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
    }
}