namespace RagnaRock___Eksamens_Projekt.Models
{
    public class Exhibition
    {
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string Images { get; set; }
        public string AudioFiles { get; set; }
        public int Id { get; set; }


        public Exhibition(string name, string shortDescription, string description, string images, string audioFiles, int id)
        {
            Name = name;
            ShortDescription = shortDescription;
            Description = description;
            Images = images;
            AudioFiles = audioFiles;
            Id = id;


        }



    }
}
