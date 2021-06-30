using Cinema.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Models
{
    public class Ticket
    {
        public string Id { get; set; }

        public decimal Total  { get; set; }

        public int Asientos { get; set; }

        public string Titulo { get; set; }

        public DateTime FechaDePelicula { get; set; }

        public Turno Turno { get; set; }
    }
}
