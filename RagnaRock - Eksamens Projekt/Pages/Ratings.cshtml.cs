using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RagnaRock___Eksamens_Projekt.Models;
using Microsoft.AspNetCore.Authorization;

namespace RagnaRock___Eksamens_Projekt.Pages
{
    public class RatingsModel : PageModel
    {
       /* public int Bedømmelse { get; set; }
        public string kommentar { get; set; }
        public string Message { get; set; }*/

        public void OnGet()
        {

        }

        public void OnPost(string json)
        {
            Console.WriteLine(json);
        }


      /*  public IActionResult OnPost(int Ratings, string Comment, string Message)
        {
            if (Ratings < 1 || Ratings > 5)
            {
                Message = "Bedømmelsen skal være mellem 1 og 5.";
                return Page();
            }

            GemBedømmelseOgKommentar(Ratings, Comment);

            Message = "Bedømmelsen er gemt.";
            Ratings = 0;
            Comment = string.Empty;

            return Page();
        }

        private void GemBedømmelseOgKommentar(int ratings, string comment)
        {
        }*/




        private readonly ILogger<IndexModel> _logger;
        public List<Rating> AllRatings { get; set; }
        public readonly IRatingRepository _repo;
        public RatingsModel(IRatingRepository repo)
        {
            _repo = repo;
            AllRatings = repo.GetAll();
        }



    }
    }
