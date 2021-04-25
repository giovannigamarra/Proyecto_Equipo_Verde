using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TiendaRopa.Models
{ [Table("t_ropa")]
   public class Producto
    {

    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Display(Name="Identificador")] 
    [Column("id")]
    public int ID { get; set; }

    [Required(ErrorMessage="Debe ingresar el nombre de la ropa a registrar")]
    [Display(Name="Nombre")] 
    [Column("name")]
    public string nombre { get; set; }

    [Required(ErrorMessage="Debe ingresar la marca de la ropa a registrar")]
    [Display(Name="Marca")] 
    [RegularExpression(@"^[a-zA-Z ]*$", ErrorMessage = "Solo se permiten letras")]
    [Column("marca")]
    public string autor { get; set; }

    [Required(ErrorMessage="Debe ingresar el tipo de producto  a registrar")]
    [Display(Name="Tipo del producto")] 
    [Column("tipo")]
    public string idioma { get; set; }

    [Required(ErrorMessage="Debe ingresar el SKU de la ropa a registrar")]
    [Display(Name="SKU de la ropa")] 
    [Column("sku")]
    public string isbn { get; set; }

    [Required(ErrorMessage="Debe ingresar modelo de la ropa a registrar")]
    [Display(Name="Modelo de la ropa")] 
    [Column("modelo")]
    public string editorial { get; set; }

    [Required(ErrorMessage="Debe ingresar el precio de la ropa a registrar")]
    [Display(Name="Precio del producto")] 
    [Column("precio")]
    public Decimal precio { get; set; }

    [Required(ErrorMessage="Debe ingresar la cantidad de ropas a registrar")]
    [Display(Name="Cantidad de ropas")] 
    [Column("cantidad")]
    public int? pagina { get; set; }

    [Required(ErrorMessage="Debe ingresar la descripcion de la ropa a registrar")]
    [Display(Name="Descripcion de la ropa")] 
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