using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TiendaRopa.Models
{
    [Table("t_orden_detail")]
    public class OrdenDetail
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int ID { get; set; }

        [Column("productoid")]
        public int productoID { get; set; }


        [Display(Name="Email")] 
        [Column("email")]
        public String Email { get; set; }

        [Display(Name="Nombre")] 
        [Column("nombre")]
        public String Nombre { get; set; }

        [Display(Name="Cantidad")] 
        [Column("cantidad")]
        public Decimal Cantidad { get; set; }

        [Display(Name="Precio del producto")] 
        [Column("precio")]
        public Decimal Precio { get; set; }
    }
}