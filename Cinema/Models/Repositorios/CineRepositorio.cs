using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Models.Repositorios
{
    public class CineRepositorio : ICine
    {
        public static int Salas = 7;
        
        public static int[] asientos = {15,15,15,15,15,15,15,15};


        public bool Open(DateTime time){

        }

     public void Close(bool open){

     }

     public (bool espacio, Ticket ticket) ReservarEspacio(Pelicula pelicula, int espectadores){
      
         if(pelicula!=null){

        var peli=(from p in Peliculas.PeliculasLista where (p.titulo==pelicula.titulo) 
        select p).FirstOrDefault();

        if(asientos[peli.Salas-1]>=espectadores){
        asientos[peli.Salas-1]= asientos[peli.Salas-1]-espectadores; 

        Ticket tkt =new Ticket();

        string guid=new GUID();
        guid.Replace("-","");
        guid.Replace("/","");
        tkt.id=guid;
        tkt.precio=(peli.precio*espectadores);
        tkt.asientos=espectadores;
        tkt.titulo=peli.titulo;
        tkt.FechaDePelicul=DateTime.Now();
        tkt.turno=peli.turno();
        

        return(true, tkt); 
        }else{
           return(false, null);  
        }
         
         }
     }

     public List<Genero> ObtenerGeneros(){

    List<Genero> generos =new List<Genero>(){
          new Genero(Genero.Comedia,"Comedia"),
          new Genero(Genero.Terror,"Terror"),
          new Genero(Genero.Romance,"Romance"),
         new Genero(Genero.Accion,"Accion"),
        new Genero(Genero.Ciencia_Ficcion,"Ciencia Ficcion") 
      }

      return generos;

     }
  
    }
}
