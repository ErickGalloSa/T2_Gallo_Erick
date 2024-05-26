using System.ComponentModel.DataAnnotations;

namespace T2_Gallo_Erick.Models
{
    public class Distribuidor
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre del Distribuidor es obligatorio")]
        public String NombreDistribuidor { get; set; }

        [Required(ErrorMessage = "La razon social del Distribuidor es obligatorio")]
        public String RazonSocial { get; set; }

        [Required(ErrorMessage = "El telefono del Distribuidor es obligatorio")]
        public String Telefono { get; set; }

        [Required(ErrorMessage = "El año de operación del Distribuidor es obligatorio")]
        public DateTime AnioInicioOperacion { get; set; }

        [Required(ErrorMessage = "El contacto del Distribuidor es obligatorio")]
        public String Contacto { get; set; }
        
    }
}
