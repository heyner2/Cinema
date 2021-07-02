using Cinema.Models;
using Cinema.Models.Contratos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Controllers
{
    public class CineController : Controller
    {

        private ICine _repo;

        public CineController(ICine repo)
        {
            _repo = repo;
        }

       
    }
}
