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

     public Ticket  ReservarEspacio(Pelicula pelicula);

     public List<string> ObtenerGeneros();

    }
}
