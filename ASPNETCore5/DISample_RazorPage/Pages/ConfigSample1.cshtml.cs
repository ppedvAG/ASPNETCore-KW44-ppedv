using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DISample_RazorPage.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace DISample_RazorPage.Pages
{
    public class ConfigSample1Model : PageModel
    {
        private readonly IConfiguration _configuration;

        public PositionOptions PositionOptions;

        public ConfigSample1Model(IConfiguration configuration)
        {
            _configuration = configuration;
            PositionOptions = new PositionOptions();

        }
        
        public void OnGet()
        {
            //Wir laden AppSettings-Position in die Model-Klasse PositionOptions
            _configuration.GetSection(PositionOptions.StringPosition).Bind(PositionOptions);
        }

        //public ContentResult OnGet()
        //{
        //    var positionOptions = new PositionOptions();
        //    _configuration.GetSection(PositionOptions.StringPosition).Bind(positionOptions);

        //    return Content($"Title: {positionOptions.Title} \n" +
        //                   $"Name: {positionOptions.Name}");
        //}
    }
}
