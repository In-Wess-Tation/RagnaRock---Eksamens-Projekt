using System.Text.Json;

namespace RagnaRock___Eksamens_Projekt.Models
{
    public class RatingsJsonWriter
    {


        public static void WriteToFile(string path, List<Rating> ratings)
        {
            string json = JsonSerializer.Serialize(ratings);
            File.WriteAllText(path, json);
        }






    }
}
