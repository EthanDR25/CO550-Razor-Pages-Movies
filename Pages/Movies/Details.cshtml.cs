using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CO550_ASP_Razor_Pages_Movies.Data;
using CO550_ASP_Razor_Pages_Movies.Models;

namespace CO550_ASP_Razor_Pages_Movies.Pages.Movies
{
    public class DetailsModel : PageModel
    {
        private readonly CO550_ASP_Razor_Pages_Movies.Data.ApplicationDbContext _context;

        public DetailsModel(CO550_ASP_Razor_Pages_Movies.Data.ApplicationDbContext context)
        {
            _context = context;
        }

      public Movie Movie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Movie == null)
            {
                return NotFound();
            }

            var movie = await _context.Movie.FirstOrDefaultAsync(m => m.ID == id);
            if (movie == null)
            {
                return NotFound();
            }
            else 
            {
                Movie = movie;
            }
            return Page();
        }
    }
}
