using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SampleRazorApp.Pages
{
    public class IndexModel : PageModel
    {
        public string Message { get; set; } = "sample message";

        public void OnGet()
        {
            Message = "これはMessageプロパティの値です。";
        }
    }
}