using Cinema.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Models
{

public class Genero {

public Genero(int id,string nombre)
{
    this.Id=id,
    this.nombre=nombre
}

 public int Id { get; set; }
 public string nombre { get; set; }
}

}