using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SampleRazorApp.Pages
{
    public class IndexModel : PageModel
    {
        public string Message { get; set; } = "sample message";
        private string Name = "no-name";
        private string Mail = "no-mail";

        public void OnGet()
        {
            Message = "これはMessageプロパティの値です。";
        }

        public string getData()
        {
            return "[名前：" + Name + ", メール：" + Mail + "]";
        }
    }

}