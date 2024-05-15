namespace RagnaRock___Eksamens_Projekt.Models
{
    public class Rating
    {
        public int Ratings { get; set; }
        public string Comment { get; set; }
        public int Id { get; set; }


        public Rating(int ratings, string comment, int id)
        {
            Ratings = ratings;
            Comment = comment;
            Id = id;
        }









    }
}
