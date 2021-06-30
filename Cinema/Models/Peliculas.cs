using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Models
{
public class Peliculas{

public static List<Pelicula> PeliculasLista =new List<Pelicula>(){
new Pelicula(120,"El conjuro", "Henry Castro",DateTime.Parse("2021/04/25"),"Patrick Wilson, Vera Farmiga",
            Genero.Terror,3.50m,Enum.Turno.Nocturno,Enum.Estado.Activo,"~/Images/Conjuro.png",1),
new Pelicula(150,"Los Croods", "Mario Rivera",DateTime.Parse("2021/05/23"),"Roberto Acosta, Karla Ortiz",
            Genero.Comedia,3.00m,Enum.Turno.Matutino,Enum.Estado.Activo,"~/Images/croods.png",2),
new Pelicula(105,"Cruela2021", "Estela Smith",DateTime.Parse("2021/06/01"),"Emma Stone",
            Genero.Comedia,2.50m,Enum.Turno.Vespertino,Enum.Estado.Activo,"~/Images/Cruela2021.png",3),
new Pelicula(105,"Godzilla vs King Kong", "Adam Windgard",DateTime.Parse("2021/04/23"),"Millie Brown",
            Genero.Accion,2.00m,Enum.Turno.Vespertino,Enum.Estado.Activo,"~/Images/KingVSGodzilla.png",4),
new Pelicula(105,"Mortal Kombat", "Simon mcquoid",DateTime.Parse("2021/06/01"),"Joe Taslin",
            Genero.Accion,1.75m,Enum.Turno.Nocturno,Enum.Estado.Activo,"~/Images/MortalKombat.png",5),
new Pelicula(105,"mulan", "Niki Karo",DateTime.Parse("2021/05/11"),"Liu Yifei",
            Genero.Accion,2.75m,Enum.Turno.Vespertino,Enum.Estado.Activo,"~/Images/mulan.png",6),     
new Pelicula(105,"raya y el ultimo dragon", "Carlos Estrada",DateTime.Parse("2021/03/15"),"Kelly Tran",
            Genero.Accion,2.00m,Enum.Turno.Matutino,Enum.Estado.Activo,"~/Images/rayaAndTheDragon.png",7),
new Pelicula(105,"WonderWoman1984", "Patty Jenkins",DateTime.Parse("2021/035/19"),"Gal Gadot",
            Genero.Accion,3.00m,Enum.Turno.Nocturno,Enum.Estado.Activo,"~/Images/WonderWoman1984.png",8)                                                                                   
    };


public Peliculas()
{    
}


}

}