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


        public (bool existe, Pelicula pelicula) ObtenerPelicula(string titulo) {

            Pelicula peli = null;

            if (String.IsNullOrEmpty(titulo))
            {

            }
            else
            {
                List<Pelicula> pelicula = (from p in Peliculas.PeliculasLista
                                           where (p.Titulo.Equals(titulo))
|| (p.Titulo.ToLower().Equals(titulo.ToLower())) || (p.Titulo.ToLower().Contains(titulo.ToLower()))
                                           orderby p.Titulo ascending
                                           select p).ToList();

                 peli = (from p in pelicula where (p.Titulo == titulo) || (p.Titulo.ToLower().Contains(titulo.ToLower())) select p).FirstOrDefault();

            }
            //Cosulta hecha con LINQ

            if (peli!=null){
           return (true, peli);
       }else{
           return (false,null);
       }  
     }  

     public bool EditarPelicula(Pelicula pelicula){
       if(pelicula!=null){
           if(Peliculas.PeliculasLista.Contains(pelicula)){
              var peli =(from p in Peliculas.PeliculasLista
               where (p.Titulo== pelicula.Titulo)  select p).FirstOrDefault();

                    peli.Titulo = pelicula.Titulo;
                    peli.Precio = pelicula.Precio;
                    peli.Estado = pelicula.Estado;
                    peli.Turno  =  pelicula.Turno;                                           
                    
              return true;
           }else{
               return false;
           }
       }else{
           return false;
       }
     }

     public bool EliminarPelicula(string name){
     if(!string.IsNullOrEmpty(name)){         
       var pelicula=(from p in Peliculas.PeliculasLista where (p.Titulo==name)
        select p ).FirstOrDefault();
         if(pelicula==null){
             return false;
         }else{
             Peliculas.PeliculasLista.Remove(pelicula);
             return true;
         }
            }
            else
            {
                return false;
            }
     }

     public List<Pelicula> ObtenerPeliculas(){
        return Peliculas.PeliculasLista;
     }


    }
}
