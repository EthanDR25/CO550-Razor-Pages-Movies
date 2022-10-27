using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CO550_ASP_Razor_Pages_Movies.Data;
using CO550_ASP_Razor_Pages_Movies.Models;

namespace CO550_ASP_Razor_Pages_Movies.Pages.Movies
{
    public class CreateModel : PageModel
    {
        private readonly CO550_ASP_Razor_Pages_Movies.Data.ApplicationDbContext _context;

        public CreateModel(CO550_ASP_Razor_Pages_Movies.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Movie Movie { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Movie.Add(Movie);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
