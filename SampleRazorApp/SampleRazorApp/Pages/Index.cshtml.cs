using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SampleRazorApp.Pages
{
    public class IndexModel : PageModel
    {
        public string Message { get; set; } = "sample message";
        private string[][] data = new string[][] {
        new string[]{"Taro", "taro@yamada"},
        new string[]{"Hanako", "hanako@flower"},
        new string[]{"Sachiko", "sachiko@happy"}
    };

        //クエリーパラメーターをページモデルにバインドする
        [BindProperty(SupportsGet = true)]
        public int id { get; set; }

        public void OnGet()
        {
            Message = "これはMessageプロパティの値です。";
        }

        public string getData(int id)
        {
            string[] target = data[id];
            return "[名前：" + target[0] + ", メール：" + target[1] + "]";
        }
 
    }
}