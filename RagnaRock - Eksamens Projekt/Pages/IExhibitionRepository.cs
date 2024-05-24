using RagnaRock___Eksamens_Projekt.Models;

namespace RagnaRock___Eksamens_Projekt.Pages
{
    //Interface
    public interface IExhibitionRepository
    { 
      public void Add(Exhibition e);
        
      public Exhibition Get(int id);

      public void Delete(int id);

      public List<Exhibition> GetAll();

    }
}
