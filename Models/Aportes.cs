using System.ComponentModel.DataAnnotations;

namespace Alexander_AP1_P1.Models
{
    public class Aportes
    {
        [Key]
        public int AporteId { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;
        [Required(ErrorMessage ="El campo persona es obligatorio")]
        [StringLength(60, ErrorMessage ="El campo persona no debe de pasar de 60 caracteres")]
        public string Persona { get; set; }
        [Required(ErrorMessage = "El campo observacion es obligatorio")]
        [StringLength(100, ErrorMessage = "El campo observacion no debe de pasar de 100 caracteres")]
        public string Observacion { get; set; }
        [Required(ErrorMessage = "El campo monto es obligatorio")]
        public decimal Monto { get; set; }  
    }
}
