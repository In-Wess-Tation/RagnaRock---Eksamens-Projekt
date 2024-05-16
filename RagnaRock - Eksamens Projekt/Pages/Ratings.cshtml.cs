using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RagnaRock___Eksamens_Projekt.Models;
using Microsoft.AspNetCore.Authorization;
using System.Xml;


namespace RagnaRock___Eksamens_Projekt.Pages
{
    public class RatingsModel : PageModel
    {
        /* public int Bedømmelse { get; set; }
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

        /*  public void OnPost(string json)
          {
              Console.WriteLine(json);
          }

          public IActionResult Add(Rating ratings)
          {
              _repo.Add(ratings);
              return Redirect("Rating");
          }
  */
        /*

                DatabaseContext _Context; 
                public RatingsModel(DatabaseContext databaseContext)
                {
                    _Context = databaseContext;
                }


                public ActionResult OnPost()
                {
                    Rating rating = AllRatings[0];
                    if (rating != null)
                    {
                        return Page();
                    }

                    rating.Id = 0;
                    var result = _Context.Add(rating);
                    _Context.SaveChanges();
                }

        */





        public IActionResult OnPost(int Ratings, string Comment, int Id /*string Message*/)
        {
            if (Ratings < 1 || Ratings > 5)
            {
                /*Message = "Bedømmelsen skal være mellem 1 og 5.";*/
                return Page();
            }

            GemBedømmelseOgKommentar(Ratings, Comment, Id);

           /* Message = "Bedømmelsen er gemt.";*/
            Ratings = 0;
            Comment = string.Empty;
            Id = Id + 1;

            return Page();
        }

        private void GemBedømmelseOgKommentar(int ratings, string comment, int id)
        {
            _repo.Add(new Rating(ratings, comment, id));
        }








        /*    protected void GemBedømmelseOgKommentar(object sender, EventArgs e, int ratings, string comment, int id)
            {
                var pr = new
                {
                    AllRatings = new[]
                    {
                new Rating
                {
                    Ratings = ratings;
                    Comment = comment;
                    Id = id;
                }
                    }
                };

                string json = JsonConvert.SerializeObject(pr, Formatting.Indented);
                System.IO.File.WriteAllText(@"C:\Users\Cupcake\OneDrive\Skrivebord\School\repos\RagnaRock - Eksamens Projekt\RagnaRock - Eksamens Projekt\Data\RatingsFile.json", json);
            }*/







    }
    }
