using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApiG1.WebApi.Models
{
    public class Depto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(45)]
        public string Nombre { get; set; }

        public ICollection<Ciudad> Ciudades { get; set; }


    }
}
