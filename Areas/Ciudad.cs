using System.ComponentModel.DataAnnotations;

namespace FerreteriaAPI.Areas
{
    public class Ciudad
    {
        [Key]
        [MaxLength(20)]
        public int Id { get; set; }


        [MaxLength(30)]
        public string Nombre { get; set; }


        [MaxLength(20)]
        public int DeptoId { get; set; }


        [MaxLength(5)]
        public int CodPostal { get; set; }
    }
}
