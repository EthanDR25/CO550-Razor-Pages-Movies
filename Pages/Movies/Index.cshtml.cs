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
    public class IndexModel : PageModel
    {
        private readonly CO550_ASP_Razor_Pages_Movies.Data.ApplicationDbContext _context;

        public IndexModel(CO550_ASP_Razor_Pages_Movies.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Movie != null)
            {
                Movie = await _context.Movie.ToListAsync();
            }
        }
    }
}
