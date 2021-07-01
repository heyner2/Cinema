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

        public static bool Validacion {get; set;}
        
        public static int[] asientos = {15,15,15,15,15,15,15,15};


        public bool Open(DateTime time){

           int horaActual=DateTime.Now.Hour;
           if(horaActual>6){
               Validacion=true;
               return Validacion;
           }else{
            Validacion=false;
               return Validacion;
           }            
        }


     public void Close(bool open){
        int horaActual=DateTime.Now.Hour;
         if(open){
            if(horaActual>23 && horaActual<6){
                Validacion=false;
                return Validacion;
            }else{
                 Validacion=true;
                return false;
            }
         }
       
      
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

        public int ValidarSala(Pelicula Pelicula)
        {
         int asientosDisponibles=   asientos[pelicula.Sala-1];  
         
         return asientosDisponibles;
        }

        public List<int> ValidarSalas()
        {
            List<int> asientosDisponibles =new List<int>();
          for(var i=0;i <asientos.Length;i++){
            asientosDisponibles.Add(asiento[i]);
          }  
       
         
         return asientosDisponibles;
        }


       
        public List<string> ObtenerHorarios()
        {
           List<string> turnos=new List<string>(){
               "Matutino","Vespertino","Nocturno";
           }

        }
    }
}
