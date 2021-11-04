using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPageSamples.Pages.Modul007
{
    public class UploadFileModel : PageModel
    {
        public void OnGet()
        {
        }

        public IActionResult OnPost(IFormFile datei)
        {
            FileInfo fileInfo = new FileInfo(datei.FileName);

            if (fileInfo.Extension != "jpeg" || fileInfo.Extension != "jpeg" )
            {
                ModelState.AddModelError("jpegSelection", "Es dürfen nur jpeg Formate hochgeladen werden");
            }

            if (!ModelState.IsValid)
                return Page();

            string savePath = AppDomain.CurrentDomain.GetData("BildVerzeichnis") + @"\images\" + fileInfo.Name;

            using (var fs = new FileStream(savePath, FileMode.Create))
            {
                datei.CopyTo(fs);
            }

            return RedirectToPage("UploadFile");
        }

        
    }
}
