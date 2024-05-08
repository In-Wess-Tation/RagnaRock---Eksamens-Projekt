namespace RagnaRock___Eksamens_Projekt.Models
{
    public class Exhibition
    {
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string Image { get; set; }
        public int Id { get; set; }


        public Exhibition(string name, string shortDiscription, string image, int id)
        {
            Name = name;
            ShortDescription = shortDiscription;
            Image = image;
            Id = id;


        }



    }
}
