using System.ComponentModel.DataAnnotations;

namespace FerreteriaAPI.Areas
{
    public class Producto
    {
        [Key]
        public int Id { get; set; }


        [MaxLength(30)]
        public string Referencia { get; set; }


        [MaxLength(30)]
        public string Nombre { get; set; }


        [MaxLength(20)]
        [Display(Name = "Costo de la compra")]
        public decimal? CostoCompra { get; set; }


        [MaxLength(20)]
        [Display(Name = "Costo de la venta")]
        public decimal? CostoVenta { get; set; }


        [MaxLength(20)]
        public int CategoriaId { get; set; }


        [MaxLength(20)]
        public string? Marca { get; set; }


        [MaxLength(20)]
        public int EstadoProductoId { get; set; }


        [MaxLength(20)]
        public int? MedidaId { get; set; }


        [MaxLength(30)]
        [Display(Name = "Disponibilidad de Stock")]
        public string? Stock { get; set; }


    }
}
