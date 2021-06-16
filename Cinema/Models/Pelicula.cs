using Cinema.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Models
{
    public class Pelicula
    {
        public int Duracion { get; set; }

        public string Titulo { get; set; }

        public string Director { get; set; }

        public DateTime ReleaseDate { get; set; }

        public string Protagonista { get; set; }

        public Genero Genero { get; set; }

        public decimal Precio { get; set; }

        public string Turno { get; set; }

        public Estado Estado { get; set; }
    }
}
