using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPageSamples.Models;

namespace RazorPageSamples.Pages.Modul002
{
    public class RazorReferenceModel : PageModel
    {
        public string Username { get; set; }
        public Person[] People { get; set; }

        public void OnGet()
        {
            Username = "Max Mustermann";
            People = new Person[] { new Person("Max", 21), new Person("Sandra", 23), new Person("Andre", 33) };
        }

        public void OnPost()
        {

        }
    }
}
