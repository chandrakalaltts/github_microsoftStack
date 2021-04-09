using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstMVCMovie.Models;
using FirstMVCMovie.Data;
using Microsoft.EntityFrameworkCore;

namespace FirstMVCMovie.Controllers
{
    public class MovieController : Controller
    {
        private readonly FirstMVCMovieContext _context;

        public MovieController(FirstMVCMovieContext context)
        {
            _context = context;
        }
        // GET: Movies/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = new Movie { };

            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }
    }
}
