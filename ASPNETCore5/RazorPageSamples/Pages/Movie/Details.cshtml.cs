using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPageSamples.Data;
using RazorPageSamples.Models;

namespace RazorPageSamples.Pages.Movie
{
    public class DetailsModel : PageModel
    {
        private readonly RazorPageSamples.Data.MovieDbContext _context;

        public DetailsModel(RazorPageSamples.Data.MovieDbContext context)
        {
            _context = context;
        }

        public RazorPageSamples.Models.Movie Movie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Movie = await _context.Movie.FirstOrDefaultAsync(m => m.Id == id);

            if (Movie == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
