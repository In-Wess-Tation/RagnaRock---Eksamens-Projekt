using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RagnaRock___Eksamens_Projekt.Models;
using Microsoft.AspNetCore.Authorization;
using System.Diagnostics;

namespace RagnaRock___Eksamens_Projekt.Pages
{
    [Authorize]
    public class AdminModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public List<Exhibition> AllExhibitions { get; set; }
        public readonly IExhibitionRepository _repo;
        public string CurrentImage { get; set; }

        public AdminModel(IExhibitionRepository repo, IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
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
            return Redirect("/Admin");
        }

        public async Task<IActionResult> OnPostSave(string Name, string ShortDescription, string Description, string Images, string SoundFiles, int Id)
        {
            Debug.WriteLine("***" + ImageFile.FileName);

            SaveExhibition(Name, ShortDescription, Description, ImageFile.FileName, SoundFiles, Id);

            Id = Id + 1;

            var uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "images");
            var uniqueFileName = Path.GetFileName(ImageFile.FileName);
            var filePath = Path.Combine(uploadsFolder, uniqueFileName);

            Debug.WriteLine("---" + filePath);



            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                await ImageFile.CopyToAsync(fileStream);
            }

            return Redirect("/Admin");

        }

        private void SaveExhibition(string name, string shortDescription, string description, string images, string soundFiles, int id)
        {
            _repo.Add(new Exhibition(name, shortDescription, description, images, soundFiles, id));
        }

        private readonly IWebHostEnvironment _webHostEnvironment;



        [BindProperty]
        public IFormFile ImageFile { get; set; }

        public string Message { get; set; }

    }
}

