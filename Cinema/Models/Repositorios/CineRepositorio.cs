using Cinema.Models.Contratos;
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
            return true;
        }

     public void Close(bool open){

     }

     public (bool espacio, Ticket ticket) ReservarEspacio(Pelicula pelicula, int espectadores){
      
         if(pelicula!=null){

        var peli=(from p in Peliculas.PeliculasLista where (p.Titulo==pelicula.Titulo) 
        select p).FirstOrDefault();

        if(asientos[peli.Sala-1]>=espectadores){
        asientos[peli.Sala-1]= asientos[peli.Sala-1]-espectadores; 

        Ticket tkt =new Ticket();

        string guid = Convert.ToString(Guid.NewGuid());
        guid= guid.Replace("-","");
        guid = guid.Replace("/", "");
        tkt.Id=guid;
        tkt.Total=(peli.Precio*espectadores);
        tkt.Asientos=espectadores;
        tkt.Titulo=peli.Titulo;
        tkt.FechaDePelicula=DateTime.Now;
        tkt.Turno=peli.Turno;
        

        return(true, tkt); 
        }else{
           return(false, null);  
        }

            }
            else
            {
                return (false, null);
            }
     }

     public List<Generos> ObtenerGeneros(){

            List<Generos> generos = new List<Generos>(){
          new Generos(Genero.Comedia,"Comedia"),
          new Generos(Genero.Terror,"Terror"),
          new Generos(Genero.Romance,"Romance"),
         new Generos(Genero.Accion,"Accion"),
        new Generos(Genero.Ciencia_Ficcion,"Ciencia Ficcion")
      };

      return generos;

     }

        public bool ValidarSala()
        {
            throw new NotImplementedException();
        }

        public void CalcularAsientos()
        {
            throw new NotImplementedException();
        }

        public List<string> ObtenerHorarios()
        {
            throw new NotImplementedException();
        }
    }
}
