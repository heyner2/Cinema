using Cinema.Models.Contratos;
using Cinema.Models.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Models
{
    public class PeliculasRepositorio : IPelicula
    {    
 
     public bool CrearPelicula(Pelicula pelicula){
            if (!Peliculas.PeliculasLista.Contains(pelicula))
            {
                Peliculas.PeliculasLista.Add(pelicula);
                return true;
            }
            else
            {
                return false;
            }
        }

     public (bool existe,Pelicula pelicula) ObtenerPelicula(string titulo){

     //Cosulta hecha con LINQ
     Pelicula pelicula=(from p in Peliculas.PeliculasLista where (p.Titulo==titulo) 
      orderby p.Titulo ascending select p ).FirstOrDefault();
     /*
     var peli=from p in Peliculas.PeliculasLista.Where(p=>p.Titulo==titulo) select p;
      */
       if(pelicula!=null){
           return (true, pelicula);
       }else{
           return (false,null);
       }  
     }  

     public bool EditarPelicula(Pelicula pelicula){
       return true;
     }

     public bool EliminarPelicula(string name){
      return true;
     }

     public List<Pelicula> ObtenerPeliculas(){
        return Peliculas.PeliculasLista;
     }


    }
}
