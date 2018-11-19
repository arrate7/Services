using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModelosEntidadRelacion.Models
{
    public class Adress
    {
        public int Id { get; set; }
        public string Calle { get; set; }
        //SI LE INDICAMOS EL NOMBRE DE LA CLASE+ID VISUAL AUTOMATICAMENTE LO REFERENCIA COMO FOREIGN KEY
        public int StudentId { get; set; }
    }
}
