using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SampleRazorApp.Pages
{
    public class IndexModel : PageModel　
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)　// ILogger=>デバッグ用のログ出力機能を提供
        {
            _logger = logger;
        }

        //RazorPageにアクセスした際に実行される
        //RazorPageではPageModelとPageFileがセットで用意されるため、
        //対応するファイルを自動でレンダリングする
        public void OnGet()
        {

        }
    }
}