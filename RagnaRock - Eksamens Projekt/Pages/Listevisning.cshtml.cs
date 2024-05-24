using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RagnaRock___Eksamens_Projekt.Models;
using Microsoft.AspNetCore.Authorization;


namespace RagnaRock___Eksamens_Projekt.Pages
{
   
    public class ListevisningModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public List<Exhibition> AllExhibitions { get; set; }
        public readonly IExhibitionRepository _repo;

        public ListevisningModel(IExhibitionRepository repo)
        {
            _repo = repo;
            AllExhibitions = repo.GetAll();
        }

        public void OnGet()
        {

        }

    }
}
