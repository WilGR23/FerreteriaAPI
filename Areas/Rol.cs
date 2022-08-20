using System.ComponentModel.DataAnnotations;

namespace FerreteriaAPI.Areas
{
    public class Rol
    {
        [Key]
        [MaxLength(20)]
        public int Id { get; set; }


        [MaxLength(30)]
        public string Nombre { get; set; }
    }
}
