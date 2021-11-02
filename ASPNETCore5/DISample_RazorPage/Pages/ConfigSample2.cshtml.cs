using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DISample_RazorPage.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Options;

namespace DISample_RazorPage.Pages
{
    public class ConfigSample2Model : PageModel
    {

        public SampleWebSettings SampleWebSettings;

        public ConfigSample2Model(IOptions<SampleWebSettings> settings)
        {
            SampleWebSettings = settings.Value;
        }
        public ContentResult OnGet()
        {
            return Content($"{SampleWebSettings.Title}\n{SampleWebSettings.Update}");
        }
    }
}
