using System.ComponentModel.DataAnnotations;

namespace FerreteriaAPI.Areas
{
    public class Persona
    {
        [Key]
        public int Id { get; set; }


        [MaxLength(40)]
        [Display(Name ="Nombres")]
        public string Nombre { get; set; }


        [MaxLength(40)]
        [Display(Name = "Apellidos")]
        public string Apellido { get; set; }


        [MaxLength(40)]
        [Display(Name = "Dirección")]
        public string? Direccion { get; set; }


        [MaxLength(40)]
        [Display(Name = "Teléfono")]
        public string? Telefono { get; set; }


        [MaxLength(40)]
        [Display(Name = "Correo electrónico")]
        public string? Email { get; set; }


        [MaxLength(40)]
        public int CiudadId { get; set; }

    }
}
