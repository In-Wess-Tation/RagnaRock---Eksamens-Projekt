using System.Text.Json;

namespace RagnaRock___Eksamens_Projekt.Models
{
    public class JsonWriter
    {


        public static void WriteToFile(string path, List<Exhibition> exhibitions)
        {
            string json = JsonSerializer.Serialize(exhibitions);
            File.WriteAllText(path, json);
        }



    }
}
