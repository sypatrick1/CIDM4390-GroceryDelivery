using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq;

namespace Food2URazor.Pages.Login;

public class LoginModel : PageModel
{
    [BindProperty]
    public Credential Credential { get; set; }

    private readonly Food2URazor.Data.Food2URazorContext _context;
    public LoginModel(Food2URazor.Data.Food2URazorContext context)
    {
        _context = context;
    }

    // private readonly ILogger<LoginModel> _logger;
    // public LoginModel(ILogger<LoginModel> logger)
    // {
    //     _logger = logger;
    // }

    public void OnGet()
    {

    }
    public IActionResult OnPost()
    {
        var credentialsQuery = _context.Shoppers.Where(s => s.Username == Credential.Username).Select(s => new {s.Password});
        
        IQueryable<string> loginQuery = from s in _context.Shoppers
                                        where s.Username == Credential.Username
                                        select s.Password;
        string pass = loginQuery.First();
        if(pass == Credential.Password)
        {
            return RedirectToPage("/Login/Success");
        }
        else
        {
            return RedirectToPage("/Login/Failed");
        }
    }
}

public class Credential
{
    [Required]
    public string Username { get; set; }

    [Required]
    public string Password { get; set; }
}