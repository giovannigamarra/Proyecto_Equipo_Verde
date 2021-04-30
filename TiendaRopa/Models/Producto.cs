using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TiendaRopa.Models
{
    [Table("t_libro")]
    public class Producto
    {

    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Display(Name="Identificador")] 
    [Column("id")]
    public int ID { get; set; }

    [Required(ErrorMessage="Debe ingresar el nombre del libro a registrar")]
    [Display(Name="Nombre")] 
    [Column("name")]
    public string nombre { get; set; }

    [Required(ErrorMessage="Debe ingresar el autor del libro a registrar")]
    [Display(Name="Autor del libro")] 
    [RegularExpression(@"^[a-zA-Z ]*$", ErrorMessage = "Solo se permiten letras")]
    [Column("autor")]
    public string autor { get; set; }

    [Required(ErrorMessage="Debe ingresar el idioma del libro a registrar")]
    [Display(Name="Idioma del producto")] 
    [Column("idioma")]
    public string idioma { get; set; }

    [Required(ErrorMessage="Debe ingresar el ISBN del libro a registrar")]
    [Display(Name="ISBN del libro")] 
    [Column("isbn")]
    public string isbn { get; set; }

    [Required(ErrorMessage="Debe ingresar la editorial del libro a registrar")]
    [Display(Name="Editorial del libro")] 
    [Column("editorial")]
    public string editorial { get; set; }

    [Required(ErrorMessage="Debe ingresar el precio del libro a registrar")]
    [Display(Name="Precio del producto")] 
    [Column("precio")]
    public Decimal precio { get; set; }

    [Required(ErrorMessage="Debe ingresar las paginas del libro a registrar")]
    [Display(Name="Paginas del libro")] 
    [Column("pages")]
    public int? pagina { get; set; }

    [Required(ErrorMessage="Debe ingresar la descripcion del libro a registrar")]
    [Display(Name="Descripcion del libro")] 
    [Column("descripcion")]
    public string descripcion { get; set; }

    [Required(ErrorMessage="Debe ingresar la imagen del libro a registrar")]
    [Display(Name="URL de imagen del libro")] 
    [Column("imagen")]
    public string imagen { get; set; }


    [NotMapped]
    public String Respuesta { get; set; }

    }
}