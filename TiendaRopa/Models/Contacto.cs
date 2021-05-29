using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TiendaRopa.Models
{
     [Table("Contacto")]
    public class Contacto
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int ID { get; set; }

        [Required(ErrorMessage = "Por favor, ingrese nombre")]
        [Display(Name="Nombre")]
        [Column("Nombre")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Por favor, ingrese su apellido")]
        [Display(Name="Apellido")]
        [Column("Apellido")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "Por favor, ingrese un e-mail para contactarlo")]
        [RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", ErrorMessage = "No es un e-mail válido")]
        [Display(Name="Email")]
        [Column("Email")]
        public string Email { get; set; }
        
        [Required(ErrorMessage = "Debe ingresar un número de teléfono")]
        [StringLength(9)]
        [RegularExpression(@"[0-9]{9}", ErrorMessage = "No es un número de teléfono válido")]
        // [DataType(DataType.PhoneNumber)]
        [Display(Name="Teléfono")]
        [Column("Telefono")]
        public string Telefono { get; set; }

        [Display(Name="Asunto")]
        [Column("Asunto")]
        public string Asunto { get; set; }

        [Required(ErrorMessage = "Por favor, ingrese un mensaje")]
        [Display(Name="Mensaje")]
        [Column("Mensaje")]
        public string Mensaje { get; set; }

        [NotMapped]
        public string Mensajes { get; set; }

    }
}