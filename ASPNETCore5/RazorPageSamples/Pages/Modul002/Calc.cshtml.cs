using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPageSamples.Pages.Modul002
{
    public class CalcModel : PageModel
    {
        public int Ergebnis { get; set; }
        
        public void OnGet() //Standard Init-Methode, wenn Seite angezeigt werden soll
        {
            Ergebnis = 0;
        }

        public void OnGetHannes()
        {
            Ergebnis = 42;
        }

        //Formular wird an WebServer übertragen
        public void OnPost()
        {
            int eins = int.Parse(Request.Form["eins"].FirstOrDefault());
            int zwei = int.Parse(Request.Form["zwei"].FirstOrDefault());

            Ergebnis = eins + zwei;
        }
    }
}
