using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPageSamples.Data;

namespace RazorPageSamples.Pages.Movie
{
    public class ShoppingCartOverviewModel : PageModel
    {
        private readonly MovieDbContext _context; 
        public ShoppingCartOverviewModel(MovieDbContext context)
        {
            _context = context;
        }
        public IList<RazorPageSamples.Models.Movie> Movies { get; set; }

        public void OnGet()
        {
            if (HttpContext.Session.IsAvailable)
            {
                if(HttpContext.Session.Keys.Contains("ShoppingCart"))
                {
                    Movies = InitializeShoppingCart();
                }
            }
        }

        private IList<RazorPageSamples.Models.Movie> InitializeShoppingCart()
        {
            if (!HttpContext.Session.Keys.Contains("ShoppingCart"))
                throw new Exception("Warenkorb ist intern noch nicht verfügbar");

            //IList<RazorPageSamples.Models.Movie> movieList = new List<RazorPageSamples.Models.Movie>();
            List<int> ids = ReadProductIdFromSession();
            List<RazorPageSamples.Models.Movie> tempMovieList = new List<Models.Movie>();
            foreach (int currentArticleId in ids)
            {
                RazorPageSamples.Models.Movie currentMovie = _context.Movie.Find(currentArticleId);
                tempMovieList.Add(currentMovie);
            }
            return tempMovieList;
        }

        private List<int> ReadProductIdFromSession()
        {
            string shoppingCartJsonString = HttpContext.Session.GetString("ShoppingCart");
            List<int> ids = JsonSerializer.Deserialize<List<int>>(shoppingCartJsonString);

            return ids;
        }


        public async Task<IActionResult> OnPostDelete(int? id)
        {
            if (!id.HasValue)
                return BadRequest();

            if (!HttpContext.Session.Keys.Contains("ShoppingCart"))
                throw new Exception ("Warenkorb ist intern nicht verfügbar");

            List<int> ids = ReadProductIdFromSession();

            if(ids.Contains(id.Value))
            {
                ids.Remove(id.Value);

                if (ids.Count == 0)
                    HttpContext.Session.Remove("ShoppingCart");
                else
                {
                    string jsonString = JsonSerializer.Serialize(ids);
                    HttpContext.Session.SetString("ShoppingCart", jsonString);
                }
            }

            return RedirectToPage("./ShoppingCartOverview");
        }
    }
}
