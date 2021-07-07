using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Models.Contratos
{
   public interface IPelicula
    {

     public bool CrearPelicula(Pelicula pelicula);

     public (bool existe,Pelicula pelicula) ObtenerPelicula(string titulo);  

     public bool EditarPelicula(Pelicula pelicula);

     public bool EliminarPelicula(string nombre);

     public List<Pelicula> ObtenerPeliculas();
       
    }
}
