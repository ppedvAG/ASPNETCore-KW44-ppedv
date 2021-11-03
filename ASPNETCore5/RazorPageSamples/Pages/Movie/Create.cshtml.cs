using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPageSamples.Data;
using RazorPageSamples.Models;

namespace RazorPageSamples.Pages.Movie
{
    public class CreateModel : PageModel
    {
        private readonly RazorPageSamples.Data.MovieDbContext _context;

        public CreateModel(RazorPageSamples.Data.MovieDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page(); //Leeres Formular wird angezeigt
        }

        [BindProperty]
        public RazorPageSamples.Models.Movie Movie { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (Movie.Title == "The Crow")
                ModelState.AddModelError("Movie.Title", "Dieser Film steht auf der Blacklist");

            if (!ModelState.IsValid)
            {
                return Page();
            }

            //Bei GUID als ID!!!!!

            //Guid.NewGuid();
            _context.Movie.Add(Movie);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
