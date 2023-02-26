using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Food2URazor.Pages.Login;

public class FailedModel : PageModel
{
    private readonly ILogger<FailedModel> _logger;

    public FailedModel(ILogger<FailedModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }

}