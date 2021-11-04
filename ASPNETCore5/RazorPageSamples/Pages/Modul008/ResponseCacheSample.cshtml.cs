using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPageSamples.Pages.Modul008
{
    //[ResponseCache(Duration = 30, Location = ResponseCacheLocation.Any)]



    //[ResponseCache(VaryByHeader = "User-Agent", Duration = 30000)]
    public class ResponseCacheSampleModel : PageModel
    {
        //public DateTime LastAccessAt { get; set; }


        
        public void OnGet()
        {
            //LastAccessAt = DateTime.Now;
        }
    }
}
