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
    public class IndexModel : PageModel
    {
        private readonly RazorPageSamples.Data.MovieDbContext _context;

        //MovieDBContext liegt im IOC-Container und wird hier verwendet
        public IndexModel(RazorPageSamples.Data.MovieDbContext context)
        {
            _context = context;
        }

        //Property List aller Movies
        public IList<RazorPageSamples.Models.Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
