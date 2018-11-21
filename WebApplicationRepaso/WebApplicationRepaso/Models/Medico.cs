using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationRepaso.Models
{
    public class Medico
    {
        public int Id { get; set; }
        [Required]
        public int NumeroColegiado { get; set; }
        public string Nombre { get; set; }
        public string Especialidad { get; set; }
        public List<PacientesMedicos> PacientesMedicos { get; set; }
    }
}
