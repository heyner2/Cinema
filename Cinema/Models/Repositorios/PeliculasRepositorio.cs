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
      orderby p.Titulo ascending select p ).toList();
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
              var peli =(from p in Peliculas.PeliculasLista where (p.titulo == pelicula.titulo)
              select p).FirstOrDefault(); 
              int index=  peliculas.PeliculasLista.IndexOf(peli);
              peliculas.PeliculasLista.set(index,peli);
              return true;
           }else{
               return false;
           }
       }else{
           return false;
       }
     }

     public bool EliminarPelicula(string name){
     if(!string.isEmptyOrNull(name)){         
       var pelicula=(from p in peliculas.PeliculasLista where (p.titulo==name)
        select p ).FirstOrDefault();
         if(pelicula==null){
             return false;
         }else{
             peliculas.PeliculasLista.Remove(pelicula);
             return true;
         }
     }
     }

     public List<Pelicula> ObtenerPeliculas(){
        return Peliculas.PeliculasLista;
     }


    }
}
