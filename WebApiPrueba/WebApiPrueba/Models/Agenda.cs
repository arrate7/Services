using System;
using System.Collections.Generic;

namespace WebApiPrueba.Models
{
    public partial class Agenda
    {
        public Agenda()
        {
            Contact = new HashSet<Contact>();
        }

        public int Id { get; set; }
        public string Propietario { get; set; }

        public ICollection<Contact> Contact { get; set; }
    }
}
