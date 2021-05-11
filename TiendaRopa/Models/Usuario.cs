using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TiendaRopa.Models
{
    [Table("t_usuario")]
    public class Usuario
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int ID { get; set; }

        [Required(ErrorMessage = "Por favor ingrese los nombres")]
        [Display(Name="Nombres Completos")]
         [Column("name")]
        public String nombre { get; set; }

        [Required(ErrorMessage = "Por favor ingrese los apellidos")]
        [Display(Name="Apellidos Completos")]
        [Column("apellido")]
        public String apellidos { get; set; }

        [Required(ErrorMessage = "Por favor ingrese su direccion")]
        [Display(Name="Direccion del usuario")]
        [Column("direccion")]
        public String direccion { get; set; }

        [Required(ErrorMessage = "Por favor ingrese su distrito")]
        [Display(Name="Distrito del usuario")]
        [Column("distrito")]
        public String distrito { get; set; }

        [Required(ErrorMessage = "Por favor ingrese su sexo")]
        [Display(Name="Sexo del usuario")]
        [Column("sexo")]
        public String sexo { get; set; }

        [Required(ErrorMessage = "Por favor ingrese su email")]
        [Display(Name="Email del usuario")]
        [Column("email")]
        public String Email { get; set; }

        [Required(ErrorMessage = "Por favor ingrese su edad")]
        [Display(Name="Edad del usuario")]
        [Column("edad")]
        public int edad { get; set; }

        [Required(ErrorMessage = "Por favor ingrese su numero de celular")]
        [Display(Name="Celular del usuario")]
        [Column("celular")]
        public String celular { get; set; }

        [NotMapped]
        public String Respuesta { get; set; }

    }
}