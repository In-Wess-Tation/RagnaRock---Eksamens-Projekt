using RagnaRock___Eksamens_Projekt.Models;

namespace RagnaRock___Eksamens_Projekt.Pages
{
    public interface IRatingRepository
    {



        public Rating Get(int id);

        public void Delete(int id);

        public void Add(Rating rating);

        public List<Rating> GetAll();


    }
}
