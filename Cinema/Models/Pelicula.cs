﻿using Cinema.Models.Enum;
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
     Genero Genero, decimal Precio, Turno Turno, Estado estado, string RutaImagen)
    {
        
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
        
    }

}
