using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Models.Contratos
{
    interface ISala
    {

     public bool ValidarSala();

     public void CalcularAsientos();

    public void ReservarAsientos();

    public bool LiberarAsientos();

    public List<string> ObtenerHorarios();
    }
}
