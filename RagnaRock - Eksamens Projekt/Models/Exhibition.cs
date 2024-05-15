namespace RagnaRock___Eksamens_Projekt.Models
{
    public class Exhibition
    {
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string Images { get; set; }
        public string Soundfiles { get; set; }
        public int Id { get; set; }


        public Exhibition(string name, string shortDescription, string description, string images, string soundfiles, int id)
        {
            Name = name;
            ShortDescription = shortDescription;
            Description = description;
            Images = images;
            Soundfiles = soundfiles;
            Id = id;


        }



    }
}
