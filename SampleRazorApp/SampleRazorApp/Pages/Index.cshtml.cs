using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


public class IndexModel : PageModel
{
    [BindProperty(SupportsGet = true)]
    public int Num { get; set; }
}