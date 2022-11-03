using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Options;

namespace TestBed.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    [BindProperty(SupportsGet = true)]
    public string Culture { get; set; } = "en";

    public List<SelectListItem> Cultures { get; }

    public IndexModel(
        IOptions<RequestLocalizationOptions> requestLocalizationOptions, 
        ILogger<IndexModel> logger
    )
    {
        Cultures = requestLocalizationOptions
            .Value
            .SupportedCultures!
            .Select(x => new SelectListItem(x.DisplayName, x.TwoLetterISOLanguageName))
            .ToList();
        
        _logger = logger;
    }

    public void OnGet()
    {
    }
}