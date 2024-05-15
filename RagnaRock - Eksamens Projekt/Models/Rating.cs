using Microsoft.AspNetCore.Mvc;

namespace RagnaRock___Eksamens_Projekt.Models
{
    public class Rating
    {
        [BindProperty]
        public int Ratings { get; set; }
        [BindProperty]
        public string Comment { get; set; }
        [BindProperty]
        public int Id { get; set; }


        public Rating(int ratings, string comment, int id)
        {
            Ratings = ratings;
            Comment = comment;
            Id = id;
        }









    }
}
