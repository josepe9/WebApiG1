using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApiG1.WebApi.Models
{
    public class Ciudad
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(45)]
        public string Nombre { get; set; }

        [Required]
        public int DeptoId { get; set; }

        public Depto Depto { get; set; }

        public ICollection<Persona> Personas { get; set; }
    }
}
