using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPageSamples.Pages.Modul006
{
    public class QueryStringSampleModel : PageModel
    {
        //https://localhost:44303/Modul006/QueryStringSample?month=2&year=1
        public void OnGet(int year, int month)
        {
        }
    }
}
