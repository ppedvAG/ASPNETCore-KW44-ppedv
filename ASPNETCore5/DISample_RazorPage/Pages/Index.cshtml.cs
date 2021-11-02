using DependencyInversionInASPNETCORE;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DISample_RazorPage.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public ICar MockCar; 

        public IndexModel(ILogger<IndexModel> logger, ICar car)
        {
            _logger = logger;
            MockCar = car;
        }

        public void OnGet()
        {
            _logger.LogInformation("Rock me Amadeus");
        }
    }
}
