using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TiendaRopa.Models
{
    [Table("t_ropa")]
    public class Producto
    {

    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Display(Name="Identificador")] 
    [Column("id")]
    public int ID { get; set; }

    [Required(ErrorMessage="Debe ingresar el nombre del ropa a registrar")]
    [Display(Name="Nombre")] 
    [Column("name")]
    public string nombre { get; set; }

    [Required(ErrorMessage="Debe ingresar el modelo del ropa a registrar")]
    [Display(Name="Modelo del ropa")] 
    [RegularExpression(@"^[a-zA-Z ]*$", ErrorMessage = "Solo se permiten letras")]
    [Column("modelo")]
    public string modelo { get; set; }

    [Required(ErrorMessage="Debe ingresar el marca del ropa a registrar")]
    [Display(Name="Marca del producto")] 
    [Column("marca")]
    public string marca { get; set; }

    [Required(ErrorMessage="Debe ingresar el SKU del ropa a registrar")]
    [Display(Name="SKU del libro")] 
    [Column("sku")]
    public string sku { get; set; }

    [Required(ErrorMessage="Debe ingresar la talla del ropa a registrar")]
    [Display(Name="Talla del ropa")] 
    [Column("talla")]
    public string talla { get; set; }

    [Required(ErrorMessage="Debe ingresar el precio del ropa a registrar")]
    [Display(Name="Precio del producto")] 
    [Column("precio")]
    public Decimal precio { get; set; }

    [Required(ErrorMessage="Debe ingresar las cantidad del ropa a registrar")]
    [Display(Name="Cantidad del ropa")] 
    [Column("pages")]
    public int? pages { get; set; }

    [Required(ErrorMessage="Debe ingresar la descripcion del ropa a registrar")]
    [Display(Name="Descripcion del ropa")] 
    [Column("descripcion")]
    public string descripcion { get; set; }

    [Required(ErrorMessage="Debe ingresar la imagen del ropa a registrar")]
    [Display(Name="URL de imagen de la ropa")] 
    [Column("imagen")]
    public string imagen { get; set; }


    [NotMapped]
    public String Respuesta { get; set; }

    }
}