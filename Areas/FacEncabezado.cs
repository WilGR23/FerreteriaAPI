using System.ComponentModel.DataAnnotations;

namespace FerreteriaAPI.Areas
{
    public class FacEncabezado
    {
        [Key]
        [MaxLength(20)]
        public int Id { get; set; }


        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd hh:mm}", ApplyFormatInEditMode = false)]
        public DateTime Fecha { get; set; }


        [MaxLength(20)]
        public int PersonaId { get; set; }


        [MaxLength(20)]
        public int MovimientoId { get; set; }
    }
}
