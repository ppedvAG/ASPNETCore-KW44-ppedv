using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPageSamples.Pages.Modul006
{
    public class RouteTemplateSampleModel : PageModel
    {
        //public void OnGet()
        //{

        //}

        //localhost:xxxx/Modul006/RouteTemplateSample/Haribo 
        //public void OnGet(string title) //Haribo
        //{

        //}

        public void OnGet(int year, int month, int day, string title)
        {
        }
    }
}
