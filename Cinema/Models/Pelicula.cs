using Cinema.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Models
{
    public class Pelicula
    {

    public Pelicula()
    {
        
    }

     public Pelicula(int Duracion, string Titulo,string Director, DateTime ReleaseDate, string Protagonista,
     Genero Genero, decimal Precio, Turno Turno, Estado estado, string RutaImagen, int Sala)
    {
            this.Duracion = Duracion;
            this.Titulo = Titulo;
            this.Director = Director;
            this.ReleaseDate = ReleaseDate;
            this.Protagonista = Protagonista;
            this.Genero = Genero;
            this.Precio = Precio;
            this.Turno = Turno;
            this.Estado = estado;
            this.RutaImagen = RutaImagen;
            this.Sala = Sala;

    }

        public int Duracion { get; set; }

        public string Titulo { get; set; }

        public string Director { get; set; }

        public DateTime ReleaseDate { get; set; }

        public string Protagonista { get; set; }

        public Genero Genero { get; set; }

        public decimal Precio { get; set; }

        public Turno Turno { get; set; }

        public Estado Estado { get; set; }

        public string RutaImagen { get; set; }

        public int Sala { get; set; }
        
    }

}
