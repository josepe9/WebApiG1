using System;
using System.ComponentModel.DataAnnotations;

namespace WebApiG1.WebApi.Models
{
    public class Persona
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(15)]
        public string Documento { get; set; }

        [Required]
        [StringLength(45)]
        public string Nombre { get; set; }

        [StringLength(45)]
        [Display(Name = "Dirección")]
        public string Direccion { get; set; }

        [Required]
        public int CiudadID { get; set; }

        [StringLength(45)]
        public string Email { get; set; }

        [StringLength(20)]
        [Display(Name = "Teléfono")]
        public string Telefono { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Fecha nacimiento")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}",ApplyFormatInEditMode = true)]
        public DateTime Fechanac { get; set; }

        public Ciudad Ciudad { get; set; }
    }
}
