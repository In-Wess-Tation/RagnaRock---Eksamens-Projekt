using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RagnaRock___Eksamens_Projekt.Models;
using Microsoft.AspNetCore.Authorization;

namespace RagnaRock___Eksamens_Projekt.Pages
{
    [Authorize]
    public class AdminModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public List<Exhibition> AllExhibitions { get; set; }
        public readonly IExhibitionRepository _repo;
        public AdminModel(IExhibitionRepository repo)
        {
            _repo = repo;
            AllExhibitions = repo.GetAll();
        }

        public void OnGet()
        {

        }

        //Handler til at håndtere sletning
        public IActionResult OnGetDelete(int id)
        {
            _repo.Delete(id);
            return Redirect("Listevisning");
        }
    }
}
