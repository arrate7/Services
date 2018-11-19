using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModelosEntidadRelacion.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        //PROPIEDAD DE NAVEGACIÓN PARA ACCEDER A LOS ATRIBUTOS DE ADRESS
        public Adress Adress { get; set; }
    }
}

