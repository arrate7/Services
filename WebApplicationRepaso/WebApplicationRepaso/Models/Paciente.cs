using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationRepaso.Models
{
    public class Paciente
    {
        public int Id { get; set; }
        [Required]
        public int NumSeguridadSocial { get; set; }
        public string Nombre { get; set; }
        public List<PacientesMedicos> PacientesMedicos { get; set; }
    }
}
