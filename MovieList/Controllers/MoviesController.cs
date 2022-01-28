using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieList.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Add()
        {
            return View();
        }
    }
}
