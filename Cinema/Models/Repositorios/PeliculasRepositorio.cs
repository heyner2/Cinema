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


     public (bool existe, List<Pelicula> pelicula) ObtenerPelicula(string titulo){

     //Cosulta hecha con LINQ
     List<Pelicula> pelicula=(from p in Peliculas.PeliculasLista where (p.Titulo==titulo) 
      orderby p.Titulo ascending select p ).ToList();
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
       if(pelicula!=null){
           if(Peliculas.PeliculasLista.Contains(pelicula)){
              var peli =(from p in Peliculas.PeliculasLista
              select p).ToList();
                 
           foreach(var p in peli)
                    {
                        if (p.Titulo == pelicula.Titulo)
                        {
                            p.Titulo = pelicula.Titulo;
                        }
                    }
                    
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

        (bool existe, Pelicula pelicula) IPelicula.ObtenerPelicula(string titulo)
        {
            throw new NotImplementedException();
        }
    }
}
