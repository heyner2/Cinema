using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Models.Contratos
{
    interface ICine
    {
    
     public bool Open(DateTime time);

     public void Close(bool open);

     public (bool espacio, Ticket ticket)  ReservarEspacio(Pelicula pelicula,int espectadores);

     public List<Generos> ObtenerGeneros();

      public  int ValidarSala(Pelicula Pelicula);

      public List<int> ValidarSalas(Pelicula Pelicula);

     public List<string> ObtenerHorarios();

     

    }
}
