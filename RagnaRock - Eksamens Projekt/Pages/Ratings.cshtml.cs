using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RagnaRock___Eksamens_Projekt.Models;
using Microsoft.AspNetCore.Authorization;
using System.Xml;


namespace RagnaRock___Eksamens_Projekt.Pages
{
    public class RatingsModel : PageModel
    {
        /* public int Bed�mmelse { get; set; }
         public string kommentar { get; set; }
         public string Message { get; set; }*/


        private readonly ILogger<IndexModel> _logger;
        public List<Rating> AllRatings { get; set; }
        public object JsonConvert { get; private set; }

        public readonly IRatingRepository _repo;
        public RatingsModel(IRatingRepository repo)
        {
            _repo = repo;
            AllRatings = repo.GetAll();
        }


        public void OnGet()
        {

        }


        public IActionResult OnPost(int Ratings, string Comment, int Id /*string Message*/)
        {
            if (Ratings < 1 || Ratings > 5)
            {
                /*Message = "Bed�mmelsen skal v�re mellem 1 og 5.";*/
                return Page();
            }

            GemBed�mmelseOgKommentar(Ratings, Comment, Id);

           /* Message = "Bed�mmelsen er gemt.";*/
            Ratings = 0;
            Comment = string.Empty;
            Id = Id + 1;

            return Redirect("/Ratings");
        }

        private void GemBed�mmelseOgKommentar(int ratings, string comment, int id)
        {
            _repo.Add(new Rating(ratings, comment, id));
        }







    }
    }
