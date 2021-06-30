using Cinema.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Models
{

public class Generos {

public Generos(Genero id,string nombre)
{
            this.Id = id;
    this.nombre = nombre;
}

 public Genero Id { get; set; }
 public string nombre { get; set; }
}

}