using System.ComponentModel.DataAnnotations;

namespace FerreteriaAPI.Areas
{
    public class FacDetalle
    {
        [Key]
        [MaxLength(20)]
        public int Id { get; set; }


        [MaxLength(20)]
        public int ProductoId { get; set; }


        [MaxLength(20)]
        public int Cantidad { get; set; }


        [MaxLength(20)]
        public int Valor { get; set; }


        [MaxLength(50)]
        public string Detalle { get; set; }



        [MaxLength(20)]
        public int FacEncabezadoId { get; set; }


    }
}
