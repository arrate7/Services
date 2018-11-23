using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationServices.Models
{
    public class Response
    {
        public int Id { get; set; }
        public int Count { get; set; }
        public string Next { get; set; }
        public string Previous { get; set; }
        public List<Personaje> Results { get; set; }
    }
}
