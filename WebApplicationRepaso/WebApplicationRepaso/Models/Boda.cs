using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationRepaso.Models
{
    public class Boda
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string Lugar { get; set; }
        public Pareja Pareja { get; set; }

    }
}
