using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Food2URazor.Pages.Login;

public class SuccessModel : PageModel
{
    private readonly ILogger<SuccessModel> _logger;

    public SuccessModel(ILogger<SuccessModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }

}