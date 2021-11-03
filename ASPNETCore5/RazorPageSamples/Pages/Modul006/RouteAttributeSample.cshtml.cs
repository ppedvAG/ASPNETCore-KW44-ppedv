using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPageSamples.Pages.Modul006
{
    public class RouteAttributeSampleModel : PageModel
    {
        public IActionResult OnGet()
        {
            return RedirectToPage("RouteAttributesDestinationSample", "ABC",
                new { year = 2021, month = 6, day = 12, title = "herr der ringe" });
        }
    }
}
