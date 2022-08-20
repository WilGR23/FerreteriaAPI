using System.ComponentModel.DataAnnotations;

namespace FerreteriaAPI.Areas
{
    public class Categoria
    {
        [Key]
        [MaxLength(20)]
        public int Id { get; set; }


        [MaxLength(30)]
        public string Nombre { get; set; }
    }
}
