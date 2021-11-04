using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPageSamples.Pages.Movie
{
    //[Authorize("Admin")]

    [Authorize]
    public class AuthPageModel : PageModel
    {
        
        public void OnGet()
        {
        }
    }
}
