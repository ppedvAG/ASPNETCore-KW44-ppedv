using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DISample_RazorPage.Models
{
    public class PositionOptions
    {
        public const string StringPosition = "Position";

        //Achtung bei Property-Namen -> diese müssen der in AppSettings gleich sein
        public string Title { get; set; }
        public string Name { get; set; }
    }
}
