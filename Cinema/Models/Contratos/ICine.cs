using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Models.Contratos
{
   public interface ICine
    {
    
     public void Open();

     public void Close();

     public (bool espacio, Ticket ticket)  ReservarEspacio(Pelicula pelicula,int espectadores);

     public List<Generos> ObtenerGeneros();

      public  int ValidarSala(Pelicula Pelicula);

      public List<int> ValidarSalas();

     public List<string> ObtenerHorarios();

     

    }
}
