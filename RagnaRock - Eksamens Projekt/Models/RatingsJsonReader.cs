using System.Text.Json;

namespace RagnaRock___Eksamens_Projekt.Models
{
    public class RatingsJsonReader
    {


        public static List<Rating> ReadFromFile(string path)
        {
            string json = File.ReadAllText(path);

            List<Rating> ratings = JsonSerializer.Deserialize<List<Rating>>(json);

            return ratings;
        }





    }
}
