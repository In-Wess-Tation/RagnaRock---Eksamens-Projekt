using RagnaRock___Eksamens_Projekt.Pages;
using System.Diagnostics;

namespace RagnaRock___Eksamens_Projekt.Models
{
    public class RatingJsonRepository : IRatingRepository
    {

        List<Rating> ratings;

        string path = @"C:\Users\Cupcake\OneDrive\Skrivebord\School\repos\RagnaRock - Eksamens Projekt\RagnaRock - Eksamens Projekt\Data\RatingsFile.json";
        public RatingJsonRepository()
        {
            Debug.WriteLine("test");
            ratings = RatingsJsonReader.ReadFromFile(path);
        }


        public List<Rating> GetAll()
        {
            return ratings;
        }

   /*     public void Add(int id)
        {
            if (ratings != null)
            {
                ratings.Add(id);
            }
        }*/

        public Rating Get(int id)
        {
            if (ratings != null)
                return (ratings[ratings.FindIndex(e => e.Id == id)]);
            return null;
        }

        public void Delete(int id)
        {
            //Vi tjekker lige at listen ikke er null eller tom - alternativt ville der blive smidt en exception
            if ((ratings != null) && (ratings.Count > 0))
            {
                //Her leder vi efter elementet gennem linq
                int c = ratings.FindIndex(e => e.Id == id);
                ratings.RemoveAt(ratings.FindIndex(e => e.Id == id));
                RatingsJsonWriter.WriteToFile(path, ratings);
            }
        }

     /*   Rating IRatingRepository.Add(int id)
        {
            throw new NotImplementedException();
        }*/

    }
}
