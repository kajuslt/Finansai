using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Finansai.DAL;

namespace Finanasai.ViewModel
{
    public class BustoIslaidosViewModel
    {
        [DisplayName("Busto išlaidų ID")]
        public int Id { get; set; }

        [UIHint("MetaiEditorOne")]
        [DisplayName("Metai ID")]
        public int MetaiId { get; set; }

        [DisplayName("Menuo ID")]
        public int MenuoId { get; set; }

        [DisplayName("Savaite ID")]
        public int SavaiteId { get; set; }

        [DisplayName("Diena ID")]
        public int DienaId { get; set; }
        
        [DisplayName("Data")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime? Data { get; set; }

        [Required(ErrorMessage = "Privalomas")]
        [DisplayName("Paskola")]
        [DisplayFormat(DataFormatString = "{0:#.00}")]
        public decimal Paskola { get; set; }

        [Required(ErrorMessage = "Privalomas")]
        [DisplayName("Malgožatos telefonas")]
        [DisplayFormat(DataFormatString = "{0:#.00}")]
        public decimal MalgozatosTelefonas { get; set; }

        [Required(ErrorMessage = "Privalomas")]
        [DisplayName("Juliaus telefonas")]
        [DisplayFormat(DataFormatString = "{0:#.00}")]
        public decimal JuliausTelefonas { get; set; }

        [Required(ErrorMessage = "Privalomas")]
        [DisplayName("Elektra")]
        [DisplayFormat(DataFormatString = "{0:#.00}")]
        public decimal Elektra { get; set; }

        [Required(ErrorMessage = "Privalomas")]
        [DisplayName("Šaltas vanduo")]
        [DisplayFormat(DataFormatString = "{0:#.00}")]
        public decimal Vanduo { get; set; }

        [Required(ErrorMessage = "Privalomas")]
        [DisplayName("Šildymas ir karštas vanduo")]
        [DisplayFormat(DataFormatString = "{0:#.00}")]
        public decimal Šildymas { get; set; }

        [Required(ErrorMessage = "Privalomas")]
        [DisplayName("TV ir internetas")]
        [DisplayFormat(DataFormatString = "{0:#.00}")]
        public decimal TvIrInterntetas { get; set; }

        [Required(ErrorMessage = "Privalomas")]
        [DisplayName("Bendri mokesčiai")]
        [DisplayFormat(DataFormatString = "{0:#.00}")]
        public decimal BendriMokesciai { get; set; }

        [Required(ErrorMessage = "Privalomas")]
        [DisplayName("Kita")]
        [DisplayFormat(DataFormatString = "{0:#.00}")]
        public decimal Kita { get; set; }

        [UIHint("Metai")]
        [DisplayName("Metai")]
        public MetaiViewModel Metai { get; set; }


        [DisplayName("Menuo")]
        public MenesiaiViewModel Menesiai { get; set; }


        [DisplayName("Savaite")]
        public SavaitesViewModel Savaites { get; set; }


        [DisplayName("Diena")]
        public DienosViewModel Dienos { get; set; }
    }
}