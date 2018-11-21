using System;
using System.Collections.Generic;

namespace WebApiPrueba.Models
{
    public partial class Contact
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string ImageUrl { get; set; }
        public int Type { get; set; }
        public int? IdAgenda { get; set; }

        public Agenda IdAgendaNavigation { get; set; }
    }
}
