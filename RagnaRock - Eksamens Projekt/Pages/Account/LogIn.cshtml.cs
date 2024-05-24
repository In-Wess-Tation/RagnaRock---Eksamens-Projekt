using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;

namespace RagnaRock___Eksamens_Projekt.Pages.Account
{
    public class LogInModel : PageModel
    {
        [BindProperty]
        public Credential Credential { get; set; }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid) return Page();

           
            if (Credential.UserName == "Admin" && Credential.Password == "Fuck321")
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, "admin"),
                    new Claim(ClaimTypes.Email, "admin@mywebsite.com"),
                 
                };

                var Identity = new ClaimsIdentity(claims, "MyCookieAuth");
               
                ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(Identity);


         
                await HttpContext.SignInAsync("MyCookieAuth", claimsPrincipal);

                return RedirectToPage("/Index");

            }
            return Page();
        }
    }

    public class Credential
    {
        [Required] 
        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}