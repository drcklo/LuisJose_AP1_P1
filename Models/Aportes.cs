using System.ComponentModel.DataAnnotations;

namespace LuisJose_AP1_P1.Models
{
    public class Aportes
    {
        [Key]
        public int AportesId { get; set; }

        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "El campo Persona no puede contener numeros")]
        [Required(ErrorMessage = "Este campo es requerido para hacer su aporte")]
        public string? Persona { get; set; }

        [Required(ErrorMessage = "Este campo es requerido para hacer su aporte")]
        public string? Observacion { get; set; }

        [RegularExpression(@"[\d]",ErrorMessage = "El campo Monto solo puede tener numeros")]
        [Required(ErrorMessage = "Este campo es requerido para hacer su aporte")]
        public int Monto { get; set; }

        [Required(ErrorMessage = "Este campo es requerido para hacer su aporte")]
        public DateTime Fecha {get;set;}
    }
}


