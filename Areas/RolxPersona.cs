using System.ComponentModel.DataAnnotations;

namespace FerreteriaAPI.Areas
{
    public class RolxPersona
    {
        [Key]
        [MaxLength(20)]
        public int Id { get; set; }


        [MaxLength(20)]
        public int RolId { get; set; }


        [MaxLength(20)]
        public int PersonaId { get; set; }
    }
}
