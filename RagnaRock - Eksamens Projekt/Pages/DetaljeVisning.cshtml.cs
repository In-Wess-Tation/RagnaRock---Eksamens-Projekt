using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RagnaRock___Eksamens_Projekt.Models;
using System.Diagnostics;

namespace RagnaRock___Eksamens_Projekt.Pages
{
    public class DetaljeVisningModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
       /* public List<Exhibition> AllExhibitions { get; set; }*/
       public Exhibition Exhibition { get; set; }
        public readonly IExhibitionRepository _repo;
        public DetaljeVisningModel(IExhibitionRepository repo)
        {
            _repo = repo;

        }

        public void OnGet(int id)
        {
            Debug.WriteLine("::::::::::::::::::::::::::::::" + id);
            Exhibition = _repo.Get(id);
        }

        //Handler til at håndtere sletning
        public IActionResult OnGetDelete(int id)
        {
            _repo.Delete(id);
            return Redirect("Listevisning");
        }
    }
}
