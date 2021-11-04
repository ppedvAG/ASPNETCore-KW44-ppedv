using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPageSamples.Pages.Modul008
{
    public class ViewDataSampleModel : PageModel
    {
        //public string Email { get; set; }
        public void OnGet()
        {
            ViewData.Add("Email", "KevinW@PPEDV.de");
        }
    }
}
