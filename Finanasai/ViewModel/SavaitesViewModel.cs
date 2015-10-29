using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Finanasai.ViewModel
{
    public class SavaitesViewModel
    {
        [DisplayName("Savaites ID")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Privalomas")]
        [DisplayName("Pavadinimas")]
        public string Pavadinimas { get; set; }  
    }
}