using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Models
{
    public class Users
    {
        [Required]
       
        public string nombre { get; set; }
        public string pass { get; set; }
        public string rol { get; set; }

        public Users(string nombre, string pass,string rol)
        {
            this.nombre = nombre;
            this.pass = pass;
            this.rol = rol;
        }
    }
}
