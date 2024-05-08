using System.Text.Json;

namespace RagnaRock___Eksamens_Projekt.Models
{
    public class JsonReader
    {


        public static List<Exhibition> ReadFromFile(string path)
        {
            string json = File.ReadAllText(path);

            List<Exhibition> exhibitions = JsonSerializer.Deserialize<List<Exhibition>>(json);

            return exhibitions;
        }


    }
}
