using System.ComponentModel.DataAnnotations;

namespace LuisJose_AP1_P1.Models
{
    public class Aportes
    {
        [Key]
        public int AportesId { get; set; }

        [RegularExpression(@"^a-zA-z$")]
        [Required(ErrorMessage = "Este campo es requerido para hacer su aporte")]
        public string? Persona{ get; set; }

        [RegularExpression(@"^a-zA-z$")]
        [Required(ErrorMessage = "Este campo es requerido para hacer su aporte")]
        public string? Observacion { get; set; }

        [RegularExpression(@"/d")]
        [Required(ErrorMessage = "Este campo es requerido para hacer su aporte")]
        public int Monto{ get; set; }
    }
}


